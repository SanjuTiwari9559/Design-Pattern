using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This is the Example of Why I Write Sealed KeyWord Because If I do'n write this then I can create  another object of the That class
namespace SingleTonClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            SingleTon singleTon=SingleTon.getInstance();
            SingleTon singleTon1 = SingleTon.getInstance();
            SingleTon.Double1 double1=new SingleTon.Double1();
            
            

            
           
            
        }
    }
    public class SingleTon
    {
        private static SingleTon instance;
       
        private  SingleTon()
        {
            
        }
        public  static SingleTon getInstance()
        {
            if(instance == null)
            {
                instance = new SingleTon();
            }
            return instance;
        }
        public  class Double1 : SingleTon
        {

            public Double1()
            {
                
            }
        }
    }
   
}
