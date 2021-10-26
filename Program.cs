using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Want do you want do?");
            Console.WriteLine("1 - Open file text");
            Console.WriteLine("2 - Make new file text");
            Console.WriteLine("----------------------");
            Console.WriteLine("0 - Exit");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: OpenFile(); break;
                case 2: CreateFile(); break;
                default: Menu(); break;
            }
        }

        static void OpenFile()
        { }
        static void CreateFile()
        {
            Console.Clear();
            Console.WriteLine("Write your text (Esc to leave)");
            Console.WriteLine("---------------");
            string text = "";



        }
    }
}
