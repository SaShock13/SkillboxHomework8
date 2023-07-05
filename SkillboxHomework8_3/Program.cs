using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHomework8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string number;
            HashSet<int> set = new HashSet<int>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Please input number : ");
                number = Console.ReadLine();
                if (string.IsNullOrEmpty(number)) exit = true;
                
                else
                {
                    if (int.TryParse(number, out num))
                    {
                        if (!set.Contains(num))
                        {
                            set.Add(num);
                            Console.WriteLine("The number is saved in a HashSet");
                        }
                        else Console.WriteLine("The number is already exist in a HashSet, please try again.");
                    }
                   
                }
            }
        }
    }
}
