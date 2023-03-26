using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    internal class Club100
    {

        private static Person[] personList = new Person[1000];
        private static int count = 0;
       
        internal static void AddPerson(Person p)
        {
            personList[count] = p;
            count++;
        }

        internal static void ShowAll()
        {
            int index = 0;

            while(index< personList.Length)
            {
                if (personList[index] != null)
                {
                    personList[index].showInfo();
                }
                index++;
            }
        }


        internal static bool SearchPerson(string key,out int DataInfo)
        {
            bool found = false;
            int index = 0;
          

            while (index < count)
            {
               if(key == personList[index].Id)
                {
                    Console.WriteLine("Found Data...");
                    personList[index].showInfo();
                    found = true;
                    DataInfo = index;
                    return found;
                   
                }
                index++;
            }
            if (!found)
            {
                Console.WriteLine("Not Found Data !");
                DataInfo = index;
                return found;
            }
            DataInfo= index;
            return found;
        }


        internal static void DeletePerson(string key)
        {
             int indexInfo;
            bool condition = SearchPerson(key,out indexInfo);
            if(condition)
            {
                personList[indexInfo] = null;
                Console.WriteLine("Data Deleted");
            }
           
        }

    }
}
