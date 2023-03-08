using System;
using System.Net;
using System.Xml.Linq;
using System;
using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
namespace AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
public abstract class Animal : IPilotage //ne peut pas être instancié directement
{
    public string Name { get;  set; }
    public string Type { get; set; }

    public Animal()
    {
        this.Name = "triceratops";
        this.Type = "commun";
    }

    public Animal(string name, string type)
    {
        this.Name = name; // permet de spécifier le nom de l'animal lors de sa créa + type
        this.Type = type;
    }

    public abstract void Move(); // doit être implémenter par les classes dérivées

    public new void Sleep()
    {
        Console.WriteLine(Name + " rompiche");
    }

    static void Main(string[] args)
    {
        Dog dog = new Dog("Loup");
        Dog dog1 = new Dog("Snow");
        Dog dog2 = new Dog("Bastien");
        Dog dog3 = new Dog("Antoine");
        Dog dog4 = new Dog("Raphaël");

        Dog[] chiens = { dog, dog1, dog2, dog3, dog4 };
        IEnumerable<Dog> noSnow =

            from chien in chiens
            where chien.Name != "Snow"
            select chien;

        foreach (Dog chien in noSnow)
        {
            Console.WriteLine(chien.Name);
        }
    }
}
