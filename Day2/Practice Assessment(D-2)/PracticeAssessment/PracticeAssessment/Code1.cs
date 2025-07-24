using System;

class Student
{
    // Define properties
    public string Name;
    public int Age;
    public string Grade;

    // Define constructor
    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}

internal class Code1
{
    static void Main(string[] args)
    {
        // Prompt the user to enter student details
        Console.WriteLine("Enter student's name:");
        string Name = Console.ReadLine();

        Console.WriteLine("Enter student's age:");
        int Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student's grade:");
        string Grade = Console.ReadLine();

        // Create an instance of the Student class
        Student stud = new Student(Name, Age, Grade);

        // Print student details
        Console.WriteLine("Student Name: " + stud.Name);
        Console.WriteLine("Student Age: " + stud.Age);
        Console.WriteLine("Student Grade: " + stud.Grade);
    }
}