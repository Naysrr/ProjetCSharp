using System;
using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
namespace AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
public class Vehicule : IPilotage // hérite de l'interface only
{
    public string Name { get; set; }

    public Vehicule()
    {
        this.Name = "Dominus";
    }

    public void Move()
    {
        Console.WriteLine(Name + "en train de flip reset");
    }
}
