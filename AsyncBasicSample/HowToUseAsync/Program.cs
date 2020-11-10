using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HowToUseAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("start");
            var google = await GetGoogleHtmlAsync();
            Console.WriteLine("middle1");
            await WaitTwoSecondAsync();
            Console.WriteLine("middle2");
            await DoSomething(async () =>
            {
                await Task.Delay(100);
            });
            Console.WriteLine("end");
            Console.WriteLine(google.Substring(0, 50));

            Console.Read();
        }

        private static async Task WaitTwoSecondAsync()
        {
            await Task.Delay(2000);
        }

        private static async Task<string> GetGoogleHtmlAsync()
        {
            var client = new HttpClient();
            return await client.GetStringAsync("https://www.google.com/");
        }

        private static void DoSomething(Action something)
        {
            Console.WriteLine("do something");
            something();
        }

        private static async Task DoSomething(Func<Task> something)
        {
            Console.WriteLine("do something async");
            await something();
        }
    }
}
