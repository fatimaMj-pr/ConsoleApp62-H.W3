using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    public class Student

    {

        public string id;

        public string name;

        public double mark;

}
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Enter the number of students (5-10): ");

            int numStudents= int.Parse(Console.ReadLine());

            for (int i = 0; i < numStudents; i++)
            { Console.WriteLine($"\nStudent {1 + 1}:");
                Console.Write("Enter ID: ");

                string id =Console.ReadLine();

                Console.Write("Enter name: ");

                string name= Console.ReadLine();

                Console.Write("Enter mark: ");

                double mark =double.Parse(Console.ReadLine()); students.Add(new Student { id=id, name=name, mark =mark});
            }
            Console.WriteLine("\nStudents who passed: ");

            foreach (Student student in students)

            { if (student.mark >= 50)
                { 
                    
                    Console.WriteLine(student.name); 
                }
                    
            }
            Console.ReadKey();

        }
    }
}
