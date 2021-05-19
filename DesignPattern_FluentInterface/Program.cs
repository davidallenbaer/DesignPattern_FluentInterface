using System;

namespace DesignPattern_FluentInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee obj = new FluentEmployee();
            
            obj.NameOfTheEmployee("Dave Baer")
                    .Born("06/01/1989")
                    .WorkingOn("IT")
                    .StaysAt("101 Easy Street");

            Console.Read();
        }
    }
}