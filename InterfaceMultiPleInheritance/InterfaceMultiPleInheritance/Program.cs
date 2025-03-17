using System;

namespace InterfaceMultiPleInheritance
{
    interface IAnimalSpeak
    {
        void speak();
    }
    interface IAnimalWalk
    {
        void walk();
    }

    class Dog : IAnimalSpeak, IAnimalWalk
    {
        public void speak()
        {
            Console.WriteLine("Dog barks");
        }
        public void walk()
        {
            Console.WriteLine("Dog walks");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimalWalk animal=new Dog();
            animal.walk();
            IAnimalSpeak animalSpeak=new Dog();
            animalSpeak.speak();
        }
    }
}
