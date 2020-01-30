using System;
using Newtonsoft.Json;
using PrHeroEventsPoc.Repositories;

namespace PrHeroEventsPocConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var gitHubRepo = new GitHubRepository(
                new SmeeGitHubClient());
            gitHubRepo.OnMessage += OnGitHubMessage;

            Console.WriteLine("Connecting to GitHub...");
            gitHubRepo.Connect();
            Console.WriteLine("Connected to GitHub");

            while (Console.ReadLine() != "0")
            {

            }
        }

        private static void OnGitHubMessage()
        {
            Console.Write("Message received: ");
            //Console.Write(JsonConvert.SerializeObject(e)); // This is a typed object.
            Console.WriteLine();
        }
    }
}
