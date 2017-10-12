using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Surgeon : Hospital_Employee
    {
        protected bool isOperating;


        public Surgeon(string employeeName, int employeeNumber, string specialtyArea, bool isOperating)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.isOperating = isOperating;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " " + "operating" + " " + isOperating;
        }

    }
}
