// See https://aka.ms/new-console-template for more information
using System;
using Learning;
using Learning.OOP;
using Learning.OOP.Animal;
using Learning.OOP.Person;
using Learning.OOP.Car;
using Learning.OOP.Book;
using Learning.OOP.Company;
using Learning.OOP.Vehicle;
using Learning.OOP.People;
using Learning.OOP.Circle;
using Learning.OOP.School;
using Learning.OOP.Dependency.Printer;






namespace Learning;

class HelloWorld
{
    public static void Main(String[] args)
    {

        //? OOP
        Console.WriteLine("-------------- Person -------------");

        //? -> perons1 sẽ có datatype là class Person 
        //? -> person1 sẽ tham chiếu đến 1 Object thuộc class Person
        //? -> "new" được dùng để tạo 1 object mới của class Person trogn 1 bộ nhớ
        //? -> Person() gọi constructor của class Person -> vì trong class Person ko khai báo constructor nên C# sẽ cấp 1 default constructor
        //** Person person1 = new Person();
        //** => Khai báo biến person1 có datatype Person
        //** => Tạo 1 object mới của class Person bằng từ khóa new
        //** => Gán object vừa tạo cho biến person1, để person1 tham chiếu đến object đó
        // Person person1 = new Person();
        // person1.name = "Fong";
        // person1.age = 21;
        // person1.Introduce();

        // Console.WriteLine("-------------- Animal -------------");
        // Animal animal = new Animal("Fong", "Lion", "Male", 100, true);
        // animal.IntroduceAnimal();

        // Console.WriteLine("-------------- Car -------------");

        // Console.WriteLine("Enter Your Car Type! ");

        // Console.Write("Carname: ");
        // string name = Console.ReadLine();


        // Console.Write("Car price: ");
        // double price = Convert.ToDouble(Console.ReadLine());

        // Console.Write("Car quantity: ");
        // int quantity = Convert.ToInt32(Console.ReadLine());

        // Car porsche = new Car(name, price, quantity);

        // porsche.CarIntroduce();

        // Console.WriteLine("-------------- Book -------------");

        // Console.WriteLine("Enter your book: ");

        // if (!int.TryParse(Console.ReadLine(), out int numberOfBooks) || numberOfBooks <= 0)
        // {
        //     throw new ArgumentException("Số lượng sách phải là một số nguyên dương.");
        // }

        // Book[] books = new Book[numberOfBooks];

        // for (int i = 0; i < numberOfBooks; i++)
        // {
        //     Console.WriteLine($"Book[{i}]: ");

        //     Console.Write("Book name: ");

        //     string bookName = Console.ReadLine();

        //     Console.Write("Book Author: ");

        //     string bookAuthor = Console.ReadLine();

        //     Console.Write("Book price: ");

        //     double bookPrice = Convert.ToDouble(Console.ReadLine());

        //     Console.Write("Book quantity: ");

        //     int bookQuantity = Convert.ToInt32(Console.ReadLine());

        //     books[i] = new Book(bookName, bookAuthor, bookPrice, bookQuantity);

        // }

        // Console.WriteLine("List books");
        // for (int i = 0; i < books.Length; i++)
        // {
        //     Console.Write($"Book[{i}]: ");
        //     books[i].BookIntroduce();
        // }

        // Console.WriteLine("-------------- Student -------------");

        // Console.WriteLine("Enter your Student: ");

        // if (!int.TryParse(Console.ReadLine(), out int studentNum) || studentNum <= 0)
        // {
        //     throw new ArgumentException("Số lượng student phải là một số nguyên dương.");
        // }

        // Person[] students = new Person[studentNum];

        // for (int i = 0; i < studentNum; i++)
        // {
        //     Console.Write($"Student[{i}]: ");

        //     Console.WriteLine("Student First Name: ");
        //     string studentFirstName = Console.ReadLine();

        //     Console.WriteLine("Studetn Last Name: ");
        //     string studentLastName = Console.ReadLine();

        //     Console.WriteLine("Student Address: ");
        //     string studentAddress = Console.ReadLine();

        //     Console.WriteLine("Student Class Name: ");
        //     string studentClassName = Console.ReadLine();


        //     Console.WriteLine("Student Teacher Name: ");
        //     string studentTeacherName = Console.ReadLine();

        //     Console.WriteLine("Student Major: ");
        //     string studentMajor = Console.ReadLine();

        //     Console.WriteLine("Student Year Age: ");
        //     int studentYearAge = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine("Student GPA: ");
        //     double studentGPA = Convert.ToDouble(Console.ReadLine());

        //     // Console.WriteLine("Student Ranking: ");
        //     // string studentRanking = Console.ReadLine();

        //     students[i] = new Person(
        //         studentFirstName,
        //         studentLastName,
        //         studentAddress,
        //         studentClassName,
        //         studentTeacherName,
        //         studentMajor,
        //         studentYearAge,
        //         studentGPA);
        // }

        // for (int i = 0; i < students.Length; i++)
        // {
        //     Console.WriteLine($"Student[{i}]: ");
        //     students[i].StudentInfo();
        // }

        // Console.WriteLine("-------------- Company / Employee -------------");

        // Console.Write("Your Company ID: ");
        // int compId = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Your Company Name: ");
        // string compName = Console.ReadLine();

        // Console.Write("Your Company Symbol: ");
        // string compSymbol = Console.ReadLine();

        // Console.Write("Your Company Type: ");
        // string compType = Console.ReadLine();

        // Console.Write("Your company Phone: ");
        // int compPhone = Convert.ToInt32(Console.ReadLine());

        // Company company = new Company(compId, compName, compSymbol, compType, compPhone);

        // Console.WriteLine(company.CompanyIntroduce());

        // Console.Write("Your Employee ID: ");
        // int empId = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Your Employee Name: ");
        // string empName = Console.ReadLine();

        // Console.Write("Your Employee Phone: ");
        // int empPhone = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Your Employee Work: ");
        // string empWork = Console.ReadLine();

        // Console.Write("Your Employee Salary: ");
        // double empSalary = Convert.ToDouble(Console.ReadLine());

        // Employee employee = new Employee(compId, compName, compSymbol, compType, compPhone, empId, empName, empPhone, empWork, empSalary);

        // Console.WriteLine(employee.CompanyIntroduce());

        Console.WriteLine("-------------- Vehicle -------------");
        Vehicle vehicle = new Vehicle("Porsche", 10000);
        vehicle.StartEngine();

        CarV1 carv1 = new CarV1("Bugati", 312313, "Fong");
        carv1.StartEngine();

        CarV2 CarV2 = new CarV2("MayBach", 9319031, "Fong", "NYK");
        CarV2.StartEngine();

        Vehicle upVehicle = carv1;
        upVehicle.StartEngine();
        upVehicle.Car();

        CarV1 upCarV2 = CarV2;
        upCarV2.StartEngine();

        Vehicle moreUpV2 = CarV2;
        moreUpV2.StartEngine();

        Console.WriteLine("-------------- People -------------");

        People people1 = new peopleEmployee("Trung", "HN", 3300);
        People people2 = new peopleCustomer("Linh", "BN", 10400);
        people1.display();
        people2.display();


        Console.WriteLine("-------------- People -------------");
        IShape[] shapes = new IShape[3];
        shapes[0] = new Rectangle(3.4, 5.3);
        shapes[1] = new Circle(5.5);
        shapes[2] = new Rectangle(7.4, 4.3);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Area of shapes[" + i + "]: " + shapes[i].getArea());
            Console.WriteLine("Perimeter of shapes[" + i + "]: " + shapes[i].getPerimeter());
        }

        MyClass myClass = new MyClass();
        myClass.MyClassRoom();

        Printer printer = new Printer("HP Laser");
        EmployeePrinter employeePrint = new EmployeePrinter("An");
        employeePrint.PrintDocument(printer);
    }
}
