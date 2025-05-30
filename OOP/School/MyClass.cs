using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.School
{
    public class MyClass
    {
         private string className;
        private string teacherName;
        private int studentNumber;

        public void MyClassRoom()
        {
            Console.WriteLine($"{className} --- {teacherName} --- {studentNumber}");
        }
    }
}