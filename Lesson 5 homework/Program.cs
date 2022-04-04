using System;
using System.IO;

namespace Lesson_5_homework
{
    internal class Program
    {
        //Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.

        static void Main(string[] args)
        {
            string filename = "Randomfile.bin";

            File.WriteAllText(filename, Console.ReadLine());

        }
    }
}
