using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Division
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter 2 Numbers...");

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Division  " + c);
            }

            catch(OverflowException e)
            {
                Console.WriteLine("Number is Too Big...");
            }
            catch(FormatException e)
            {
                Console.WriteLine("String Cannot be Converted as Integer...");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Division By Zero Impossible...");
            }

            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Program From Wipro Batch...");
            }
        }
    }
}
