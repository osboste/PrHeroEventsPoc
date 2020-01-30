using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Smee.IO.Client;
using Smee.IO.Client.Dto;

namespace PrHeroEventsPoc.Repositories
{
    public class SmeeGitHubClient : IGitHubClient
    {
        private SmeeClient smeeClient;
        private CancellationToken cancellationToken;

        public event Action OnMessage;

        public async void Connect()
        {
            var smeeUri = new Uri("https://smee.io/9oGgt0u7vPlIxpsU");
            smeeClient = new SmeeClient(smeeUri);

            smeeClient.OnConnect += OnGitHubConnected;
            smeeClient.OnDisconnect += OnGitHubDisconnected;
            smeeClient.OnMessage += OnGitHubMessage;
            smeeClient.OnPing += OnGitHubPing;
            smeeClient.OnError += OnGitHubError;

            cancellationToken = new CancellationToken();

            await smeeClient.StartAsync(cancellationToken);
        }

        public void Disconnect()
        {
            smeeClient.Stop();
        }

        private void OnGitHubConnected(object sender, EventArgs e)
        {
            
        }

        private void OnGitHubDisconnected(object sender, EventArgs e)
        {
            
        }

        private void OnGitHubMessage(object sender, SmeeEvent e)
        {
            var typedObject = JsonConvert.SerializeObject(e); // This is a typed object.
            OnMessage?.Invoke();
        }

        private void OnGitHubPing(object sender, EventArgs e)
        {
            
        }

        private void OnGitHubError(object sender, Exception e)
        {
            
        }
    }
}
