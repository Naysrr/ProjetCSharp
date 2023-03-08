using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
using System;
using System.Security.Cryptography.X509Certificates;

public class Dog : Animal
{

	public Dog(string name, string type, int id)
	{
		this.Name = name;
        this.Type = type;
        this.Id = id;
	}

    public override void Move()
    {
        
    }

    

}
