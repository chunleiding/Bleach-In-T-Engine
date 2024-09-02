using UnityEngine;
using System;
using System.Text;
using System.IO;
using System.Collections.Generic;


public static class SerializeUtils
{
    public static void WriteInt(Stream stream, Int32 value)
    {
        var buffer = BitConverter.GetBytes(value);
        Array.Reverse(buffer);

        stream.Write(buffer, 0, buffer.Length);
    }

    public static void WriteString(Stream stream, string value)
    {
        if (value == null)
        {
            WriteInt(stream, 0);
            return;
        }

        var buffer = Encoding.UTF8.GetBytes(value);

        var lengthBuffer = BitConverter.GetBytes(buffer.Length);
        Array.Reverse(lengthBuffer);

        stream.Write(lengthBuffer, 0, lengthBuffer.Length);
        stream.Write(buffer, 0, buffer.Length);
    }

    public static void WriteLong(Stream stream, Int64 value)
    {
        var buffer = BitConverter.GetBytes(value);
        Array.Reverse(buffer);

        stream.Write(buffer, 0, buffer.Length);
    }

    public static void WriteShort(Stream stream, Int16 value)
    {
        var buffer = BitConverter.GetBytes(value);
        Array.Reverse(buffer);

        stream.Write(buffer, 0, buffer.Length);
    }

    public static void WriteByte(Stream stream, byte value)
    {
        stream.WriteByte(value);
    }

    public static void WriteByte(Stream stream, Int32 value)
    {
        stream.WriteByte((byte)value);
    }

    public static void WriteBytes(Stream stream, byte[] value)
    {
        WriteInt(stream, value.Length);
        stream.Write(value, 0, value.Length);
    }

    public static void WriteBean(Stream stream, IMessageSerialize value)
    {
        value.Serialize(stream);
    }

    public static Int32 ReadInt(Stream stream)
    {
        var buffer = new byte[4];
        stream.Read(buffer, 0, 4);
        // Fix bit endian issue
        Array.Reverse(buffer);

        return BitConverter.ToInt32(buffer, 0);
    }

    public static Int32 ReadInt(byte[] buffer)
    {
        // Fix bit endian issue
        Array.Reverse(buffer);

        return BitConverter.ToInt32(buffer, 0);
    }

    public static Int64 ReadLong(Stream stream)
    {
        var buffer = new byte[8];
        stream.Read(buffer, 0, 8);
        Array.Reverse(buffer);

        return BitConverter.ToInt64(buffer, 0);
    }

    public static Int16 ReadShort(Stream stream)
    {
        var buffer = new byte[2];
        stream.Read(buffer, 0, 2);
        Array.Reverse(buffer);

        return BitConverter.ToInt16(buffer, 0);
    }

    public static byte ReadByte(Stream stream)
    {
        return (byte)stream.ReadByte();
    }

    public static byte[] ReadBytes(Stream stream)
    {
        var lengthBuffer = new byte[4];
        stream.Read(lengthBuffer, 0, 4);
        Array.Reverse(lengthBuffer);
        int length = BitConverter.ToInt32(lengthBuffer, 4);

        var buffer = new byte[length];
        stream.Read(buffer, 0, length);

        return buffer;
    }

    public static string ReadString(Stream stream)
    {
        var lengthBuffer = new byte[4];
        stream.Read(lengthBuffer, 0, 4);
        Array.Reverse(lengthBuffer);

        int length = BitConverter.ToInt32(lengthBuffer, 0);
        var buffer = new byte[length];
        stream.Read(buffer, 0, length);

        return Encoding.UTF8.GetString(buffer, 0, length);
    }

    public static T ReadBean<T>(Stream stream) where T : IMessageSerialize, new()
    {
        //var bean = (T)typeof(T).GetConstructor(new Type[] {}).Invoke(new object[] {});
        //var bean = Activator.CreateInstance<T>();
        var bean = new T();

        bean.Deserialize(stream);

        return bean;
    }

}

