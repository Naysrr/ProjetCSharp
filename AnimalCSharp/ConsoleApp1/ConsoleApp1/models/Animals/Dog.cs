using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
using System;
using System.Security.Cryptography.X509Certificates;

public class Dog : Animal
{

	public Dog(string name, string type, int id, int age)
	{
		this.Name = name;
        this.Type = type;
        this.Id = id;
        this.Age = age;
	}

    public override void Move()
    {
        
    } 

}
