﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    class Program
    {

        static string Show()
        {
            return "Master Branch for 1st change";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Base.Show());
            Console.ReadKey();
        }
    }
}
