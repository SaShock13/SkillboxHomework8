using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHomework8_1
{
    internal class Program
    {
        static List<int> numbers ;
        static void Main(string[] args)
        {
            numbers = new List<int>();
            FillList(100);
            Console.WriteLine("Список начальный");
            ShowList();
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Список редактированный");
            DeleteNumbersFromList();
            ShowList();
            Console.WriteLine();
            Console.ReadLine();

        }
        static void FillList(int count)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                numbers.Add(rnd.Next(101));
            }
        }
        static void DeleteNumbersFromList()
        {
            numbers.RemoveAll(x => x > 25 & x < 50);
        }
        static void ShowList()
        {
            int count = 1;
            foreach (var item in numbers)
            {

                Console.Write($"{item,4}");
                Console.Write(" ");
                if (count%20==0)
                {
                    Console.WriteLine();
                }
                count++;
            }
        }
    }
}
