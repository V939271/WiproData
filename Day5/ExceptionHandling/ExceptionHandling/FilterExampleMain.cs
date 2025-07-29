using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class FilterExampleMain
    {
        static void RaiseSeverity(string severity)
        {
            if (severity.Equals("low"))
            {
                throw new FilterExampleException("Low severity you can leave for time being..");

            }else if (severity.Equals("medium"))
            {
                throw new FilterExampleException("medium severity you need to try to fix without leaving...");
            }else if (severity.Equals("high"))
            {
                throw new FilterExampleException("high severity You need to fix on high priority...");
            }else if (severity.Equals("critical"))
            {
                throw new FilterExampleException("critical error as fix first as stop all other works...");
            }
            else
            {
                throw new FilterExampleException("No Error Occured...");
            }
        }

        static void Main()
        {
            string severity;
            Console.WriteLine("Enter the Severity (low/medium/high/critical) ");
            severity = Console.ReadLine();

            try
            {
                RaiseSeverity(severity);
            }
            catch(FilterExampleException e) when (e.Message.Contains("low"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterExampleException e) when (e.Message.Contains("medium"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterExampleException e) when (e.Message.Contains("high"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterExampleException e) when (e.Message.Contains("critical"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterExampleException e)
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
