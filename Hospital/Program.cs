using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("High St. Hospital Employees \n");

            Doctor doctor1 = new Doctor("Dr Gomez", 7832, "Pediatrics");
            Console.WriteLine(doctor1.GetInfo());
        }
    }
}
