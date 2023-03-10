using System;
using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
using ConsoleApp1.models;

namespace AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
public class Dragon : Animal, IPilotage, IFly // classe dérivée de Animal
{
    public Dragon()
    {

    }

    public Dragon(string name, string type, int id, int age) 
    {
        this.Name = name;
        this.Type = Type;
        this.Id = id;
        this.Age = age;
    }


    public override void Move()
    {
        Console.WriteLine(Name + " craches du feu en volant");
    }

    public new void Sleep()
    {
        Console.WriteLine(Name + "rrrrrr piche");
    }

    public void Fly()
    {
        Console.WriteLine(Name + "part en volant!");
    }
}