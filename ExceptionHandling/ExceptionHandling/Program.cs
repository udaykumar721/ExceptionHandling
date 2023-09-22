using System;
using System.Collections.Generic;
using System.Linq;
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
            DevidedByZeroException devidedByZeroException = new DevidedByZeroException();
            devidedByZeroException.DivisionByZero();
            Console.ReadLine();
        }
    }
}
