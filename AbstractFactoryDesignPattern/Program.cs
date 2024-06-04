using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            VechicleCompany vechicleCompany = new TeslaCompany();
            vechicleCompany.Car();
            vechicleCompany.Bike();
        }
    }
    public abstract class VechicleCompany
    {
        abstract public  void Car();
        abstract public void Bike();
    }
    public class TeslaCompany : VechicleCompany
    {
        public override void Bike()
        {
            Console.WriteLine("This is Tesla Bike ");
        }

        public override void Car()
        {
            Console.WriteLine("This is Tesla Car"); 
        }
    }
    public class TataCompany : VechicleCompany
    {
        public override void Bike()
        {
            Console.WriteLine("This is TataCompany Bike") ;
        }

        public override void Car()
        {
            Console.WriteLine("This is TataCompany Car") ;
        }
    }
}
   
