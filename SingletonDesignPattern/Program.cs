using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public  class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public interface IEmployee
    {

        void getAllEmployee();
        void getSingleEmployee();
       

    }
    public class Employee : IEmployee
    {
        public Employee()
        {
            
        }
        public void getAllEmployee()
        {
            throw new NotImplementedException();
        }

        public void getSingleEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
