using System;
using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
namespace AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
public class Griffin : Animal, IPilotage, IFly // classe dérivée de Animal
{
    public Griffin()
    {
        this.Name = "Griffin";
        this.Type = "Rare";
        this.Id = 2;
    }

    public Griffin(string name, string type, int id, int age) 
    {
        this.Name=name;
        this.Type=type;
        this.Id = id;
        this.Age=age;
    }

    public override void Move()
    {
        Console.WriteLine(Name + "en elytra");
    }

    public void Fly()
    {
        Console.WriteLine(Name + " vole !");
    }
}
