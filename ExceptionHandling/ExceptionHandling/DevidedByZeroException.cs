using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class DevidedByZeroException
    {
        public void DivisionByZero()
        {
            int a = 0;
            //if (a != 0)
            //{
            //    int b = 10 / a;
            //}
            try
            {
                int b = 10 / a;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
