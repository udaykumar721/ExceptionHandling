using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ArrayTypeMisMatch
    {
        public void ArrayType()
        {
            string[] arrayone =
            {
                "Uday","Kumar"
            };
            int[] arrayTwo =
            {
                1,2
            };
            try
            {
                Array.Copy(arrayone, arrayTwo, 2);
            }
            catch(ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
