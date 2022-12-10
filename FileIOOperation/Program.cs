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
                Console.WriteLine(" 1. Checking Whether the File Exists or Not\n 2. Read All Lines\n 3. Read All Text\n 4. Copying File\n 5. Deleting File\n 6. Read From StreamReader");
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
                    default:
                        choice = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}