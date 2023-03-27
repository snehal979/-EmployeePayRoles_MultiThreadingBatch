using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoles_MultiThreadingBatch
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
        public string Gender { get; set; }
        public Employee(int id, string name, long salary, string gender)
        {
            Id=id;
            Name=name;
            Salary=salary;
            Gender=gender;
        }
    }
}
