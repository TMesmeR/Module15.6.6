﻿var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
var allStudents = GetAllStudents(classes);

Console.WriteLine(string.Join(" ", allStudents));


static string[] GetAllStudents(Classroom[] classes)
{
    return classes.SelectMany(c => c.Students).ToArray();
}

public class Classroom
{
    public List<string> Students = new List<string>();
}