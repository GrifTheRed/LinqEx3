﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //DONE: Print the Sum of numbers

            var sum = numbers.Sum();

            Console.WriteLine($"Sum: {sum}");

            ////Done: Print the Average of numbers
            
            var avg = numbers.Average();

            Console.WriteLine($"Average: {avg}");

            //Done: Order numbers in ascending order and print to the console

            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));

            var asc = numbers.OrderBy(x => x);

            Console.WriteLine("Asc");

            foreach (var num in asc)
            {
                Console.WriteLine(num);
            }

            //Done: Order numbers in decsending order adn print to the console

            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            var desc = numbers.OrderByDescending(x => x);

            //Done: Print to the console only the numbers greater than 6
            numbers.Where(num => num > 6).ToList().ForEach(num => Console.WriteLine(num));

            var greaterThanSix = numbers.Where(x => x > 6);

            foreach (var item in greaterThanSix)
            {
                Console.WriteLine(item);
            }

            //Done: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            foreach (var num in asc.Take(4))
            {
                Console.WriteLine(num);
            }

            //Done: Change the value at index 4 to your age, then print the numbers in decsending order

            numbers[4] = 31;
            Console.WriteLine("With my age");
            foreach (var item in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine(item);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //Done: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.

            employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FirstName));

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FullName);
            }

            //Done: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));


            //Done: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35

            var yoeEmployees = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

            var sumOfYOE = yoeEmployees.Sum(emp => emp.YearsOfExperience);

            var avgOfYOE = yoeEmployees.Average(emp => emp.YearsOfExperience);

            Console.WriteLine($"Sum {sumOfYOE} Avg {avgOfYOE}");

            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("Charlie", "Griffin", 22, 1)).ToList();

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.Age} {emp.YearsOfExperience}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}