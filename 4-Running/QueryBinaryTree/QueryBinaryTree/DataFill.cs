using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace QueryBinaryTree
{
    class DataFill
    {
        public static Tree<Employee> FillWithData()
        {
            Tree<Employee> tree = new Tree<Employee>
                (
                    new Employee
                    {
                        Id = 1,
                        FirstName = "Kim",
                        LastName = "Abercrombie",
                        Department = "IT"
                    }
                );

            tree.Insert
                (
                    new Employee
                    {
                        Id = 2,
                        FirstName = "Jeff",
                        LastName = "Hay",
                        Department = "Marketing"
                    }
                );

            tree.Insert
                (
                    new Employee
                    {
                        Id = 4,
                        FirstName = "Charlie",
                        LastName = "Herb",
                        Department = "IT"
                    }
                );

            tree.Insert
                (
                    new Employee
                    {
                        Id = 6,
                        FirstName = "Chris",
                        LastName = "Preston",
                        Department = "Sales"
                    }
                );

            tree.Insert
                (
                    new Employee
                    {
                        Id = 3,
                        FirstName = "Dave",
                        LastName = "Barnet",
                        Department = "Sales"
                    }
                );

            tree.Insert
                (
                    new Employee
                    {
                        Id = 5,
                        FirstName = "Tim",
                        LastName = "Litton",
                        Department = "Marketing"
                    }
                );

            return tree;
        }
    }
}
