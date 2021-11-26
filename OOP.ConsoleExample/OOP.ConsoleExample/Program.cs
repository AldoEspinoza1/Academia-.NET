using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace OOP.ConsoleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word");

            Animal animal = new Animal();
            animal.AnimalSound();


            Dog dog = new Dog();
            dog.AnimalSound();

            Cat cat = new Cat();
            cat.AnimalSound();

            Elephant elephant = new Elephant();
            elephant.AnimalSound();



            Console.ReadKey();
        }
    }
}
