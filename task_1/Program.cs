using System;
using System.Collections.Generic;
using System.Linq;
using task_1;


class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Вова", Grade = 90 },
            new Student { Name = "Ксюша", Grade = 70 },
            new Student { Name = "Олександр", Grade = 85 },
            new Student { Name = "Олена", Grade = 92 },
            new Student { Name = "Олег", Grade = 87 },
            new Student { Name = "Микита", Grade = 95 },
            new Student { Name = "Данило", Grade = 69 },
             new Student { Name = "Марина", Grade = 94 }
        };


        var highGrades = students.Where(student => student.Grade >= 90);


        foreach (var student in highGrades)
        {
            Console.WriteLine(student.Name);
        }
    }
}
