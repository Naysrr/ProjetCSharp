using AnimalCSharp.ConsoleApp1.ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models.Animals
{
    internal class Eagle : Animal, IFly
    {

        public Eagle()
        {

        }

        public Eagle(string name, string type, int id, int age)
        {
            this.Name = name;
            this.Type = Type;
            this.Id = id;
            this.Age = age;
        }
        public override void Move() { }

        public void Fly()
        {
            Console.WriteLine(Name + "prends le top en volant");
        }
    }
}
