using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class IndexOutofRange
    {
        public void IndexOut()
        {
            int[] array = new int[5]
            {
                1, 2, 3, 4, 5,
            };
            try
            {
                Console.WriteLine(array[6]);
            }
            catch(IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }
    }
}
