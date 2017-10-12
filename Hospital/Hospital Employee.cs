using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital_Employee
    {
        protected string employeeName;
        protected string specialtyArea;
        protected int employeeNumber;
        protected string department;


        public string EmployeeName { get; set; }


        public Hospital_Employee()
        {
        }

        public Hospital_Employee(string employeeName, int employeeNumber)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
        }

        public virtual string GetInfo()
        {
            return employeeName + " " + employeeNumber;
        }

    }
}
