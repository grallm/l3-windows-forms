using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks_PartB
{
    class hseDoctor : hseEmployee
    {
        public hseDoctor() : base("A. N. Other", "Doctor", 0, 110000)
        {}

        public hseDoctor(string empName, int empYrsService, double empSalary) : base(empName, "Doctor", empYrsService, empSalary)
        {}

        public override string ToString()
        {
            return "DOCTOR"
                + "\nName: Dr. " + empName
                + "\nNumber: " + empNumber
                + "\nType: " + empType
                + "\nYrs Service: " + empYrsService
                + "\nSalary: " + empSalary.ToString("€#,##0.00")
                + "\nI can PRESCRIBE for patients";
        }
    }
}
