using System;
using System.Collections.Generic;
using System.Text;

namespace Demo02
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} with Salary: {Salary}";
        }
    }
}
