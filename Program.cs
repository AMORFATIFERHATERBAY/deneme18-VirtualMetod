using System;

namespace deneme18_VirtualMetod
{
    class Program
    {
        static void Main(string[] args)
        {
           Mammal mammal1=new Mammal(25,36);
           Cat cat1 = new Cat("Bengal Kedisi", 28,3);
           Sheep sheep1 = new Sheep("Merinos", 55,30);

           mammal1=cat1;
           mammal1.Speak();

           mammal1=sheep1;
           mammal1.Speak();
        }
    }
}
