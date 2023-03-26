using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    struct DateFormate
    {
        private int date;
        private string month;
        private int year;

        internal DateFormate(int date, string month, int year)
        {
            this.date = date;
            this.month = month;
            this.year = year;
        }

        internal void showDateInfo()
        {
            Console.WriteLine($"Date : {this.date}, Month :{this.month}, Year:{this.year}");
        }
    }
  abstract internal class Person
    {
        private string id;
        private static int generate = 0;
        private string name;
        private byte age;
        private string bloodGroup;
        private string address;
        private DateFormate birthday;


        internal virtual string Id
        {
            set { this.id = "Person - " + value; }
            get { return this.id; }
        }

        internal string Name
        {
            set; get;
        }

        internal byte Age
        {
            set;get;
        }

        internal string BloodGroup
        {
            set; get;
        }

        internal string Address
        {
            set; get;
        }

        internal DateFormate Birthday
        {
            get; set;
        }

        internal Person(string name, byte age, string bloodgroup, string address, DateFormate birthday)
        {
            this.Id = (++generate).ToString();
            this.Name = name;
            this.Age = age;
            this.BloodGroup = bloodgroup;
            this.Address = address;
            this.Birthday = birthday;
        }

        internal virtual void showInfo()
        {
            Console.WriteLine($"ID : {this.Id}");
            Console.WriteLine($"Name : {this.Name}");
            Console.WriteLine($"Age  : {this.Age}");
            Console.WriteLine($"BloodGroup : {this.BloodGroup}");
            Console.WriteLine($"Address : {this.Address}");
            Console.Write("Bithday :");
            this.Birthday.showDateInfo();
        }
    }
}
