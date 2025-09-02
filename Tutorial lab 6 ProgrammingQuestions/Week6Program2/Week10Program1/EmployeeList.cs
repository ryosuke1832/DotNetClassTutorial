using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Program2
{
    class EmployeeList
    {
        // Write code for to Create a List to store the information from emp.txt file


        // EmployeeList constructor
        public EmployeeList()
        {
            // Create an instance of List<>
            
        }

        // Method to process a string which contain a single line for the emp.txt
        // The lfile name is passed as a parameter to the Method
        public void LoadEmployees(string filename)
        {
            // Read the file content using the StreamReader
            StreamReader fileContent = ;
            // Create an object of Employee class


            // Read the StremReader till the last line
            while (!fileContent.EndOfStream)                                                                                                                                                                                                             
            {
                // At this point there are still employees to be loaded

                // Write code to Read each line and from the StreamReader
                string line =
                // Write code to Load the employee detail from file to respective fields

                // Write code to Add the details to the list collection

            }
            // Write code to Close the StreamReader
            .Close();
        }

        // Method to display the details for all the Employee
        public 
        {
            // prints each employee details in the employees list on a seperate line
            

        }
    //  Write code to Sort the employee details based on the Employee ID
        public 
        {
            employees.
        }
    }
}
