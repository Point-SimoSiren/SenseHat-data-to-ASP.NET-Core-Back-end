using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace coreConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            HttpClient client = new HttpClient();

            string uri = "https://timesheetrest.azurewebsites.net/api/measurements";

            string responseBody = await client.GetStringAsync(uri);

            Console.WriteLine(responseBody);

        }
    }
}
