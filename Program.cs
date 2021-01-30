using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace coreConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while (1 == 1)
            {
                HttpClient client = new HttpClient();

                string uri = "https://timesheetrest.azurewebsites.net/api/measurements";

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("Ladataan Raspberryn dataa... hetkinen....");

                string responseBody = await client.GetStringAsync(uri);

                Console.Write(responseBody);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enterillä data päivittyy, sammutus sulkemalla ikkuna");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

        }
    }
}
