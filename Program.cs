using System;
using System.Threading.Tasks;
using Lambda;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tasker.FifthRun();

            // Lambda Class
            Lambdas lambda = new Lambdas();
            lambda.Run();

            //Actions Class
            Actions.Listings();

            // Tasker Class
            Tasker.FirstRun();
            Task second = Tasker.SecondRun();
            second.Wait();

            Tasker.ThirdRun();
            Console.WriteLine(Tasker.FourthRun().Result);
        }
    }
}
