using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Делегаты

namespace Lesson_6_2023_04_21
{
    delegate void myDel(string _text);
    internal class Program
    {
        static void Print(string _text)
        {
            Console.WriteLine(_text);
        } 
        static void WriteToFile(string _text)
        {
            string _name = "output.txt";
            var sw = new StreamWriter(_name, true);
            sw.WriteLine(_text);
            sw.Close();
           /* using (var sw01 = new StreamWriter(_name, true))
                 sw01.WriteLine(_text);*/
        }
        static void Main(string[] args)
        {
            myDel output;
            output = Print;
            output += WriteToFile;
            /*output($"Hello! {DateTime.Now}");
            output.Invoke($"Hello! {DateTime.Now.ToString("HH:mm:ss.fff")}");*/
            output.Invoke(null);
            output(null);
            Console.ReadKey();
        }
    }
}
