// Program.cs
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
  
        List<Student> students = new List<Student>();

    
        students.Add(new Student(1, "Nguyễn Văn A", 20, 8.5));
        students.Add(new Student(2, "Trần Thị B", 22, 7.2));
        students.Add(new Student(3, "Lê Quang C", 21, 9.0));
        students.Add(new Student(4, "Phạm Minh D", 23, 6.8));

        
        Console.WriteLine("Danh sách sinh viên:");
        foreach (var student in students)
        {
            student.Display();
        }
    }
}
