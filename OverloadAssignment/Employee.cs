using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadAssignment
{
    public class Employee
    {
        //declare data member
        private int id;
        private string name;
        private double salary;

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public string DisplayData()
        {
            return $"Id={id}, Name={name}, Salary={salary}";
        }
    }
}
