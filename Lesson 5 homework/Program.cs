using System;
using System.IO;


namespace Lesson_5_homework
{
    //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».


    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "statrup.txt";
            
            File.WriteAllText(filename,"Текущая дата и время : " + DateTime.Now + "\nВаш текст : " + Console.ReadLine()); 
            //Первой строчкой выводим время и дату,второй заданный текст. 
            
            

        }
    }
}
