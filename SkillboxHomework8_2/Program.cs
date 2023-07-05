using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHomework8_2
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.SaveInformation();
            phoneBook.GetContact();

        }
       

    }
}
