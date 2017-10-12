using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Doctor : Hospital_Employee
    {
        protected string specialtyArea;
        



        public Doctor(string employeeName, int employeeNumber, string specialtyArea) 
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;

        }
    }
}
