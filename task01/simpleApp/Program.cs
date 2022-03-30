// See https://aka.ms/new-console-template for more information
using System;

namespace SimpleGPACalc
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string? name;
            int bYear, id;
            int studNum;
            string? flag;
            System.Console.Write("*s* or *Student* to calcualte student gpa\n*e* or *Employee* to calculate employee salary: ");
            flag = System.Console.ReadLine();
            if (flag[0] == 'S' || flag[0] == 's' || flag == "Student" || flag == "student")
            {
                Console.Write("Enter amount of students: ");
                studNum = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("");
                Student[] studs = new Student[studNum];
                for (int i = 0; i < studNum; i++)
                {
                    Console.Write("Enter the ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Enter the name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("");
                    Console.Write("Enter the birth year: ");
                    bYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Student stud = new Student(name, bYear, id);
                    for (int j = 0; j < stud.courseLs.Length; j++)
                    {
                        Console.Write("Enter course grade: ");
                        stud.courseLs[j] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                    }

                    studs[i] = stud;
                }

                for (int i = 0; i < studNum; i++)
                    studs[i].print();
            }
            else if (flag[0] == 'e' || flag[0] == 'S' || flag == "Employee" || flag == "employee")
            {
                int employeeNum, hrs;
                string department;
                System.Console.Write("Enter the amount of employees: ");
                employeeNum = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine();
                Employee[] empployeeArr = new Employee[employeeNum];
                for (int i = 0; i < employeeNum; i++)
                {
                    System.Console.Write("Enter the id for the employee no.{0}: ",i+1);
                    id = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine();
                    System.Console.Write("Enter the name for the employee no.{0}: ",i+1);
                    name = Console.ReadLine();
                    System.Console.WriteLine();
                    System.Console.Write("Enter the work hours for the employee no.{0}: ",i+1);
                    hrs = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine();
                    System.Console.Write("Enter the department for the employee no.{0}: ",i+1);
                    department = Console.ReadLine();
                    System.Console.WriteLine();
                    Employee employee = new Employee(id,name, hrs, department);
                    empployeeArr[i] = employee;
                }
                for (int i = 0; i < employeeNum; i++)
                {
                    System.Console.WriteLine("Employee No.{0}:", i+1);
                    empployeeArr[i].print();
                }
            }

            Console.ReadKey();
        }
    }
    public class Student
    {
        private string name;
        private int bYear, id;
        private double[] courses;
        public Student(string name, int bYear, int id)
        {
            this.name = name;
            this.bYear = bYear;
            this.id = id;
            System.Console.Write("Enter the amount of courses: ");
            int size = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            courses = new double[size];
        }

        public int age
        {
            get
            {
                return DateTime.Now.Year - bYear;
            }
        }

        public double avgGPA()
        {
            double avg = 0;
            for (int i = 0; i < courses.Length; i++)
            {
                avg += courses[i];
            }

            avg /= courseLs.Length;
            return avg;
        }

        public double[] courseLs
        {
            get
            {
                return courses;
            }
        }

        public void print()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nAge: {2}\nAverage GPA: {3}\n", id, name, age, avgGPA());
        }
    }

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
        public async void print()
        {
            System.Console.WriteLine("ID: {0}\n\nName: {1}\n\nWork-Hours: {2}\n\nDepartment: {3}\n\nSalary: {4}", this.id, this.name, this.hrs, this.department,this.salary());
        }
    }
}