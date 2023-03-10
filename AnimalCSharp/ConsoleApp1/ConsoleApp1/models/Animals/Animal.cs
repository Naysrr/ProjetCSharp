using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models.Animals;
public abstract class Animal : IPilotage //ne peut pas être instancié directement
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Id { get; set; }
    public int Age { get; set; }

    public Animal()
    {
        this.Name = "triceratops";
        this.Type = "commun";
        this.Id = 1;
        this.Age = 1;
    }

    public Animal(string name, string type, int id, int age)
    {
        this.Name = name; // permet de spécifier le nom de l'animal lors de sa créa + type
        this.Type = type;
        this.Id = id;
        this.Age = age;
    }

    public abstract void Move(); // doit être implémenter par les classes dérivées

    public new void Sleep()
    {
        Console.WriteLine(Name + " rompiche");
    }
    // vend clio me mp au 0652417894 <3
}