using System;

namespace simpleApp.Person
{
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
            int size = Convert.ToInt32(Console.ReadLine());
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
}