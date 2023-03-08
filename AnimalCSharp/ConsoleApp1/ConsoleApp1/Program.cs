using System;
using System.Net;
using System.Xml.Linq;


class Animal
{
    public string Name = null;

    static void Main(string[] args)
    {
        Move();
        Sleep();
        Console.ReadLine();
    }

    public void animalconstructeur(string Name)
    {
        this.Name = Name;
    }

    public static void Move()
    {
        Console.WriteLine("Move");
	}

    public static void Sleep()
    {
        Console.WriteLine("Sleep");
    }
}