﻿using System;
using System.Net;
using System.Xml.Linq;
using System;

public abstract class Animal //ne peut pas être instancié directement
{
    public string Name { get; set; }

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

public class Griffin : Animal // classe dérivée de Animal
{
    public Griffin() : base()
    {
        this.Name = "Griffin";
    }

    public Griffin(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine(Name + "en elytra");
    }
}

public class Dragon : Animal // classe dérivée de Animal
{
    public Dragon() : base()
    {
        this.Name = "Dragon";
    }

    public Dragon(string name) : base(name)
    {
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