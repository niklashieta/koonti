using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();
            em.Name = "Kirsi Kernel";
            em.Profession = "Teacher";
            em.Salary = 8000;
            Boss uh = new Boss();
            uh.Name = "Jorma Kyrpanaama";
            uh.Profession = "Kova aija";
            uh.Salary = 200;
            uh.Car = "Opel";
            uh.Bonus = 50;
            Console.WriteLine("Name: " + em.Name + " Profession: " + em.Profession + " Salary: " + em.Salary);
            Console.WriteLine("Name: " + uh.Name + " Profession: " + uh.Profession + " Salary: " + uh.Salary +
                " Car: " + uh.Car + " Bonus: " + uh.Bonus);
        }
    }