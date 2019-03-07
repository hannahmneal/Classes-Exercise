using System;
using System.Collections.Generic;

namespace Program
{

    /*
                2. Create a custom type for Company. A company has the following properties.
                    - Date founded (DateTime)
                    - Company name (string)
                    - Employees (List<Employee>)
     */

    public class Company
    {
        // Constructor: A constructor is a special method in a class that is called when a new class is instantiated. It ensures that the new object is set up and ready for use immediately after it is created.
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string argCompanyName, DateTime argCreatedOn) {

            CompanyName = argCompanyName;
            CreatedOn = argCreatedOn;
            Worker = new List<Employee>();
        }
        public string CompanyName { get; set; } = "";
        public DateTime CreatedOn { get; set; }

        public List<Employee> Worker {get; set;}

        /*
            The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
        */
        public void ListEmployees() {

            foreach (Employee hired in Worker) {
                Console.WriteLine($"{hired.EmployeeFirstName} {hired.EmployeeLastName} has worked at {CompanyName} as a {hired.EmployeeTitle} since {hired.StartDate}");
            }
        }

        public void CompanyInfo() {
            Console.WriteLine($"{CompanyName} was founded on {CreatedOn}");
        }
    }

}


