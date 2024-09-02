using Sirenix.Serialization;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace TEngine
{
    /// <summary>
    /// 实用函数集。
    /// </summary>
    public static partial class Utility
    {

    }

    public static class StreamHelper
    {
        /// <summary>
        /// 根据类型获取字节长度,转换为字符数组,返回接受了大小端转换的字节数组;
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="length"></param>
        /// <returns></returns>

        public static byte[] GetBytes<T>(this System.IO.Stream stream) where T : struct
        {
           var length= Marshal.SizeOf<T>();
            var buffer = new byte[length];
            stream.Read(buffer, 0, length);
            Array.Reverse(buffer);
            return buffer;
        }

        /// <summary>
        /// 把字节写入流
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <param name="value"></param>
        public static void SetBytes<T>(this Stream stream, T value) where T : struct
        {
            var length = Marshal.SizeOf<T>();
            var buffer = new byte[length];

            // 将结构体转换为字节数组GCHandle：
           //使用 GCHandle 来固定字节数组的内存地址，以便可以安全地将结构体数据复制到字节数组中。
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                Marshal.StructureToPtr(value, handle.AddrOfPinnedObject(), false);
                Array.Reverse(buffer); // 可选：如果需要倒转字节序
                stream.Write(buffer, 0, length);
            }
            finally
            {
                handle.Free();
            }
        }
    }

}
