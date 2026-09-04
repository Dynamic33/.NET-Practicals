using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace prac3 {
  public class Expense {
    public int ExpenseId;
    public string Category;
    public double Amount;
    public string PaymentMode;
    public string ExpenseDate;

    public Expense() {
      Console.WriteLine("========================");
      Console.WriteLine("Expense Tracking Module!!!");
      Console.WriteLine("========================");
    }

    public void AddExpense() {
      try {
        Console.WriteLine("Enter Expense Id:- ");
        ExpenseId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Expense Category:- ");
        Category = Console.ReadLine();
        Console.WriteLine("Enter Expense Amount:- ");
        Amount = Convert.ToDouble(Console.ReadLine());
        if (Amount <= 0) {
          throw new Exception("Invalid Amount!!!");
        }
        Console.WriteLine("Enter Expense Payment Mode (UPI/CASH):- ");
        PaymentMode = Console.ReadLine();
        Console.WriteLine("Enter Expense Date:- ");
        ExpenseDate = Console.ReadLine();
      } catch (Exception e) {
        Console.WriteLine(e.Message);
        Console.WriteLine("Bad Convert, ToInt32/ToDouble or Invalid Amount");
      }
    }

    public void DisplayExpense() {
      Console.WriteLine();
      Console.WriteLine("Expense Id:- " + ExpenseId);
      Console.WriteLine("Expense Category:- " + Category);
      Console.WriteLine("Expense Amount:- " + Amount);
      Console.WriteLine("Payment Mode:- " + PaymentMode);
      Console.WriteLine("Expense Date:- " + ExpenseDate);
      Console.WriteLine();
    }
  }

  public class Program {
    public static void Main(string[] args) {
      List<Expense> ExpenseList = new List<Expense>();
      int choice = 0;
      while (true) {
        Console.WriteLine();
        Console.WriteLine("Enter your Choice: ");
        Console.WriteLine("1. Add Expense");
        Console.WriteLine("2. View All Expense");
        Console.WriteLine("3. View Total Expense");
        Console.WriteLine("4. Exit");
        choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1) {
          Expense exp = new Expense();
          exp.AddExpense();
          ExpenseList.Add(exp);
        } else if (choice == 2) {
          foreach (Expense exp in ExpenseList) {
            exp.DisplayExpense();
          }
        } else if (choice == 3) {
          double sum = 0;
          foreach (Expense exp in ExpenseList) {
            sum = sum + exp.Amount;
          }
          Console.WriteLine();
          Console.WriteLine("Total Expense:- " + sum);
          Console.WriteLine();
        } else if (choice == 4) {
          return;
        } else {
          Console.WriteLine("Invalid Choice!!!");
        }
      }
    }
  }
}