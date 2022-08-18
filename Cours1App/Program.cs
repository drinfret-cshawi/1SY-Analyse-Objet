// See https://aka.ms/new-console-template for more information

using Cours1Lib;

Console.WriteLine("Hello, World!");
Person p1 = new Person(1, "Denis");
Console.WriteLine(p1);
Student s1 = new Student(2, "Roland", 123);
Console.WriteLine(s1);

List<Person> persons = new List<Person>();
persons.Add(p1);
persons.Add(s1);

foreach (Person person in persons)
{
    Console.WriteLine(person);
}