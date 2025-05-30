using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Person
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public string address;
        public string className;

        public string teacherName;

        public string major;

        public int yearAge;

        public double gpa;


        public Person(string firstName, string lastName, string address, string className, string teacherName, string major, int yearAge, double gpa)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.className = className;
            this.teacherName = teacherName;
            this.major = major;
            this.yearAge = yearAge;
            this.gpa = gpa;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ClassName { get; set; }
        public string TeacherName { get; set; }
        public string Major { get; set; }
        public int YearAge { get; set; }
        public double Gpa { get; set; }


        public string StudentRanking(double gpa)
        {
            if (gpa >= 3.5 && gpa <= 4.0)
                return "EXCELLENT";
            else if (gpa >= 3.0)
                return "GOOD";
            else if (gpa >= 2.0)
                return "AVERAGE";
            else if (gpa >= 1.0)
                return "LOW";
            else
                return "FAIL";
        }
        public int calcAge(int year)
        {
            return 2025 - yearAge;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Họ và tên: {firstName} {lastName}");
            Console.WriteLine($"Địa chỉ: {address ?? "Không có"}");
            Console.WriteLine($"Lớp: {className}");
            Console.WriteLine($"Giáo viên: {teacherName}");
            Console.WriteLine($"Chuyên ngành: {major}");
            Console.WriteLine($"Tuổi: {calcAge(yearAge)}");
            Console.WriteLine($"GPA: {gpa}");
            Console.WriteLine($"Xếp hạng: {StudentRanking(gpa)}");
        }

    }
}