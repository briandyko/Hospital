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

        protected float paidAmount;
        protected float hoursWorked;
        protected float salary;


        public Hospital_Employee()
        {
        }

        public Hospital_Employee(string employeeName, int employeeNumber)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.hoursWorked = 40.0f;
        }

        public virtual string GetInfo()
        {
            return employeeName + " " + employeeNumber;
        }

        public virtual float GetPaid()
        {
            paidAmount = hoursWorked * salary;
            return paidAmount;
        }

    }
}
