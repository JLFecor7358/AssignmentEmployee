using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEmployee
{
    public class Employee : IEmployee
    {
        private string _firstName, _lastName, _employeeID, _employeeType, _salary, _role;
        public Employee(string firstName, string lastName, string employeeID, string employeeType, string salary, string role)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeID = employeeID;
            EmployeeType = employeeType;
            Salary = salary;
            Role = role;
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                _employeeID = value;
            }
        }
        public string EmployeeType
        {
            get
            {
                return _employeeType;
            }
            set
            {
                _employeeType = value;
            }
        }
        public string Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
        public string Role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
            }
        }
    }
}
