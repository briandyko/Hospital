using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Receptionist : Hospital_Employee
    {
        private bool onPhone;


        public Receptionist(string employeeName, int employeeNumber, string department, bool onPhone)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.onPhone = onPhone;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " " + employeeName + " " + department + " " + onPhone; 
        }
    }
}
