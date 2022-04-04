using System;
using System.IO;


namespace Lesson_5_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "text.txt";
            File.WriteAllText(filename, Console.ReadLine()); // записываем в файл строку
        }
    }
}
