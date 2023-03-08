using System;
using System.Net;
using System.Xml.Linq;
using System;
using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
using System.Linq;

namespace AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
public abstract class Animal : IPilotage //ne peut pas être instancié directement
{
    public string Name { get;  set; }
    public string Type { get; set; }
    public int Id { get; set; }

    public Animal()
    {
        this.Name = "triceratops";
        this.Type = "commun";
        this.Id = 1;
    }

    public Animal(string name, string type, int id)
    {
        this.Name = name; // permet de spécifier le nom de l'animal lors de sa créa + type
        this.Type = type;
        this.Id = id;
    }

    public abstract void Move(); // doit être implémenter par les classes dérivées

    public new void Sleep()
    {
        Console.WriteLine(Name + " rompiche");
    }

    static void Main(string[] args)
    {
        Dog dog = new Dog("Loup","Epic",10);
        Dragon enderDragon = new Dragon("Ender Dragon", "Legendary",99);
        Griffin griffin = new Griffin("GriffonDort", "Rare",5);
        Dragon ptera = new Dragon("Ptera", "Commun", 1);
        Dog wolf = new Dog("Wolf", "Commun", 2);
        Dog ben = new Dog("Ben", "Commun", 20);

        Animal[] liste = { dog, enderDragon, griffin, ptera, wolf, ben};
        //var result = liste.Where(c => !c.Type.Contains("Rare"));

        //foreach (Animal animaux in result)
        //{
        //    Console.WriteLine(animaux.Name, animaux.Id);
        //}

        IEnumerable <Animal> listeAnimaux =
            from animaux in liste
            where animaux.Type == "Commun"         
            select animaux;

        var sortedliste = listeAnimaux.OrderByDescending(c => c.Id).ToList();



        foreach (Animal animaux in sortedliste)
        {
            Console.WriteLine(animaux.Name);
        }





        //Dog dog1 = new Dog("Snow");
        //Dog dog2 = new Dog("Bastien");
        //Dog dog3 = new Dog("Antoine");
        //Dog dog4 = new Dog("Raphaël");

        //Dog[] chiens = { dog, dog1, dog2, dog3, dog4 };
        //IEnumerable<Dog> noSnow =

        //    from chien in chiens
        //    where chien.Name != "Snow"
        //    select chien;

        //foreach (Dog chien in noSnow)
        //{
        //    Console.WriteLine(chien.Name);
        //}

    }
}
