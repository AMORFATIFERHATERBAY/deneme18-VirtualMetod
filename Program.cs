using System;

namespace deneme18_VirtualMetod
{
    class Program
    {
        public static void FindArea(Shape sekil)
        {
            Console.WriteLine("The Area of Shape :{0} \n", sekil.Area());
        }
        static void Main(string[] args)
        {
            // Mammal mammal1 = new Mammal(25, 36);
            Cat cat1 = new Cat("Bengal Kedisi", 28, 3);
            Sheep sheep1 = new Sheep("Merinos", 55, 30);

            // mammal1.Speak();

            // mammal1 = cat1;
            // mammal1.Speak();

            // mammal1 = sheep1;
            // mammal1.Speak();

            cat1.Speak();
            sheep1.Speak();
            Console.WriteLine();


            Triangle ucgen = new Triangle(5, 6);

            Square dortgen = new Square(7, 8);

            // Shape sekil = new Shape(6, 7);

            // Shape.FindArea(dortgen);

            // Shape.FindArea(ucgen);

            // Shape.FindArea(sekil);

            FindArea(dortgen);
            FindArea(ucgen);
            // FindArea(sekil);


            Shape1[] shape = new Shape1[3];


            shape[0] = new Triangle1("İkiz kenar", 18, 12);
            shape[1] = new Square1(18, 12);
            shape[1].Boy=12;
            shape[2] = new Square1(20, 20);

            foreach (Shape1 s in shape)
                s.WriteScreen();



        }
    }
}
