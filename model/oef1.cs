namespace oef1.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void makeSound()
        {
            Console.WriteLine("unknown sound");
        }
    }
public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }
    public override void makeSound()
    {
        Console.WriteLine("Woof");
    }
}
}
