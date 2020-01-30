using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace PrHeroEventsPoc.Repositories
{
    public interface IGitHubClient
    {
        void Connect();
        void Disconnect();

        event Action OnMessage;
    }

    public interface IGitHubRepository
    {
        void Connect();
        void Disconnect();

        event Action OnMessage;
    }

    public class GitHubRepository : IGitHubRepository
    {
        private IGitHubClient client;

        public event Action OnMessage;

        public GitHubRepository(IGitHubClient client)
        {
            this.client = client;
        }

        public async Task<string> TestConnection()
        {
            //var clientId = "Iv1.6859b3761e496d10";
            //var clientSecret = "c27284d668ff8ce03869992d0b11eca631e6356c";
            var client = new GitHubClient(new ProductHeaderValue("PrHeroApp"));
            
            //var tokenAuth = new Credentials("token"); 
            //client.Credentials = tokenAuth;
            var user = await client.User.Get("osboste");
            return user.Login;
        }

        public void Connect()
        {
            client.OnMessage += OnGitHubMessage; 
            client.Connect();
        }

        public void Disconnect()
        {
            client.Disconnect();
        }

        private void OnGitHubMessage()
        {
            OnMessage?.Invoke();
        }
    }
}
