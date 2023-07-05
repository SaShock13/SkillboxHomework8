using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHomework8_2
{
    internal class PhoneBook
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        string phoneNumber = "";
        string fullName = "";
        string value = "";
       // bool flag = true;
        bool exit = false;

        public void SaveInformation()
        {
            while (exit==false)
            {

                Console.Write("Введите номер телефона : ");
                phoneNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(phoneNumber)) break;
                if (!dic.ContainsKey(phoneNumber))
                {
                    while (true)
                    {
                        Console.Write("Введите ФИО : ");
                        fullName = Console.ReadLine();
                        Console.WriteLine();
                        if (!string.IsNullOrEmpty(fullName))
                        { 
                            dic.Add(phoneNumber, fullName);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Номер " + phoneNumber + " уже существует! Попробуйте еще раз.");
                    Console.WriteLine();
                }

                ExitOrNot();

            }
        }
        public void GetContact()
        {
            exit=false;
            while (exit==false)
            {
                Console.WriteLine("Введите номер телефона для поиска : ");

                phoneNumber = Console.ReadLine();
                if (phoneNumber != "")
                {
                    if (dic.TryGetValue(phoneNumber, out value))
                    {
                        Console.WriteLine("Номер телефона " +
                            "" + phoneNumber + " принадлежит " + value);
                    }
                    else
                    {
                        Console.WriteLine("Телефонный номер  " + phoneNumber + " не найден в телефонной книге.");
                    }
                } 
            }

            ExitOrNot();
            

        }

        private void ExitOrNot()
        {
            Console.Write("Продолжить?: (д/н)");
            if (!(Console.ReadLine().ToLower() == "д"))
            {
                exit = true;
            }
        }
    }
}
