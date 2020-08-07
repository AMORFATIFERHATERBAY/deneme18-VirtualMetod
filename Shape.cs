using System;

namespace deneme18_VirtualMetod
{
    abstract class Shape
    {
        public double Boy
        {
            get;
            set;
        }
        public double En
        {
            get;
            set;
        }
        public Shape(double boy, double en)
        {
            this.Boy = boy;
            this.En = en;
        }
        // virtual public double Area()
        // {
        //     return 0;
        // }
        abstract public double Area();
       
        
    }
    class Square : Shape
    {
        public Square(int boy, int en) : base(boy, en)
        {

        }
        override public double Area()
        {
            return Boy * En;
        }
        //  public static void FindArea(Shape sekil)
        // {
        //     Console.WriteLine("The Area of Shape :{0} \n", sekil.Area());
        // }

    }
    class Triangle : Shape
    {
        public Triangle(int boy, int en) : base(boy, en)
        {

        }
        override public double Area()
        {
            return (double)Boy * En / 2;
        }
    }

}
