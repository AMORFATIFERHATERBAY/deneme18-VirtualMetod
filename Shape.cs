using System;

namespace deneme18_VirtualMetod
{
    class Shape
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
        virtual public double Area()
        {
            return 0;
        }
        
       
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
