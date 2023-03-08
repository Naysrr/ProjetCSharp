using System;
using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
namespace AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
public class Dragon : Animal, IPilotage // classe dérivée de Animal
{
    public Dragon()
    {
        this.Name = "Dragon";
    }

    public Dragon(string name) 
    {
        this.Name = name;
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