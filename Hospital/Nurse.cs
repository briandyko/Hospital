using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Nurse : Hospital_Employee
    {
        protected int numberofPatients;


        public Nurse(string employeeName, int employeeNumber, string department, int numberofPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.numberofPatients = numberofPatients;
        }
    }
}
