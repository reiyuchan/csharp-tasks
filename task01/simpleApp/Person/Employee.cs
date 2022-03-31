using System;

namespace simpleApp.Person
{
    public class Employee
    {
        private string name;
        private int id;
        private int hrs;
        private string? department;

        public Employee(int id, string name, int hrs, string department)
        {
            this.id = id;
            this.name = name;
            this.hrs = hrs;
            this.department = department;
        }
        public double salary()
        {
            double payPerHr = 50;
            double result = 0;
            double yearly = this.hrs;
            yearly *= 365.25;
            for (int i = 0; i < yearly; i++)
            {
                result += payPerHr;
                if (this.hrs > 8)
                    result += (payPerHr * 1.5);
            }

            return result;
        }
        public void print()
        {
            System.Console.WriteLine("ID: {0}\n\nName: {1}\n\nWork-Hours: {2}\n\nDepartment: {3}\n\nSalary: {4}", this.id, this.name, this.hrs, this.department, this.salary());
        }
    }
}