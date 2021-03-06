﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add and save new Student to DB via EF
            using (var context = new SchoolDBContext())
            {
                Student student = new Student()
                {
                    StudentName = "Ron Buchanan"
                };

                context.Students.Add(student);
                context.SaveChanges();
                Console.Write("Changes saved. Press any key to exit.");
                Console.ReadLine();
            }
        }
    }
}
