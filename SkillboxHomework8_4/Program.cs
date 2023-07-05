using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillboxHomework8_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Сериализация xml

            Console.WriteLine("Введите полное имя: ");
            XAttribute name = new XAttribute("ФИО", Console.ReadLine());
            Console.WriteLine("Введите улицу: ");
            XAttribute street = new XAttribute("Улица", Console.ReadLine());
            Console.WriteLine("Введите номер дома:");
            XAttribute house = new XAttribute("НомерДома", Console.ReadLine());
            Console.WriteLine("Введите номер квартиры: ");
            XAttribute flat = new XAttribute("НомерКвартиры", Console.ReadLine());
            Console.WriteLine("Введите мобильный телефон: ");
            XAttribute mobNum = new XAttribute("МобильныйТелефон", Console.ReadLine());
            Console.WriteLine("Введите домашний телефон: ");
            XAttribute flatNum = new XAttribute("ДомашнийТелефон", Console.ReadLine());

            XElement Person = new XElement("Person");
            XElement Address = new XElement("Address");
            XElement Street = new XElement("Street");
            XElement HouseNumber = new XElement("HouseNumber");
            XElement FlatNumber = new XElement("FlatNumber");
            XElement Phones = new XElement("Phones");
            XElement MobilePhone = new XElement("MobilePhone");
            XElement FlatPhone = new XElement("FlatPhone");

            Person.Add(Address, Phones, name);
            Address.Add(Street, HouseNumber, FlatNumber);
            Phones.Add(MobilePhone, FlatPhone);
            Street.Add(street);
            HouseNumber.Add(house);
            FlatNumber.Add(flat);
            MobilePhone.Add(mobNum);
            FlatPhone.Add(flatNum);

            Person.Save("_person.xml");
            #endregion


            #region Десериализация xml
            //string xml = File.ReadAllText("_person.xml");

            ////var attr = XDocument.Parse(xml).Descendants("Person").Descendants("Address").Descendants("Street").ToList();
            //var attr = XDocument.Parse(xml).Descendants("Person").Descendants("Address").ToList();

            //foreach (var item in attr)
            //{
            //    Console.WriteLine(item);
            //    
            //}
            #endregion

        }
    }
}
