using System;
using Homework3101;
namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Product pr= new Product();
            Drink dr= new Drink();

            pr.Name = "Tequila";
            pr.Price = 45;
            dr.Alcoholepercent = 30;

            Console.WriteLine(pr.Name);
            Console.WriteLine(pr.Price);
            Console.WriteLine(dr.Alcoholepercent);
        }
    }
}
