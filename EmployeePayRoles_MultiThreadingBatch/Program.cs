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
            employee.Add(new Employee(2, "Mayur", 42535352, "Male"));
            employee.Add(new Employee(3, "Vaibhav", 30535352, "Male"));
            employee.Add(new Employee(4, "Raju", 5000052, "Male"));
            employee.Add(new Employee(5, "Snehu", 199999, "Female"));
            Console.WriteLine("Employee pay role program running using multi threading ");
            Console.WriteLine("Hint 1.Display data without thread 2.DisplayData with thread 3. Add data without threa 4.Add data with Thread" +
                "\n 5.Synchronous Add Method Thread \n 6.Update Method Thrad");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    ////Uc1 Without Thread
                    DateTime starttime = DateTime.Now;
                    employeeOperation.addEmployeeToPayRole(employee);
                    DateTime endtime = DateTime.Now;
                    Console.WriteLine("Duration without threading is "+(endtime-starttime));
                    break;
                case 2:
                    ////Uc 2 with thread
                    DateTime starttimeThread = DateTime.Now;
                    employeeOperation.addEmployeeToPayRole_WithThread(employee);
                    DateTime endtimeThread = DateTime.Now;
                    Console.WriteLine("Duration with threading is "+(endtimeThread-starttimeThread));
                    break;
                case 3:
                    ////Uc3 Without Thread
                    DateTime starttimeADD = DateTime.Now;
                    employeeOperation.SingleAddEmployee(employee);
                    DateTime endtimeADD = DateTime.Now;
                    Console.WriteLine("Duration without threading is "+(endtimeADD-starttimeADD));
                    break;
                case 4:
                    Console.WriteLine("Enter data for Threading");
                    //// Uc 3 with thread
                    DateTime starttimeThreadADD = DateTime.Now;
                    employeeOperation.SingleAddEmployee_WithThread(employee);
                    DateTime endtimeThreadADD = DateTime.Now;
                    Console.WriteLine("Duration with threading is "+(endtimeThreadADD-starttimeThreadADD));
                    break;
                case 5:
                    //// Synchronous Add Method Thread
                    Console.WriteLine(" Processing data Wait......");
                    int countNumData = employeeOperation.AddEmployee_Synchronous(employee);
                    Console.WriteLine(" total data in the list of employee "+countNumData);
                    break;
                case 6:
                    DateTime starttimeThreadUpdate = DateTime.Now;
                    employeeOperation.UpdateEmployee_WithThread(employee);
                    DateTime endtimeThreadUpdate = DateTime.Now;
                    Console.WriteLine("Duration with threading is "+(endtimeThreadUpdate-starttimeThreadUpdate));
                    break;
            }
        }
    }
}
