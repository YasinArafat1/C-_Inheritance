using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program:A
    {
        public void Multiplication() 
        {
            c = a * b;
            Console.WriteLine("Mulitplication is : " + c);

        }
        public void Division()
        {
            c = a / b;
            Console.WriteLine("Division is "+c);
        }
        public void Modulus()
        {
            c = a % b;
            Console.WriteLine("Moudlus is "+c);

        }
        static void Main(string[] args)
        {

            A a = new A();
            a.Addition();
            a.Sub();
            Program p = new Program();
            p.Multiplication();
            p.Division();
            p.Modulus();

        Console.ReadKey();
        }
    }

    public class A 
    {
        protected int a = 200;
        protected int b = 100;
        protected int c;

        public void Addition() 
        {
            c = a + b;
            Console.WriteLine("Addition: "+c);
        }
        public void Sub()
        {
            c = a - b;
            Console.WriteLine("Subtraction is : " + c);
        }



    }

   
}
