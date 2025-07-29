using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class FilterExample1
    {
        static void FilterData(string name)
        {
            string filter = "";

            if (name.Length >= 0 && name.Length <= 3)
            {
                filter = "small";
            }
            else if (name.Length > 3 && name.Length <= 10)
            {
                filter = "medium";
            }
            else if (name.Length > 10)
            {
                filter = "good";
            }
            if (filter == "small")
            {
                throw new FilterException("small name exception occured");
            }
            else if (filter == "medium")
            {
                throw new FilterException("medium name exception occurred");
            }
            else if (filter == "good")
            {
                throw new FilterException("good its not an exception...");
            }
            else
            {
                throw new FilterException("This Case Not Defined...");
            }
        }
        static void Main()
        {
            string name;
            Console.WriteLine("Enter Name  ");
            name = Console.ReadLine();

            try
            {
                FilterData(name);
            }
            catch (FilterException e) when (e.Message.Contains("small"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterException e) when (e.Message.Contains("medium"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterException e) when (e.Message.Contains("good"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



    }
}
