using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace SplitFile
{
    class Program
    {
        public const long DWSIZE = 16;
        public static long fileSize = DWSIZE;
        public static string fileName;
        private static string directoryName;
        private static string fileNameWithoutExtension;
        private static string fileExtension;
        private const string FILEFORMAT = "{0}/{1}_{2}{3}";
        
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    OperatorIO();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        static void OperatorIO()
        {
            Console.WriteLine("File Path: ");
            fileName = Console.ReadLine();
            Console.WriteLine("Split File Number: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
                throw new Exception("Invalid Number.");

            FileInfo fileInfo = new FileInfo(fileName);
            fileSize = RoundUpSize((fileInfo.Length + num - 1) / num);

            directoryName = fileInfo.DirectoryName;
            fileExtension = fileInfo.Extension;
            fileNameWithoutExtension = fileInfo.Name.Substring(0, fileInfo.Name.LastIndexOf('.'));
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // Run in sequence is faster than in parallel.
            // Parallel.For(0, num, ReadLength);
            for (int i = 0; i < num; i++)
                ReadLength(i);
            sw.Stop();
            Console.WriteLine("Done: {0}, Elasped: {1}", fileName, sw.Elapsed);
        }

        static void ReadLength(int position)
        {
            string newFileName = string.Format(FILEFORMAT, directoryName, fileNameWithoutExtension, position, fileExtension);
            using (StreamReader sr = new StreamReader(fileName))
            {
                long tempPosition = (long)position * (long)fileSize;
                sr.BaseStream.Position = tempPosition;
                long newSize = sr.BaseStream.Length - tempPosition;
                if (newSize > fileSize)
                    newSize = fileSize;
                using (BinaryReader br = new BinaryReader(sr.BaseStream))
                {
                    byte[] bytes = br.ReadBytes((int)newSize);
                    StreamWriter sw = null;
                    BinaryWriter bw = null;
                    try
                    {
                        sw = new StreamWriter(newFileName, false, sr.CurrentEncoding);
                        bw = new BinaryWriter(sw.BaseStream);
                        bw.Write(bytes);
                        bw.Flush();
                    }
                    finally
                    {
                        if (sw != null)
                            sw.Dispose();

                        if (bw != null)
                            bw.Dispose();
                    }
                }
            }
        }

        private static long RoundUpSize(long size)
        {
            long aSize = DWSIZE;
            if (size < DWSIZE)
                aSize = DWSIZE;
            else
                // Rounds up to the nearest multiple of DSIZE
                aSize = (long)(DWSIZE * ((size + DWSIZE - 1) / DWSIZE));
            return aSize;
        }
    }
}
