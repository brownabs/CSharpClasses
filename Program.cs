using System;
using System.Collections.Generic;

namespace Company
{
    public class Company
    {

        // Some read only properties

        public string CompanyName
        {
            get { return _Name; }
        }

        public DateTime DateCreatedOn
        {
            get { return _CreatedOn; }
        }
        private string _Name;
        private DateTime _CreatedOn;
        // Create a public property for holding a list of current employees

        public List<Employee> ListOfEmployees { get; set; } = new List<Employee>();

        public void addEmployee(Employee employee)
        {
            ListOfEmployees.Add(employee);
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created


            The constructor will set the value of the public properties
        */

        public Company(string name, DateTime dateCreated)
        {
            _Name = name;
            _CreatedOn = dateCreated;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Create an instance of a company. Name it whatever you like.
            Company Brewster = new Company("Brewster", DateTime.Now);


            // Create three employees
            Employee Abbey = new Employee("Abbey", "Brown");
            Employee Katerina = new Employee("Katerina", "Freeman");
            Employee Janet = new Employee("Janet", "Woods");

            // Assign the employees to the company
            Abbey.SetEmployeeTitle("Boss");
            Katerina.SetEmployeeTitle("Right Hand");
            Janet.SetEmployeeTitle("Mood Lifter");

            Abbey.Hire(DateTime.Now);
            Katerina.Hire(DateTime.Now);
            Janet.Hire(DateTime.Now);
            Console.WriteLine(Abbey);
            Console.WriteLine(Katerina);
            Console.WriteLine(Janet);

            Brewster.addEmployee(Abbey);
            Brewster.addEmployee(Katerina);
            Brewster.addEmployee(Janet);


            foreach (Employee employee in Brewster.ListOfEmployees)
            {
                Console.WriteLine(employee.StartDate);
                Console.WriteLine(employee.firstName);
                Console.WriteLine(employee.lastName);

            }
        }



        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */

    }
}


