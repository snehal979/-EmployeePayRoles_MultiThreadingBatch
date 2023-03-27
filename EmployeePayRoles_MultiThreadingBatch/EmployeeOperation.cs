using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoles_MultiThreadingBatch
{
    public class EmployeeOperation
    {
        List<Employee> employeelist = new List<Employee>();
        /// <summary>
        /// Uc1 Without Use of Thread
        /// </summary>
        public void addEmployeeToPayRole(List<Employee> employee)
        {
            foreach (var emp in employee)
            {
                Console.WriteLine(" Employee being added "+emp.Name);
                this.addEmployeeToPayRole(emp);
                Console.WriteLine("Employee added "+emp.Name);
            }
        }
        public void addEmployeeToPayRole(Employee emp)
        {
            employeelist.Add(emp);
        }
        /// <summary>
        /// Uc 2 With Thread
        /// </summary>
        /// <param name="employeeList"></param>
        public void addEmployeeToPayRole_WithThread(List<Employee> employee)
        {
            foreach (var emp in employee)
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine(" Employee being added "+emp.Name);
                    this.addEmployeeToPayRole(emp);
                    Console.WriteLine("Employee added "+emp.Name);
                });
                thread.Start();
            }
        }
        /// <summary>
        /// UC3 added data for single Employee Without Threading
        /// </summary>
        /// <param name="employeeList"></param>
        public void SingleAddEmployee(List<Employee> employeeList)
        {
            Console.WriteLine("Enter the Id");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the firstName");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            long Salary = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Gender");
            String Gendr = Console.ReadLine();

            Employee employeecs = new Employee(Id, Name, Salary, Gendr);
            Console.WriteLine(" Employee being added "+Name);
            Console.WriteLine("id being added"+Id);
            Console.WriteLine("Salary being added"+Salary);
            Console.WriteLine("Gender being added"+Gendr);
            employeeList.Add(employeecs);
            Console.WriteLine("Employee added "+Name);
            Console.WriteLine("id added"+Id);
            Console.WriteLine("Salary added"+Salary);
            Console.WriteLine("Gender added"+Gendr);
        }
        /// <summary>
        /// UC3 added data for single Employee Without Threading
        /// </summary>
        /// <param name="employeeList"></param>
        public void SingleAddEmployee_WithThread(List<Employee> employeeList)
        {
            Console.WriteLine("Enter the Id");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the firstName");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            long Salary = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Gender");
            String Gendr = Console.ReadLine();
            // Task is Use for parallel
            Task task = new Task(() =>
            {
                Employee employeecs = new Employee(Id, Name, Salary, Gendr);
                Console.WriteLine(" Employee being added "+Name);
                Console.WriteLine("id being added"+Id);
                Console.WriteLine("Salary being added"+Salary);
                Console.WriteLine("Gender being added"+Gendr);
                employeeList.Add(employeecs);
                Console.WriteLine("Employee added "+Name);
                Console.WriteLine("id added"+Id);
                Console.WriteLine("Salary added"+Salary);
                Console.WriteLine("Gender added"+Gendr);
            });
        }
        /// <summary>
        /// uc4 Synchronous Add Method Thread
        /// </summary>
        /// <param name="employeeList"></param>
        //synchronous = task performed one at a time and when is complet the followig is unblocked.wait for the move next one.
        public int AddEmployee_Synchronous(List<Employee> employeeList)
        {
            int countNum = 0;
            foreach (var emp in employeeList)
            {
                countNum = employeeList.Count();
                // Make program Wait for Look Busy For 5 sec
                Thread.Sleep(5000);
            }
            return countNum;
        }
        /// <summary>
        /// UC6 Update data for single Employee Without Threading
        /// </summary>
        /// <param name="employeeList"></param>
        public void UpdateEmployee_WithThread(List<Employee> employeeList)
        {
            Console.WriteLine("Enter the name Want Update");
            Console.WriteLine("Enter the Id");
            int editId = Convert.ToInt32(Console.ReadLine());
            
            //check the name is present or not
            foreach (var data in employeeList)
            {
                if (editId.Equals(data.Id))
                {
                    Console.WriteLine("Salary being added"+data.Salary);
                    Console.WriteLine("Enter the Salary");
                    data.Salary = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Salary added"+data.Salary);
                }
            }
        }
    }
}