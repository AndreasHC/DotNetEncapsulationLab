﻿using DotNetEncapsulationLab;

var lines = int.Parse(Console.ReadLine());
var persons = new List<Person>();
for (int i = 0; i < lines; i++)
{
    try
    {
        var cmdArgs = Console.ReadLine().Split().ToList();
        // Because the "example input" contains a double space
        cmdArgs.RemoveAll(string.IsNullOrEmpty);
        var person = new Person(cmdArgs[0],
                                cmdArgs[1],
                                int.Parse(cmdArgs[2]),
                                decimal.Parse(cmdArgs[3]));

        persons.Add(person);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
var bonus = decimal.Parse(Console.ReadLine());
persons.ForEach(p => p.IncreaseSalary(bonus));
persons.ForEach(p => Console.WriteLine(p.ToString()));
