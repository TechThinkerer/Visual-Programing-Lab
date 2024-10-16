using System;

public enum Department
{
    Science,
    Arts,
    Commerce,
    Engineering,
    Medicine
}

public class Person
{
    private string name;

    public Person() { name = null; }

    public Person(string name) { this.name = name; }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

public class Student : Person
{
    private string regNo;
    private int age;
    private Department program;

    public Student() : base() { regNo = null; age = 0; program = default(Department); }

    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }

    public string RegNo
    {
        get { return regNo; }
        set { regNo = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Department Program
    {
        get { return program; }
        set { program = value; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Ali";
        student1.RegNo = "S167";
        student1.Age = 22;
        student1.Program = Department.Engineering;

        Student student2 = new Student("Ayesha", "S456", 22, Department.Science);

        Console.WriteLine("Student 1:");
        PrintStudentDetails(student1);

        Console.WriteLine("\nStudent 2:");
        PrintStudentDetails(student2);
    }

    public static void PrintStudentDetails(Student student)
    {
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Registration Number: {student.RegNo}");
        Console.WriteLine($"Age: {student.Age}");
        Console.WriteLine($"Program: {student.Program}");
    }
}