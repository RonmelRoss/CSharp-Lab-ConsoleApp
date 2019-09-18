using System;
using System.Threading.Tasks;
using Lambda;
using Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Lambdas lambda = new Lambdas();
            lambda.Run();

            Actions.Listings();
        }
    }
}
