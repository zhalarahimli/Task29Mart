using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public bool IsAdult;


        public Person(string name, string surname, int age) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            if (Age >= 18)
            {
                this.IsAdult = true;

            }
            else { IsAdult = false; }
        }
    }

}
