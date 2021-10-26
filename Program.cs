using System;
using System.IO;

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
        {
            Console.Clear();
            Console.WriteLine("Type path to file to open:");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void CreateFile()
        {
            Console.Clear();
            Console.WriteLine("Write your text (Esc to leave)");
            Console.WriteLine("---------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            SaveFile(text);
        }

        static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("Type the path of file");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"File successfully written in {path}");
            Console.ReadLine();
            Menu();
        }
    }
}
