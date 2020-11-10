using System;
using System.Threading.Tasks;

namespace FireAndForgot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            AnAsyncMethod();
            Console.WriteLine("after method call");

            Console.Read();
        }

        private static async Task AnAsyncMethod()
        {
            Console.WriteLine("start method");
            await Task.Delay(2000);
            Console.WriteLine("end method");

            //throw new Exception("oops");
        }
    }
}
