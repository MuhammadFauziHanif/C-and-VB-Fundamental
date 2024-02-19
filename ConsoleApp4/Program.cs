// See https://aka.ms/new-console-template for more information
using SampleCSharp;

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// use Student.cs

Student student = new Student();
Console.WriteLine(student.getFullName());
Console.WriteLine(student.getFullName("Erick", "Thohir"));