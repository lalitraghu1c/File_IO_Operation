using Binary;
using FileIOOperation;
using System;

namespace FileIOOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To File Operation Methods");
            Console.WriteLine("Select Below Option");
            bool choice = true;
            while (choice)
            {
                Console.WriteLine(" 1. Checking Whether the File Exists or Not\n 2. Read All Lines\n 3. Read All Text\n 4. Copying File\n 5. Deleting File\n 6. Read From StreamReader\n 7. Write Using StreamWriter\n 8. Binary Serialization\n 9. Binary De-Serialization\n 10. Json Serialization\n 11. Json Serialization and De-Serialization");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FileOperation.FileExist();
                        break;
                    case 2:
                        FileOperation.ReadAllLines();
                        break;
                    case 3:
                        FileOperation.ReadAllText();
                        break;
                    case 4:
                        FileOperation.CopyFile();
                        Console.WriteLine("File Copied Successfully");
                        break;
                    case 5:
                        FileOperation.DeleteFile();
                        Console.WriteLine("File Deleted Successfully");
                        break;
                    case 6:
                        FileOperation.ReadFromStreamReader();
                        break;
                    case 7:
                        FileOperation.WriteUsingStreamWriter();
                        break;
                    case 8:
                        BinarySerialization.Serialization();
                        break;
                    case 9:
                        BinarySerialization.Deserialization();
                        break;
                    case 10:
                        JSONSerialization.JsonSerialization();
                        break;
                    case 11:
                        JSONSerialization.JsonDeSerialization();
                        break;
                    default:
                        choice = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}