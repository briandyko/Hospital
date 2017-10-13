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
            Console.WriteLine(doctor1.GetPaid());

            Surgeon surgeon1 = new Surgeon("Dr Dyko", 8274, "Liver", true);
            Console.WriteLine(surgeon1.GetInfo());
            Console.WriteLine(surgeon1.GetPaid());

            Nurse nurse1 = new Nurse("Nurse Brown", 9901, "ICU", 6);
            Console.WriteLine(nurse1.GetInfo());
            Console.WriteLine(nurse1.GetPaid());

            Receptionist receptionist1 = new Receptionist("Ms. Nelson", 4421, "ER", true);
            Console.WriteLine(receptionist1.GetInfo());
            Console.WriteLine(receptionist1.GetPaid());



            List<string> employees = new List<string>();
            employees.Add(doctor1.EmployeeName);          //why can't I populate like that? I can only hardcode it?
            employees.Add("Dr Dyko");
            employees.Add("Nurse Brown");
            employees.Add(receptionist1.EmployeeName);

            for (int name = 0; name < employees.Count; name++)
            {
                Console.WriteLine(employees[name]);
            }


        }
    }
}
