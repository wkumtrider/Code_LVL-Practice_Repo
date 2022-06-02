
class Program
{ 
      
        static void Main(string[] args) 
        {

        try
        {
            Console.WriteLine("Enter in a number.");
            var t = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine($"An exception was thrown");
        }

        Employee employee1 = new Employee("Jason", "McCarty", "EHS Manager", DateTime.Now, 15, 30);
        Employee employee2 = new Employee("Jeremie", "McCarty", "Manager", Convert.ToDateTime("8/20/19"), 45, 30);

           List<Employee> employeeList = new List<Employee>();
           employeeList.Add(employee1);
           employeeList.Add(employee2);

            foreach(Employee tempEmployeeObj in employeeList)
            {
                tempEmployeeObj.ShowName();
                tempEmployeeObj.ShowPay();
                tempEmployeeObj.ShowTitle();
            }
   
    }

        
        
        
        
        
        
}

