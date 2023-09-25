using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class FileNotFoundExceptions
    {
        public void Efile()
        {
            var file = "uday.txt";
            try
            {
                var text = File.ReadAllText(file);
                Console.WriteLine(text);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
