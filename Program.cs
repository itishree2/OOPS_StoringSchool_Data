using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPS_StoringSchoolDt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------RAINBOW SCHOOL DATA-------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("--------STUDENTS---------");

            // student
            Console.WriteLine("Enter the number of students:");
            int num = int.Parse(Console.ReadLine());
            Student[] students = new Student[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter student name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter class:");
                int cls = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter section:");
                char sec = char.Parse(Console.ReadLine());

                students[i] = new Student(name, cls, sec);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("============================");

            // teachers
            Console.WriteLine("--------TEACHERS---------");
            Console.WriteLine("Enter the number of teachers:");
            int n1 = int.Parse(Console.ReadLine());
            Teacher[] teachers = new Teacher[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Enter teacher name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter subject name:");
                string subject = Console.ReadLine();

                Console.WriteLine("Enter class:");
                string teacherClass = Console.ReadLine();

                Console.WriteLine("Enter section:");
                string teacherSection = Console.ReadLine();

                teachers[i] = new Teacher(name, subject, teacherClass, teacherSection);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("===============================");

            // subjects
            Console.WriteLine("--------SUBJECTS---------");
            Console.WriteLine("Enter the number of subjects:");
            int n2 = int.Parse(Console.ReadLine());
            Subject[] sub = new Subject[n2];

            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine("Enter subject name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter subject code:");
                string code = Console.ReadLine();

                sub[i] = new Subject(name, code);

                Console.WriteLine("---------------");
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("----------PRINTING DETAILS OF STUDENTS------------------------");

            foreach (var item in students)
            {
                Console.WriteLine($"Name    : {item.Name}");
                Console.WriteLine($"Class   : {item.Class}");
                Console.WriteLine($"Section : {item.Section}");
                Console.WriteLine("---------------");
            }

            Console.WriteLine("----------PRINTING DETAILS OF TEACHERS------------------------");

            foreach (var item in teachers)
            {
                Console.WriteLine($"Name           : {item.Name}");
                Console.WriteLine($"Subject        : {item.Subject}");
                Console.WriteLine($"Class          : {item.TeacherClass}");
                Console.WriteLine($"Section        : {item.Section}");
                Console.WriteLine("---------------");
            }

            Console.WriteLine("----------PRINTING DETAILS OF SUBJECTS------------------------");

            foreach (var item in sub)
            {
                Console.WriteLine($"Name           : {item.Name}");
                Console.WriteLine($"Subject Code   : {item.SubCode}");
                Console.WriteLine("---------------");
            }
        }
    }
}


