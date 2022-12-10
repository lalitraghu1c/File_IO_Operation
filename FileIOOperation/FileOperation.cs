using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    public class FileOperation
    {
        public static void FileExist()
        {
            string filePath = @"D:\Projects-Bridgelabz\File_IO_Operation\FileIOOperation\Operation.txt";
            if (File.Exists(filePath))
                Console.WriteLine("File Path Exists");
            else
                Console.WriteLine("File Path Doesnt Exists");
        }
        public static void ReadAllLines()
        {
            string filePath = @"D:\Projects-Bridgelabz\File_IO_Operation\FileIOOperation\Operation.txt";
            string[] lines = File.ReadAllLines(filePath);
            foreach (var data in lines)
            {
                Console.WriteLine(data);
            }
        }
        public static void ReadAllText()
        {
            string filePath = @"D:\Projects-Bridgelabz\File_IO_Operation\FileIOOperation\Operation.txt";
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
        public static void CopyFile()
        {
            string filePath = @"D:\Projects-Bridgelabz\File_IO_Operation\FileIOOperation\Operation.txt";
            string destinationFilePath = @"D:\Projects-Bridgelabz\File_IO_Operation\FileIOOperation\Destination.txt";
            File.Copy(filePath, destinationFilePath, true);
        }
        public static void DeleteFile()
        {
            string destinationFilePath = @"D:\Projects-Bridgelabz\File_IO_Operation\FileIOOperation\Destination.txt";
            File.Delete(destinationFilePath);
        }
        public static void ReadFromStreamReader()
        {
            string filePath = @"D:\Projects-Bridgelabz\File_IO_Operation\FileIOOperation\Operation.txt";
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}