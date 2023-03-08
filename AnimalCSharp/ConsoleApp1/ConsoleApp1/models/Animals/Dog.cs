using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
using System;
using System.Security.Cryptography.X509Certificates;

public class Dog : Animal
{
	public string Name { get; set; }

	public Dog(string name)
	{
		this.Name = name;
	}

    public override void Move()
    {
        
    }

    

}
