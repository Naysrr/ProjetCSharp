using System;
using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
namespace AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
public class Griffin : Animal, IPilotage // classe dérivée de Animal
{
    public Griffin()
    {
        this.Name = "Griffin";
    }

    public Griffin(string name) 
    {
        this.Name=name;
    }

    public override void Move()
    {
        Console.WriteLine(Name + "en elytra");
    }
}
