using System;
using System.Text;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\plami\Desktop\work_folder2\PU_IntroCSharp_InClass1801681065\PUInClass\CandyShop\files\students.txt");
            System.Console.WriteLine("Contents of students.txt=");
            int tStudents = 0;
            foreach(string line in lines)
            {
                string[] elements = line.Split(' ');
                string firstName = elements[1];
                string name = $"{ firstName} {elements[3]}";
                int sum = 0;
                for (int i = 0; i < firstName.Length; i++)
                {
                    sum += (int)firstName[i];
                }
                if(sum>9000)
                {
                    tStudents += 1;
                    Console.WriteLine($"Candy for {name} => {firstName.Length}");
                }
            }
            Console.WriteLine($"TOTAL LINES {lines.Length}");
            Console.WriteLine($"Total candy students:{tStudents}");

            Console.ReadKey();
        }
    }
}
