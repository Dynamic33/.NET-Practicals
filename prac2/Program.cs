using System;

namespace prac2 {
  public class Employee {
    public int EmployeeId;
    public string EmployeeName;
    public double EmployeeSalary;

    public Employee() {
      Console.WriteLine("-----------------------------");
      Console.WriteLine("Employee Payroll System!!!");
      Console.WriteLine("-----------------------------");
    }

    public void AcceptDetails() {
      Console.WriteLine("Enter Employee ID: ");
      EmployeeId = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter Employee Name: ");
      EmployeeName = Console.ReadLine();
      Console.WriteLine("Enter Employee Basic Salary: ");
      EmployeeSalary = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayDetails() {
      Console.WriteLine("Employee ID: " + EmployeeId);
      Console.WriteLine("Employee Name: " + EmployeeName);
    }

    public virtual void CalculateSalary() {
      Console.WriteLine("Salary Calculated Successfully!");
    }
  }

  public class FullTimeEmployee : Employee {
    public override void CalculateSalary() {
      double HRA = EmployeeSalary * 0.20;
      double DA = EmployeeSalary * 0.10;
      double NetSalary = EmployeeSalary + HRA + DA;
      Console.WriteLine("Employee Type: Full-Time");
      Console.WriteLine("Empoyee Net Salary is: " + NetSalary);
    }
  }

  public class PartTimeEmployee : Employee {
    public override void CalculateSalary() {
      double NetSalary = EmployeeSalary;
      Console.WriteLine("Employee Type: Part-Time");
      Console.WriteLine("Empoyee Net Salary is: " + NetSalary);
    }
  }

  public class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Enter your choice:-");
      Console.WriteLine("1.Part-Time Employee");
      Console.WriteLine("2.Full-Time Employee");

      int choice = Convert.ToInt32(Console.ReadLine());
      Employee emp = null;
      if (choice == 1) {
        emp = new PartTimeEmployee();
      } else if (choice == 2) {
        emp = new FullTimeEmployee();
      } else {
        Console.WriteLine("Incorrect Choice!");
      }

      emp.AcceptDetails();
      emp.DisplayDetails();
      emp.CalculateSalary();
    }
  }
}