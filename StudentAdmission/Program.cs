using System;

namespace prac1
{
    class Student
    {
        // Public fields
        public int admissionNumber;
        public string studentName;
        public string course;
        public int semester;
        // Private fields
        private double fees;
        private bool isScholarshipEligible = false;
        private const double concession = 0.10; 
        // Constructor with default values
        public Student()
        {
            admissionNumber = 100;
            studentName = "Default";
            course = "Computer Engineering";
            semester = 1;
            fees = 60000;
        }
        public void AcceptDetails()
        {
            Console.Write("Enter Admission Number: ");
            admissionNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();
            Console.Write("Enter Course Chosen: ");
            course = Console.ReadLine();
            Console.Write("Enter Semester: ");
            semester = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fees: ");
            fees = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n--- Student Details Saved ---");
            Console.WriteLine("Name: " + studentName);
        }
        public void CheckEligibility()
        {
            if (fees <= 50000)
            {
                isScholarshipEligible = true;
            }

            Console.WriteLine("Scholarship Eligible: " + isScholarshipEligible);
        }
        public void CalculateFinalFees()
        {
            if (isScholarshipEligible)
            {
                fees = fees - (fees * concession);
            }

            Console.WriteLine("Final Payable Fees: " + fees);
        }
        public static void Main(string[] args)
        {
            Student myStudent = new Student();
            
            myStudent.AcceptDetails();
            myStudent.CheckEligibility();
            myStudent.CalculateFinalFees();
        }
    }
}