
using System;

public class Student
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; set; }


    public Student(int id, string name, int age, double gpa)
    {
        Id = id;
        Name = name;
        Age = age;
        GPA = gpa;
    }


    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Tên: {Name}, Tuổi: {Age}, GPA: {GPA:F2}");
    }
}
