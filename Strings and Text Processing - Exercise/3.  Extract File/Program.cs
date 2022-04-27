using System;

namespace _3.__Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();

            string info = file.Substring(file.LastIndexOf('\\') + 1);
            int lastDot = info.LastIndexOf('.');
            string fileName = info.Substring(0, lastDot);
            string extension = info.Substring(lastDot + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
