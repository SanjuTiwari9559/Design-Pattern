using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryDesignPattern
{
    public  class Program
    {
        static void Main(string[] args)
        {
            
            FactoryDesignPattern factoryDesignPattern = new FactoryDesignPattern();
            FourSiterCar fourSiterCar=(FourSiterCar) factoryDesignPattern.getCar("FourSiterCar");
             fourSiterCar.start();
           
        }
    }
   public interface ICar
    {
        void start();
    }
    public class FourSiterCar : ICar
    {
        public void start()
        {
            Console.WriteLine("This is four seater car");
        }
    }
    public class SixSeaterCar : ICar
    {
        public void start()
        {
            Console.WriteLine("This is 6 seater Car");
        }
    }
    public class FactoryDesignPattern
    {
        public ICar getCar(string  carName)
        {
            switch(carName)
            {
                case "SixSeaterCar":
                    return new SixSeaterCar();
                case "FourSiterCar":
                    return new FourSiterCar();

            }
            return null;

         
        }
    }
}
