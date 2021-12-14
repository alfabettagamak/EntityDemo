// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using EntityDemo;
using EntityDemo.models;
using Npgsql;

// ADO.net
string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=demo";

using (var connection = new NpgsqlConnection(connectionString))
{
    connection.Open();
    string sql = "select * from superheroes where id < 100";
    
    var cmd = new NpgsqlCommand(sql, connection);
    var result = cmd.ExecuteReader();
    
    List<string> list = new List<string>();
    while (result.Read())
    {
        list.Add((string) result["name"]);
    }

    Console.WriteLine(string.Join(", ", list));
}


/*
// EntityFramework 
using (DemoContextDb demoContextDb = new DemoContextDb())
{
    var person = demoContextDb.Persons.First(a => a.Id == 1);

    person.MiddleName = "Игнатьвич";
    demoContextDb.SaveChanges();


    /*List<Animal> listAnimal = demoContextDb.Animals.ToList();
    List<int> id = demoContextDb.Cars.Select(c => c.Id).ToList();
    List<string> animalsName = new List<string>();
    foreach (var animal in listAnimal)
    {
        animalsName.Add(animal.Name);
    }

    Console.WriteLine(string.Join(", ", animalsName));#1#
    /*Person person = new Person() { FirstName = "Petr", SecondName = "Petrov", MiddleName = "Petrovich"};
    Person person1 = new Person() {  FirstName = "Петр", SecondName = "Петров", MiddleName = "Петрович"};

    Animal animal = new Animal() { Name = "Федор", Type = "кот", Person = person};
    Animal animal1 = new Animal() { Name = "Барсик", Type = "пес", Person = person};
    Animal animal2 = new Animal() { Name = "Федор", Type = "кот", Person = person1};

    Car car = new Car() {Model = "bmw", Year = "2012", Person = person};
    
    demoContextDb.Persons.AddRange(person);
    demoContextDb.Persons.AddRange(person1);
    demoContextDb.Animals.AddRange(animal);
    demoContextDb.Animals.AddRange(animal1);
    demoContextDb.Animals.AddRange(animal2);
    demoContextDb.Cars.AddRange(car);
    demoContextDb.SaveChanges();#1#
}
*/

Console.WriteLine("Hello, World!");