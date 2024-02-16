

namespace BasicCSharp
{
    public class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    public class Cat :Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Cat says: meow meow");
        }
    }

    public class Dog: Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }
}