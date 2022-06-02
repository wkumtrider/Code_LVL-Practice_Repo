using System;

public class Employee
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
    public string FullName { get; set; }
    public string Title { get; set; }
    public DateTime StartDate { get; set; }
    private float Salary { get; set; }
    public int Age { get; set; }

    

    public Employee(string FirstName, string LastName, string Title, DateTime StartDate, int Salary, int Age)
	{
		this.FirstName = FirstName;
		this.LastName = LastName;
		this.FullName = $"{this.FirstName} {this.LastName}";
		this.Title = Title;
		this.StartDate = StartDate;
		this.Salary = Salary;
        this.Age = Age;
    }
    public void ShowName()
    {
        Console.WriteLine($"{this.FullName} and I started on {this.StartDate}");
    }

    public void DoWork()
    {
       Console.WriteLine("I am working");
    }
        
    public void ShowTitle()
    {
       Console.WriteLine($"My title is {this.Salary}");
    }
    public void ShowPay()
    {
       Console.WriteLine($"My pay is { this.Salary}");
    }
    

}
