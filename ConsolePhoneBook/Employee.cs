using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    internal class Employee:Person
    {
        private string id;
        private static int generate = 0;
        private double salary;

        internal override string Id
        {
            set { this.id = "E-" + value; }
            get { return this.id; }
        }

        internal double Salary
        {
            set;get;
        }

        internal Employee(string name, byte age, string bloodgroup, string address, DateFormate birthday, double salary)
            : base(name, age, bloodgroup, address, birthday)
        {
            this.Id = (++generate).ToString();
            this.Name = name;
            this.Age = age;
            this.BloodGroup = bloodgroup;
            this.Address = address;
            this.Birthday = birthday;
            this.Salary = salary;
        }

        internal override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"Salary  : {this.Salary}\n");
        }

    }
}
