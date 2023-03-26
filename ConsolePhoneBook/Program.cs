using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    internal class Program
    {
        static void Mainoption()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("1) Add Person");
            Console.WriteLine("2) Show Person");
            Console.WriteLine("3) Search Person");
            Console.WriteLine("4) Delete Person");
            Console.WriteLine("0) Exit !");
            Console.WriteLine("--------------------");
        }

        static void AddPersonOption()
        {
            Console.WriteLine("1) Add Student");
            Console.WriteLine("2) Add Employee\n");
        }

        static void Main(string[] args)
        {

            bool flag = false;

            do
            {
                Console.WriteLine(" ** Club-100 **");
                Mainoption();
                Console.Write("Enter the option : ");
                int mainOption = Convert.ToInt32(Console.ReadLine());

                if (mainOption == 1)
                {
                    Console.WriteLine("Choosen : Add Member\n");
                    AddPersonOption();
                    Console.Write("Enter the option : ");
                    int PersonOption = Convert.ToInt32(Console.ReadLine());

                    if (PersonOption == 1)
                    {
                        //Add Student;
                        Console.Write("How Many Student Want to Add : ");
                        int AddNumberStudent = Convert.ToInt32(Console.ReadLine());
                        int a = 0;
                        while (a < AddNumberStudent)
                        {
                            Console.Write("Enter Name : ");
                            string Name = Console.ReadLine();
                            Console.Write("Enter Age :");
                            byte Age = Convert.ToByte(Console.ReadLine());
                            Console.Write("Enter BloodGroup : ");
                            string BloodGroup = Console.ReadLine();
                            Console.Write("Enter Address : ");
                            string Address = Console.ReadLine();
                            Console.WriteLine("Enter Birthday : ");
                            Console.Write("Enter Date : ");
                            int Date = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Month (IN WORD): ");
                            string Month = Console.ReadLine();
                            Console.Write("Enter Year : ");
                            int Year = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter CGPA : ");
                            double Cgpa = Convert.ToDouble(Console.ReadLine());
                            Club100.AddPerson(new Student(Name, Age, BloodGroup, Address, new DateFormate(Date, Month, Year), Cgpa));
                            Console.WriteLine();
                            a++;
                        }
                        
                    }
                    else if (PersonOption == 2)
                    {
                        // Add Employee;
                        Console.Write("How Many Employee Want to Add : ");
                        int AddNumberStudent = Convert.ToInt32(Console.ReadLine());
                        int a = 0;
                        while (a < AddNumberStudent)
                        {
                            Console.Write("Enter Name : ");
                            string Name = Console.ReadLine();
                            Console.Write("Enter Age :");
                            byte Age = Convert.ToByte(Console.ReadLine());
                            Console.Write("Enter BloodGroup : ");
                            string BloodGroup = Console.ReadLine();
                            Console.Write("Enter Address : ");
                            string Address = Console.ReadLine();
                            Console.WriteLine("Enter Birthday : ");
                            Console.Write("Enter Date : ");
                            int Date = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Month (IN WORD): ");
                            string Month = Console.ReadLine();
                            Console.Write("Enter Year : ");
                            int Year = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Salary : ");
                            double Salary = Convert.ToDouble(Console.ReadLine());
                            Club100.AddPerson(new Employee(Name, Age, BloodGroup, Address, new DateFormate(Date, Month, Year), Salary));
                            Console.WriteLine();
                            a++;
                        }
                    }



                }
                else if (mainOption == 2)
                {
                    Console.WriteLine("Choosen : Show All Member\n");
                    Club100.ShowAll();
                }
                else if (mainOption == 3)
                {
                    Console.WriteLine("Choosen : Search Member\n");
                    Console.Write("Search Data : ");
                    string searchData = Console.ReadLine();
                    Club100.SearchPerson(searchData,out int DataInfo);
                }
                else if (mainOption == 4)
                {
                    Console.WriteLine("Choosen : Delete Member\n");
                    Console.Write("Delete Data : ");
                    string DeleteData = Console.ReadLine();
                    Club100.DeletePerson(DeleteData);
                }
                else if (mainOption == 0)
                {
                    break;
                }
            } while (true);
            }
    }
}
