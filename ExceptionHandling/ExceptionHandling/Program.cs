using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    //a problem that occurs dring the execution a program is refer to as an exception
    //it allow to control a passed from one part of the programme to the another exception 
    //it will prevent the crashing of the programme 
    internal class Program
    {
        static void Main(string[] args)
        {
            //DevidedByZeroException devidedByZeroException = new DevidedByZeroException();
            //devidedByZeroException.DivisionByZero();
            //Console.ReadLine();

            //    FileNotFoundExceptions fi = new FileNotFoundExceptions();
            //    fi.Efile();
            //    Console.ReadLine();

            //Console.WriteLine("enter your first name");
            //string FirstName = Console.ReadLine();
            //Console.WriteLine("enter your Last Name");
            //string LastName = Console.ReadLine();
            //Console.WriteLine("Hello {0}  {1}",FirstName,LastName);
            //Console.ReadLine();

            //IndexOutofRange exception = new IndexOutofRange();
            //exception.IndexOut();
            //Console.WriteLine();

            ArrayTypeMisMatch typeMisMatch = new ArrayTypeMisMatch();
            typeMisMatch.ArrayType();
            Console.ReadLine();
            
        }

    }
}
