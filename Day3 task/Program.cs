using System;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Speak()
    {
        Console.WriteLine($"Hello, I'm {Name}, and I'm {Age} years old.");
    }
}

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }
}

public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public void Meow()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main()
    {
        // Create an object of the Animal class
        Animal genericAnimal = new Animal("Generic Animal", 5);
        genericAnimal.Speak();

        // Create an object of the Dog class
        Dog dog = new Dog("Buddy", 3, "Labrador");
        dog.Speak();

        // Create an object of the Cat class
        Cat cat = new Cat("Whiskers", 2);
        cat.Speak();
        cat.Meow();
    }
}
