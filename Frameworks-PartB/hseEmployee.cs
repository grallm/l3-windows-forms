using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks_PartB
{
    class hseEmployee
    {
        public String empName { get; set; }
        public readonly int empNumber;
        public String empType { get; set; }
        public int empYrsService { get; set; }
        public double empSalary { get; set; }
        private static int id = 0;

        public hseEmployee()
        {
            empName = "A. N. Other";
            empNumber = generateId();
            empType = "Standard";
            empYrsService = 0;
            empSalary = 30000;
        }

        public hseEmployee(string empName, string empType, int empYrsService, double empSalary)
        {
            this.empName = empName;
            this.empType = empType;
            empNumber = generateId();
            this.empYrsService = empYrsService;
            this.empSalary = empSalary;
        }

        private int generateId()
        {
            return id += 100;
        }

        public override string ToString()
        {
            return "EMPLOYEE"
                + "\nName: " + empName
                + "\nNumber: " + empNumber
                + "\nType: " + empType
                + "\nYrs Service: " + empYrsService
                + "\nSalary: " + empSalary;
        }
    }
}
