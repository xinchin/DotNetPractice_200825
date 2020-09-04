using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcServer.Web.Protos;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new EmployeeService.EmployeeServiceClient(channel);
            var response = await client.GetByNoAsync(new GetByNoRequest
            {
                No = 1977
            }); ;

            Console.WriteLine($"Response messages : {response}");
            Console.WriteLine($"Press any key to exit.");
            Console.ReadKey();

        }
    }
}
