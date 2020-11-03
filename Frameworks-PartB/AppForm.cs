using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frameworks_PartB
{
    public partial class AppForm : Form
    {
        List<hseEmployee> allEmployees;

        public AppForm()
        {
            allEmployees = new List<hseEmployee>();
            InitializeComponent();

            // 10 Randoms
            addEmployee(new hseEmployee());
            addEmployee(new hseDoctor());
            addEmployee(new hseDoctor("Antoine C", 5, 120000));
            addEmployee(new hseDoctor("Eva M", 1, 234444.39));
            addEmployee(new hseDoctor("Mathilde", 4, 23444.3));
            addEmployee(new hseEmployee("Romane", "Porter", 10, 10000));
            addEmployee(new hseEmployee("Malo", "Porter", 10, 10000));
            addEmployee(new hseEmployee("Arnas", "Porter", 10, 10000));
            addEmployee(new hseEmployee("Sam Poutnik", "Standard", 10, 10000));
            addEmployee(new hseEmployee("Meeeee", "Standard", 10, 10000));
        }

        // Add an employee to the ListBox
        private void addEmployee(hseEmployee employee)
        {
            allEmployees.Add(employee);
            employeesListBox.Items.Add(employee.empName + " (" + employee.empNumber + ")");
        }

        // Display details of an employee
        private void displayEmployeeDetails(hseEmployee employee)
        {
            dispEmpName.Text = employee.empName;
            dispEmpNumber.Text = employee.empNumber.ToString();
            dispEmpType.Text = employee.empType;
            dispEmpYrs.Text = employee.empYrsService.ToString();
            dispEmpSalary.Text = employee.empSalary.ToString("€#,##0.00");

            if (employee is hseDoctor)
            {
                canPrescribe.Visible = true;
            } else
            {
                canPrescribe.Visible = false;
            }
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(empName.Text) || String.IsNullOrWhiteSpace(empType.Text) || !int.TryParse(empYrs.Text, out _) || !double.TryParse(empSalary.Text, out _))
            {
                return;
            }
            addEmployee(new hseEmployee(empName.Text, empType.Text, int.Parse(empYrs.Text), double.Parse(empSalary.Text)));
        }

        private void employeesListBox_SelectedChanged(object sender, System.EventArgs e)
        {
            if (employeesListBox.SelectedItem != null)
            {
                Match match = Regex.Match(employeesListBox.SelectedItem.ToString(), @".+\s\(([0-9]+)\)");
                int number = int.Parse(match.Groups[1].Value);
                displayEmployeeDetails(allEmployees.Find(emp => number == emp.empNumber));
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
