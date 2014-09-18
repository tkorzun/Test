using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{

    class Menu
    {
        public enum Price
        {
            P1 = 1,
            P2 = 2,
            P3 = 3
        }
    }


    class Drink : Menu
    { 
        Price p = Price.P1;
              
        protected Price drink 
        {
            get { return p; }
            set 
            {               
                switch (value)
                {
                    case Price.P1:
                    case Price.P2:
                    case Price.P3:
                        p = value;
                        break;
                }
            }
        }


        public virtual void ShowMenu()
        {
            Console.WriteLine("Cтоимость {0} $", 
    (int)p);
        }
    }
    
    interface I
    {      
        void Cold();
        void Hot();
        
    }

    class Tea : Drink, I
    {
        public void Cold()
        {
            Console.WriteLine("Tea: Cold");
        }
    
        public void Hot()
        {
            Console.WriteLine("Tea: Hot");
         }


        public override void ShowMenu()
        {
            drink = Price.P1;
            Console.Write("Tea: ");
            base.ShowMenu();
        }
    }

    class Coffe : Drink, I
    {
        public void Cold()
        {
            Console.WriteLine("Coffe: Cold");
        }
    
        public void Hot()
        {
            Console.WriteLine("Coffe: Hot");
        }


        public override void ShowMenu()
        {
            drink = Price.P2;
            Console.Write("Coffe: ");
            base.ShowMenu(); 
        }
    }

    class IceCream : Drink, I
    {
        public void Cold()
        {
            Console.WriteLine("IceCream: Cold");
        }
        public void Hot()
        {
           
        }

        public override void ShowMenu()
        {
            drink = Price.P3;
            Console.Write("IceCream: ");
            base.ShowMenu();
        }       
    }
    
   
    class MyClass
    {
        public MyClass()
        {
            I[] refInterface = 
                {
                    new Tea(),
                    new Coffe(),
                    new IceCream()
                };
    
         
            for(int i = 0; i < refInterface.Length; i++)
            {
            refInterface[i].Cold();
            refInterface[i].Hot();  
            }
            Console.WriteLine();

            ((Tea)refInterface[0]).ShowMenu();
            ((Coffe)refInterface[1]).ShowMenu();
            ((IceCream)refInterface[2]).ShowMenu();           
        }
    }
    
   
    class Program
    {
        static void Main()
        {          
            Console.Title = "Лабораторная работа №1";
            new MyClass();
            Console.ReadLine();
        }
    }
}
