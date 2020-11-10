using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncThread
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            Console.WriteLine($"start：{Environment.CurrentManagedThreadId}");
            await Task.Delay(1000);
            Console.WriteLine($"middle：{Environment.CurrentManagedThreadId}");
            var google = await client.GetStringAsync("https://www.google.com/");
            Console.WriteLine($"end：{Environment.CurrentManagedThreadId}");
            Console.WriteLine(google.Substring(0, 50));

            Console.Read();
        }
    }
}
