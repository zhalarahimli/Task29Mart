﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ali", "Aliyev", 15);
            Console.WriteLine(person1.IsAdult);
        }
    }
}
