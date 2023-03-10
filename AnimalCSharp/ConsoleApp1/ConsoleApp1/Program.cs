using System;
using System.Net;
using System.Xml.Linq;
using System;
using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
using System.Linq;

namespace AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;

    static void Main(string[] args)
    {
        Dog dog = new Dog("Loup","Epic",10,5);
        Dragon enderDragon = new Dragon("Ender Dragon", "Legendary", 99, 1000);
        Griffin griffin = new Griffin("GriffonDort", "Rare", 5, 200);
        Dragon ptera = new Dragon("Ptera", "Commun", 1, 3000);
        Dog wolf = new Dog("Wolf", "Commun", 2, 120);
        Dog ben = new Dog("Ben", "Commun", 20, 15);

        Animal[] liste = { dog, enderDragon, griffin, ptera, wolf, ben};
       // var result = liste.Where(c => !c.Type.Contains("Rare"));

       //foreach (Animal animaux in result)
       // {
       //     Console.WriteLine(animaux.Name, animaux.Id);
       // }

       // IEnumerable <Animal> listeAnimaux =
       //     from animaux in liste
       //     where animaux.Type == "Commun"         
       //     select animaux;

       // var sortedliste = listeAnimaux.OrderByDescending(c => c.Id).ToList();



       // foreach (Animal animaux in sortedliste)
       // {
       //     Console.WriteLine(animaux.Name);
       // }

        IEnumerable<Animal> listeAnimauxAge =
            from animaux in liste
            where animaux.Age > 12 && animaux.Age < 15 && animaux.Type == "Commun"
            select animaux;

        foreach(Animal animaux in listeAnimauxAge)
        {
            Console.WriteLine(animaux.Name, animaux.Age);
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
