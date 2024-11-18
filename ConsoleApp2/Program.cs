using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Long", Age = 16 },
                new Student { Id = 2, Name = "Teo", Age = 17 },
                new Student { Id = 3, Name = "Bao", Age = 14 },
                new Student { Id = 4, Name = "Thang", Age = 18 },
                new Student { Id = 5, Name = "Dang", Age = 19 }
            };

            Console.WriteLine("Danh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            var studentsAged15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            Console.WriteLine("\nDanh sach hoc sinh co tuoi tu 15 đen 18:");
            foreach (var student in studentsAged15To18)
            {
                Console.WriteLine(student);
            }


            var studentsStartingWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
            Console.WriteLine("\nDanh sach hoc sinh co ten bat đau bang cha 'A':");
            foreach (var student in studentsStartingWithA)
            {
                Console.WriteLine(student);
            }


            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");


            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine($"\nHoc sinh co tuoi lon nhat: {oldestStudent}");


            var sortedStudents = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }

    }
}
