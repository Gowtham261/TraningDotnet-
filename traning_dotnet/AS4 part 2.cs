﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigement_4_part_2
{
    class CLASS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a class now");
            int rollno;
            Console.WriteLine("enter rollno");
            rollno= Convert.ToInt32(Console.ReadLine());
            string name;
            Console.WriteLine("enter name");
            int classs;
            Console.WriteLine("enter classs");
            classs = Convert.ToInt32(Console.ReadLine());
            int sem;
            Console.WriteLine("enter sem");
            sem = Convert.ToInt32(Console.ReadLine());
            // method declaration
            int GetMarks(int subj1 = 25, int subj2 = 35, int subj3 = 45, int subj4 = 55, int subj6 = 75);
            if (GetMarks<35)
            {
                Console.WriteLine("Failed");
            }
            else if (GetMarks>50)
            {
                Console.WriteLine("Passed");
            }
            Console.ReadLine();


        }
    }
}
