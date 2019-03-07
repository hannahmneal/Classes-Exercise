﻿using System;

namespace Program
{
            /*

            Using C# classes, you need to create custom types to represent an Employee and a Company. Then you will create some employees, hire them into the company and then display a simple report showing the employee names and their titles.

            Instructions
            1. Create a custom type for Employee. An employee has the following properties:
                - First name (string)
                - Last name (string)
                - Title (string)
                - Start date (DateTime)
            2. Create a custom type for Company. A company has the following properties.
                - Date founded (DateTime)
                - Company name (string)
                - Employees (List<Employee>)
            3. The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
            4. In the Main method of your console application, create a new instance of Company, and three instances of Employee. Then assign the employees to the company.

             */
class Program
{
    static void Main(string[] args)
    {

        // Create three employees

         Employee employee1 = new Employee("Harry", "Potter", "Wizard", new DateTime(2019, 3, 6));

        /*

            employee1.EmployeeFirstName = "Harry";
            employee1.EmployeeLastName = "Potter";
            employee1.EmployeeTitle = "Wizard";
            employee1.StartDate = new DateTime(2019, 3, 6);

            This commented block also works here if used in conjunction with the following constructor in Employee.cs:

            public Employee() {
                Console.WriteLine($"{EmployeeFirstName} {EmployeeLastName}, {EmployeeTitle}, started on {StartDate}");
            }

         */

        Employee employee2 = new Employee("Hermoine", "Granger", "Witch", new DateTime(2019, 6, 3));

        Employee employee3 = new Employee("Hannah", "Neal", "Software Developer", new DateTime(2018, 11, 12));

        // Create an instance of a company. Name it whatever you like.

         Company business1 = new Company("Startup", new DateTime(2017, 1, 13));

        // Assign the employees to the company

         business1.Worker.Add(employee1);
         business1.Worker.Add(employee2);
         business1.Worker.Add(employee3);

        business1.ListEmployees();
        business1.CompanyInfo();

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
    }
}
}
