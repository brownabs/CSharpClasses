using System;
using System.Collections.Generic;

namespace Company
{
    public class Employee
    {
        private string _EmployeeFirstName;
        private string _EmployeeLastName;
        private string _EmployeeTitle;
        private DateTime _EmployeeStartDate;

        public Employee(string firstName, string lastName)
        {
            _EmployeeFirstName = firstName;
            _EmployeeLastName = lastName;

        }

        public DateTime StartDate
        {
            get { return _EmployeeStartDate; }
        }

        public string firstName
        {
            get { return _EmployeeFirstName; }
        }

          public string lastName
        {
            get { return _EmployeeLastName; }
        }


        public void SetEmployeeTitle(string employeeTitle)
        {
            _EmployeeTitle = employeeTitle;
        }


        public void Hire(DateTime DateTime)
        {
            _EmployeeStartDate = DateTime;
        }


        public override string ToString()
        {
            return $@"

Employee List
___________________
First Name: {_EmployeeFirstName}
Last Name: {_EmployeeLastName}
Title:  {_EmployeeTitle}
Hire Date: {StartDate} ";

        }

    }
}