using System;

namespace resume_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new instance of dog
            var newDog = new Dog();
            Console.WriteLine("Enter Dog's name:");
            newDog.Name = Console.ReadLine();
            Console.WriteLine("Enter dog's breed:");
            newDog.DogBreed = Console.ReadLine();
            Console.WriteLine("Enter dogs age:");
            newDog.Age = Convert.ToInt32(Console.ReadLine());



            var newCat = new Cat();
            Console.WriteLine("Enter Cat's name:");
            newCat.Name = Console.ReadLine();
            Console.WriteLine("Enter Cat's color:");
            newCat.Colour = Console.ReadLine();
            Console.WriteLine("Enter Cat's age:");
            newCat.Age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(newDog.Name);
            Console.WriteLine("============");

            Console.WriteLine(newDog.GetDescription());
            Console.WriteLine("");

            Console.WriteLine(newCat.Name);
            Console.WriteLine("============");

            Console.WriteLine(newCat.GetDescription());
        }
    }



    public class Dog :Animal
    {
        public string DogBreed { get; set; }
        public string GetDescription()
        {
            //Same as return Name + "is a " + Breed + ". He is " + Age + " years old.";
            return $"{Name} is a {DogBreed}. He is {Age} years old.";
        }
    }

    public class Cat : Animal
    {
        public string Colour { get; set; }
        public string GetDescription()
        {
            return $"{Name} is a {Colour} cat. He is {Age} years old.";
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


}
