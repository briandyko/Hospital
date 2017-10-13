using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Doctor : Hospital_Employee
    {
      
        public Doctor(string employeeName, int employeeNumber, string specialtyArea) 
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.salary = 1200.0f;
            this.hoursWorked = 60f;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " " + specialtyArea;
        }

        public override float GetPaid()
        {
           return base.GetPaid();
        }
    }
}
