using System;
using System.Threading.Tasks;
using Octokit;

namespace kraken
{
    class Program
    {
        public static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                var github = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));
                var user = await github.User.Get("bergren2");
                Console.WriteLine(user.Followers + " followers");
            }).GetAwaiter().GetResult();
        }
    }
}
