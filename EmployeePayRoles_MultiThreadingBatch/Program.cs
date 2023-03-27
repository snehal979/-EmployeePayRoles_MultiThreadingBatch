namespace EmployeePayRoles_MultiThreadingBatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Employee pay role program running using multi threading ");
            EmployeeOperation employeeOperation = new EmployeeOperation();
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee(1, "Snehal", 40000000, "Female"));
            employee.Add(new Employee(1, "Mayur", 42535352, "Male"));
            employee.Add(new Employee(1, "Vaibhav", 30535352, "Male"));
            employee.Add(new Employee(1, "Raju", 5000052, "Male"));
            employee.Add(new Employee(1, "Snehu", 199999, "Female"));

            ////Uc1 Without Thread
            DateTime starttime = DateTime.Now;
            employeeOperation.addEmployeeToPayRole(employee);
            DateTime endtime = DateTime.Now;
            Console.WriteLine("Duration without threading is "+(endtime-starttime));
            ////Uc 2 with thread
            DateTime starttimeThread = DateTime.Now;
            employeeOperation.addEmployeeToPayRole_WithThread(employee);
            DateTime endtimeThread = DateTime.Now;
            Console.WriteLine("Duration with threading is "+(endtimeThread-starttimeThread));
        }
    }
}
