using UnityEngine;
using System;
using System.Text;
using System.IO;
using System.Collections;
using Ionic.Zlib;


public class DotNetZlib
{
    // Uncompress message data only!!!
    public static void UnCompress(byte[] compressed, int length, Stream outStream)
    {
        try
        {
            outStream.SetLength(0);
            outStream.Position = 0;

            outStream.Write(compressed, 0, 4); //message id

            using (var zOut = new ZlibStream(outStream, CompressionMode.Decompress, true))
            {
                zOut.Write(compressed, 4, length - 4);
                zOut.Flush();
            }

            outStream.Position = 0;
        }
        catch (Exception ex)
        {
            Debug.LogError("Uncompress exception: " + ex.Message);
        }
    }

    // Uncompress stream to string
    public static string UnCompressGZip(byte[] compressed)
    {
        return GZipStream.UncompressString(compressed);
    }

    // Uncompress GZip stream to string
    public static string UnCompress(Stream srcStream)
    {
        using (var sr = new GZipStream(srcStream, CompressionMode.Decompress))
        using (var reader = new StreamReader(sr, Encoding.GetEncoding("UTF-8")))
        {
            return reader.ReadToEnd();
        }
    }
}
