using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinaryTree;

namespace QueryBinaryTree
{
    class Program
    {
        static void doWork()
        {
            // Fill the information from an encapsulated method.
            Tree<Employee> empTree = DataFill.FillWithData();

            Console.WriteLine("List of departments");

            var depts = empTree.Select(d => d.Department).Distinct();

            // List of departments
            // Department: IT
            // Department: Marketing
            // Department: Sales
            foreach (var dept in depts)
            {
                Console.WriteLine("Department: {0}", dept);
            }

            // ----------------------------------------------------------------

            Console.WriteLine("\nEmployees in the IT department");

            var ITEmployees = empTree.Where(e => String.Equals(e.Department, "IT"))
                                                       .Select(emp => emp);

            // Employees in the IT department
            // Id: 1, Name: Kim Abercrombie, Dept: IT
            // Id: 4, Name: Charlie Herb, Dept: IT
            foreach (var emp in ITEmployees)
            {
                Console.WriteLine(emp);
            }

            // ----------------------------------------------------------------

            Console.WriteLine("\nAll employees grouped by department");

            var employeesByDept = empTree.GroupBy(e => e.Department);

            // All employees grouped by department
            // Department: IT
            //         Kim Abercrombie
            //         Charlie Herb
            // Department: Marketing
            //         Jeff Hay
            //         Tim Litton
            // Department: Sales
            //         Dave Barnet
            //         Chris Preston

            foreach (var dept in employeesByDept)
            {
                Console.WriteLine("Department: {0}", dept.Key);

                foreach (var emp in dept)
                {
                    Console.WriteLine("\t{0} {1}", emp.FirstName, emp.LastName);
                }
            }
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
