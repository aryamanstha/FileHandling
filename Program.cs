using System;
using static FileHandling.StudentCollection;
using System.Collections.Generic;

namespace FileHandling
{
    public class Program
    {
        public static void SaveFile(List<string> strings)
        {
            StreamWriter sw = File.AppendText("demo.txt");
            foreach(string s in strings)
            {
                sw.WriteLine(s);
            }
            sw.Flush();
            sw.Close();
        }
        public static void ReadFile()
        {
            try
            {
                StreamReader sr = new StreamReader("demo.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("The file cannot be read.");
            }
            
        }
        public static void FileSave()
        {
            List<string> list = new List<string>();
             top:
            Console.WriteLine("Enter the string to save:");
            string value = Console.ReadLine();
            list.Add(value);
            SaveFile(list);
            Console.WriteLine("Do you want to add more?(y/n)");
            string ch = Console.ReadLine();
            if (ch == "Y" || ch == "y")
            {
                goto top;
            }
            Console.WriteLine("The Contents in file are:");
            ReadFile();
        }
        public static void Main(string[] args)
        {
            FileSave();
            StudentCollection.DisplayList();
        }
    }
}