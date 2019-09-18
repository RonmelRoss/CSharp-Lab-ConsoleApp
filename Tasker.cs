using System;
using System.Threading.Tasks;

class Tasker
{
    public static void FirstRun()
    {
        int ctr;
        Task t = Task.Factory.StartNew( () => {
                                  // Just loop.
                                  for (ctr = 0; ctr <= 1000000; ctr++)
                                  {}
                                  Console.WriteLine("T finished {0} loop iterations", ctr);
                               } );
        Task t2 = Task.Factory.StartNew( () => {
            for(ctr = 0; ctr < 5; ctr++){}
            Console.WriteLine("T2 finished {0} loop iterations", ctr);
        });
        t2.Wait();
        t.Wait();
    }

    public static async Task SecondRun()
    {
        int ctr;
        await Task.Run( () => {
                                    // Just loop.
                                    for (ctr = 0; ctr <= 1000000; ctr++)
                                    {}
                                    Console.WriteLine("Finished {0} loop iterations",
                                                        ctr);
                                } );
    }

    public static void ThirdRun()
    {
        Task<string> obTask = Task.Run( () => {
            return"Hello";
        });
        Console.WriteLine(obTask.Result);
    }

    public static async Task<string> FourthRun()
    {
        string val = await Task.Run( () => {
            return("Hi ho!");
        });
        return val;
    }
}
