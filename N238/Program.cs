using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static string filePath = @"..\..\..\people.json";

    static void Main()
    {
        var people = LoadPeople();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1: Add person");
            Console.WriteLine("2: Show person");
            Console.WriteLine("3: Exit");
            Console.Write("Select an option (1-3): ");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter person's name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age = int.Parse(Console.ReadLine());

                    people.Add(new Person { Name = name, Age = age });
                    SavePeople(people);
                    Console.WriteLine("Person added.");
                    break;
                case "2":
                    if (people.Count == 0)
                    {
                        Console.WriteLine("No persons to show.");
                    }
                    else
                    {
                        Console.WriteLine("Persons:");
                        for (int i = 0; i < people.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}: {people[i].Name} Age: {people[i].Age}");
                        }
                    }
                    break;
                case "3":
                    exit = true;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select 1, 2, or 3.");
                    break;
            }
        }
    }

    static List<Person> LoadPeople()
    {
        if (!File.Exists(filePath))
            return new List<Person>();

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Person>>(json) ?? new List<Person>();
    }

    static void SavePeople(List<Person> people)
    {
        string json = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }
}
