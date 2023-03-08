using System;
using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
namespace AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
public class Dragon : Animal, IPilotage // classe dérivée de Animal
{
    public Dragon()
    {

    }

    public Dragon(string name, string type, int id) 
    {
        this.Name = name;
        this.Type = Type;
        this.Id = id;
    }


    public override void Move()
    {
        Console.WriteLine(Name + " craches du feu en volant");
    }

    public new void Sleep()
    {
        Console.WriteLine(Name + "rrrrrr piche");
    }
}