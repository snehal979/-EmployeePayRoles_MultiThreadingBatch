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
    }
}
