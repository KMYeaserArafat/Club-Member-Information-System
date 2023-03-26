using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    internal class Student:Person
    {
        private string id;
        private  static int genarate = 0;
        private double cgpa;

        internal override string Id
        {
            set { this.id = "S-" + value; }
            get { return this.id; }
        }

        internal double Cgpa
        {
            set { this.cgpa = value; }
            get { return this.cgpa; } 
        }

        internal Student(string name, byte age, string bloodgroup, string address, DateFormate birthday,double cgpa) 
            : base(name,age,bloodgroup,address,birthday)
        {
            this.Id = Convert.ToString(++genarate);
            this.Name = name;
            this.Age = age;
            this.BloodGroup= bloodgroup;
            this.Address = address;
            this.Birthday = birthday;
            this.Cgpa = cgpa;
        }

        internal override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"CGPA : {this.Cgpa}\n");
        }


    }
}
