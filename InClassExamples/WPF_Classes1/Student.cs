using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Classes1
{
    public class Student
    {
        public int SoonerID{get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public bool isOnProbation {get; set;}
        public double GPA{ get; set; }
        private double BursarBalance { get; set; }

        public Student()
        {
            SoonerID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            isOnProbation = false;
            GPA = 0;
            BursarBalance = 0;

        }
        public Student(int id, string fName, string lName, double bursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            BursarBalance = bursarBalance;
            isOnProbation = false;
            GPA = 0;

        }
        public void MakePayment(double amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must be positive");
                //Console.WriteLine("Amount must be positive");
            }
            BursarBalance -= amount;

        }
        public double CheckBalance()
        {
            return BursarBalance;
        }
        public override string ToString()
        {
            return $"{FirstName}, {LastName} ({SoonerID})";
        }
    }
}
