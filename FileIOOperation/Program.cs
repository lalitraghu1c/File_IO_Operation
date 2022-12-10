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
                Console.WriteLine(" 1. Checking Whether the File Exists or Not\n 2. Read All Lines");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FileOperation.FileExist();
                        break;
                    case 2:
                        FileOperation.ReadAllLines();
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