using System;

namespace deneme18_VirtualMetod
{
    abstract class Shape1
    {
        protected double mBoy;
        protected double mEn;
        abstract public double Boy
        {
            get;
            set;
        }
        abstract public double En
        {
            get;
            set;
        }
        public Shape1(double boy, double en)
        {
            this.Boy = boy;
            this.En = en;
        }
        // virtual public double Area()
        // {
        //     return 0;
        // }
        abstract public double Area();
        abstract public void WriteScreen();


    }
    class Square1 : Shape1
    {
        private bool isSquare;
        public Square1(int boy, int en) : base(boy, en)
        {
            SquareControl();
        }
        public bool IsSquare
        {
            get { return isSquare; }
        }
        override public double Boy
        {
            get { return mBoy; }
            set
            {
                mBoy = value;
                SquareControl();
            }

        }
        override public double En
        {
            get { return mEn; }
            set
            {
                mEn = value;
                SquareControl();
            }

        }
        private void SquareControl()
        {
            if (Boy == En)
                isSquare = true;
            else
                isSquare = false;
        }

        override public double Area()
        {
            return Boy * En;
        }
        //  public static void FindArea(Shape sekil)
        // {
        //     Console.WriteLine("The Area of Shape :{0} \n", sekil.Area());
        // }
        override public void WriteScreen()
        {
            Console.WriteLine("\nDörtgenin eni  :{0} ", En);
            Console.WriteLine("Dörtgenin boyu :{0} ", Boy);
            
            Console.WriteLine("Kare mi : {0} ", (isSquare ? "Evet" : "Hayır"));
            Console.WriteLine("Dörtgenin alanı :{0} \n",Area());
        }
    }
    class Triangle1 : Shape1
    {
        private string ucgenTuru;
        public Triangle1(string turu,int boy, int en) : base(boy, en)
        {
            ucgenTuru = turu;
        }
         override public double Boy
        {
            get { return mBoy; }
            set{ mBoy = value;}

        }
        override public double En
        {
            get { return mEn; }
            set { mEn = value;}
        }
        override public double Area()
        {
            return (double)Boy * En / 2;
        }
        override public void WriteScreen()
        {
            Console.WriteLine("\nÜçgenin eni  :{0} ", En);
            Console.WriteLine("Üçgenin boyu :{0} ", Boy);
            
            Console.WriteLine("Üçgenin türü : {0} ",ucgenTuru ); // (isSquare ? "Evet" : "Hayır")
            Console.WriteLine("Üçgenin alanı :{0} \n",Area());
        }
    }

}
