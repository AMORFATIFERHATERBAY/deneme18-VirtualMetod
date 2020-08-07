using System;

namespace deneme18_VirtualMetod
{
    class Mammal
    {
        public double Height
        {
            get;
            set;
        }
        public double Weight
        {
            get;
            set;
        }
        public Mammal(double height, double weight)
        {
            this.Height = height;
            this.Weight = weight;
        }
        virtual public void Speak()
        {
            Console.WriteLine("I don't speak.");
        }

    }
    class Cat : Mammal
    {
        public string Species
        {
            get;
            set;
        }
        public Cat(string species, int height, int weight) : base(height, weight)
        {
            this.Species = species;
        }
        override public void Speak()
        {
            Console.WriteLine("I'm a cat! Miyavv miiiyaavv\n");
        }
    }
    class Sheep : Mammal
    {
        public string Species
        {
            get;
            set;
        }
        public Sheep(string species, int height, int weight) : base(height, weight)
        {
            this.Species = species;
        }
        override public void Speak()
        {
            Console.WriteLine("I'm a sheep! Meeee meeee\n");
        }
    }
}
