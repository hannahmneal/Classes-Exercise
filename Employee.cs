using System;

namespace Program {

/*
            1. Create a custom type for Employee. An employee has the following properties:
                - First name (string)
                - Last name (string)
                - Title (string)
                - Start date (DateTime)
 */
public class Employee {

        // Some readonly properties (let's talk about gets, baby)
        public string EmployeeFirstName { get;set;} = "";
        public string EmployeeLastName { get;set;} = "";
        public string EmployeeTitle { get;set;} = "";
        public DateTime StartDate { get;set;}

        public Employee(string argFirstName, string argLastName, string argTitle, DateTime argStartDateTime ) {

            EmployeeFirstName = argFirstName;
            EmployeeLastName = argLastName;
            EmployeeTitle = argTitle;
            StartDate = argStartDateTime;

            // Console.WriteLine($"{EmployeeFirstName} {EmployeeLastName}, {EmployeeTitle}, started on {StartDate}");

            /*
                The "Employee()" constructor is called in Program.cs to create a new instance of an employee. The employee details are defined here and passed into Employee() as arguments.
             */
        }

    }

}

