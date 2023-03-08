using System;
using System.Net;
using System.Xml.Linq;
using System;
using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
namespace AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
public abstract class Animal : IPilotage //ne peut pas être instancié directement
{
    public string Name { get;  set; }

    public Animal()
    {
        this.Name = "triceratops";
    }

    public Animal(string name)
    {
        this.Name = name; // permet de spécifier le nom de l'animal lors de sa créa
    }

    public abstract void Move(); // doit être implémenter par les classes dérivées

    public new void Sleep()
    {
        Console.WriteLine(Name + " rompiche");
    }
}
