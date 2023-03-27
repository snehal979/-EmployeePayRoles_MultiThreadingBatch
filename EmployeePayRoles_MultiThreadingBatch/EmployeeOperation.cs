using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoles_MultiThreadingBatch
{
    public class EmployeeOperation
    {
        public List<Employee> employee = new List<Employee>();
        /// <summary>
        /// Uc1 Without Use of Thread
        /// </summary>
        public void addEmployeeToPayRole()
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
            employee.Add(emp);
        }
    }
}
