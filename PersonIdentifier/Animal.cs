using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIdentifier
{
    internal abstract class Animal
    {
        public string Name;
        public double Wieght;
        public int Age;
        
        protected Animal(string name, double weight, int age) {
            Name = name;
            Wieght = weight;
            Age = age;
        }
        public abstract void DoSound();

        public abstract string Stats();
    }

    internal class Hourse : Animal
    {
        public string Color;
        public Hourse(string name, double weight, int age, string color) : base(name, weight, age)
        {
            Color = color;
        }

        public override void DoSound() {
            Console.WriteLine("Hourse sound");
        }

        public override string Stats()
        {
            return $"Hourse: {this.Name}, {this.Wieght}, {this.Age}, {this.Color}";
        }
    }

    internal class Dog : Animal
    {
        public string BreedOfDog;
        public Dog(string name, double weight, int age, string breedOfDog) : base(name, weight, age)
        {
            BreedOfDog = breedOfDog;
        }

        public override void DoSound()
        {
            Console.WriteLine("Dog sound");
        }

        public override string Stats()
        {
            return $"Dog: {this.Name}, {this.Wieght}, {this.Age}, {this.BreedOfDog}";
        }

        public string Hungry()
        {
            return "I need more food.";
        }
    }

    internal class Hedgehog : Animal
    {
        public int NrOfSpikes;
        public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Hedgehog sound");
        }

        public override string Stats()
        {
            return $"Hedgehog: {this.Name}, {this.Wieght}, {this.Age}, {this.NrOfSpikes}";
        }
    }

    internal class Worm : Animal
    {
        public bool IsPoisonous;
        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("Worm sound");
        }

        public override string Stats()
        {
            return $"Worm: {this.Name}, {this.Wieght}, {this.Age}, {(this.IsPoisonous ? "poisonous" : "not poisonous")}";
        }
    }

    internal class Bird : Animal
    {
        public double WingSpan;
        public Bird(string name, double weight, int age, int wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bird sound");
        }

        public override string Stats()
        {
            return $"Bird: {this.Name}, {this.Wieght}, {this.Age}, {this.WingSpan}";
        }
    }

    internal class Wolf : Animal
    {
        public bool IsBlackAndWhite;
        public Wolf(string name, double weight, int age, bool isBlackAndWhite) : base(name, weight, age)
        {
            IsBlackAndWhite = isBlackAndWhite;
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolf sound");
        }

        public override string Stats()
        {
            return $"Wolf: {this.Name}, {this.Wieght}, {this.Age}, {(this.IsBlackAndWhite ? "black and white" : "gray and white")}";
        }
    }


    internal class Pelican: Bird
    {
        public bool IsWhite;
        public Pelican(string name, double weight, int age, int wingSpan, bool isWhite) : base(name, weight, age, wingSpan) 
        {
            IsWhite = isWhite;
        }

        public override void DoSound()
        {
            Console.WriteLine("Pelican sound");
        }

        public override string Stats()
        {
            return $"Pelican: {this.Name}, {this.Wieght}, {this.Age}, {(this.IsWhite ? "white" : "gray")}";
        }
    }

    internal class Flamingo : Bird
    {
        public bool CanDance;
        public Flamingo(string name, double weight, int age, int wingSpan, bool canDance) : base(name, weight, age, wingSpan)
        {
            CanDance = canDance;
        }

        public override void DoSound()
        {
            Console.WriteLine("Flamingo sound");
        }

        public override string Stats()
        {
            return $"Flamingo: {this.Name}, {this.Wieght}, {this.Age}, {(this.CanDance? "can dance": "can not dance")}";
        }
    }

    internal class Swan : Bird
    {
        public bool IsBlack;
        public Swan(string name, double weight, int age, int wingSpan, bool isBlack) : base(name, weight, age, wingSpan)
        {
            IsBlack = isBlack;
        }

        public override void DoSound()
        {
            Console.WriteLine("Swan sound");
        }

        public override string Stats()
        {
            return $"Swan: {this.Name}, {this.Wieght}, {this.Age}, {(this.IsBlack ? "black" : "white")}";
        }
    }

    internal interface IPerson
    {
        public void Talk();
    }

    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, bool isBlackAndWhite) : base(name, weight, age, isBlackAndWhite)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolfman sound");
        }

        public void Talk()
        {
            Console.WriteLine("I am a wolfman.");
        }

        public override string Stats()
        {
            return $"Wolfman {this.Name}, {this.Wieght}, {this.Age}, {(this.IsBlackAndWhite ? "black and white" : "white and gray")}";
        }
    }
    // 3.3) 
    // 13. F: I Birds klass.
    // 14. F: I Animals Klass.

    // 3.4)
    //9. F: För att listan har typen "Dog" och accepterar bara instanser av Dog eller med en type som ärvar från Dog.
    //10. F: Typen måste vara Animal för att alla djur ärver från animal.
    //13. F: Alla djurens Stats kommer att skrivs ut genom att anropa Stats() metoden för varje objekt i listan.
    //17. F: För att Hungry metoden finns bara i Dogs klassen och inte i Animal klassen.
}
