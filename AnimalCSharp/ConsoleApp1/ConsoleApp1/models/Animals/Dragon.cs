using System;
using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
namespace AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
public class Dragon : Animal, IPilotage // classe dérivée de Animal
{
    public Dragon()
    {
        this.Name = "Dragon";
        this.Type = "legendary";
    }

    public Dragon(string name, string type) 
    {
        this.Name = name;
        this.Type = Type;
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