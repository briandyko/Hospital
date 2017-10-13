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


        public string EmployeeName { get; set; }
        public float PaidAmount { get; set; }
        public float HoursWorked { get; set; }
        public float Salary { get; set; }


        public Hospital_Employee()
        {
            this.hoursWorked = 40f;
            this.salary = 800f;
        }

        //public Hospital_Employee(string employeeName, int employeeNumber)
        //{
        //    this.employeeName = employeeName;
        //    this.employeeNumber = employeeNumber;

            //}

        public virtual string GetInfo()
        {
            return employeeName + " " + employeeNumber;
        }

        public virtual float GetPaid()
        {
            //this.hoursWorked = 2f;
            //this.salary = 2f;
            paidAmount = hoursWorked * salary;
            return paidAmount;
        }



    }
}
