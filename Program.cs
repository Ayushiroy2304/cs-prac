using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        int a,b,result;
        void add()
        {
            int result=a+b;
            System.Console.WriteLine(result);
            Console.ReadLine();
        }
        void sub()
        {
            int result=a-b;
            System.Console.WriteLine(result);
            Console.ReadLine();
        }
        void mul()
        {
            int result = a*b;
            System.Console.WriteLine(result);
            System.Console.ReadLine();
        }
     
    static void Main(string[] args)
    {
         Program obj = new Program();    //objects is intialised Name of the class - any name for the object - then new keyword to intialise the object and then the name of the class 
        obj.a=3;
        obj.b=4;
        obj.add();
        obj.sub();
        obj.mul();
    }

    }
}