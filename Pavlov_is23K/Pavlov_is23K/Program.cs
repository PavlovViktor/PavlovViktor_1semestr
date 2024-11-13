using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<int> Grades { get; set; }

    public double AverageGrade => Grades.Average();
}
public class Program
{
    static void Main(string[] args)
    {
        List<Person> people = DeserializePeople("C:\\Users\\Student29\\Desktop\\people.xml");


        Console.WriteLine("Введите команду:\n 1-показать самого лучшего ученика,\n 2-показать самого худшего ученика,\n 3-показать весь список,\n 4-показать учеников со средним баллом больше...");
        string command = Console.ReadLine();

        switch (command)
        {
            case "1":
                ShowBestStudent(people);
                break;
            case "2":
                ShowWorstStudent(people);
                break;
            case "3":
                ShowAllStudents(people);
                break;
            case "4":
                Console.WriteLine("Введите средний балл: ");
                if (double.TryParse(Console.ReadLine(), out double averageThreshold))
                {
                    ShowStudentsAboveAverage(people, averageThreshold);
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
                break;
            default:
                Console.WriteLine("Неизвестная команда.");
                break;
        }

        Console.ReadKey();
    }

    static List<Person> DeserializePeople(string fileName)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
        using (FileStream stream = new FileStream(fileName, FileMode.Open))
        {
            return (List<Person>)serializer.Deserialize(stream);
        }
    }

    static void ShowBestStudent(List<Person> people)
    {
        Person bestStudent = people.OrderByDescending(p => p.AverageGrade).First();
        Console.WriteLine($"Самый лучший ученик: {bestStudent.FirstName} {bestStudent.LastName}, средний балл: {bestStudent.AverageGrade}");
    }

    static void ShowWorstStudent(List<Person> people)
    {
        Person worstStudent = people.OrderBy(p => p.AverageGrade).First();
        Console.WriteLine($"Самый худший ученик: {worstStudent.FirstName} {worstStudent.LastName}, средний балл: {worstStudent.AverageGrade}");
    }

    static void ShowAllStudents(List<Person> people)
    {
        foreach (Person person in people)
        {
            Console.WriteLine($"Имя: {person.FirstName} {person.LastName}, Средний балл: {person.AverageGrade}");
        }
    }

    static void ShowStudentsAboveAverage(List<Person> people, double averageThreshold)
    {
        foreach (Person person in people.Where(p => p.AverageGrade > averageThreshold))
        {
            Console.WriteLine($"Имя: {person.FirstName} {person.LastName}, Средний балл: {person.AverageGrade}");
        }
    }
}