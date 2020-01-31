using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Octokit;

namespace PrHeroEventsPoc
{
    public interface IGitHubEventManager
    {
        void HandleGitHubEvent(string eventType, JObject eventData);
    }

    public class GitHubEventManager : IGitHubEventManager
    {
        public event Action<PullRequestEventModel> PullRequestEvent;

        private GitHubPullRequestEventModelMapper gitHubPullRequestEventModelMapper = new GitHubPullRequestEventModelMapper();

        public void HandleGitHubEvent(string eventType, JObject eventData)
        {
            switch (eventType)
            {
                case @"pull_request":
                    var pr = gitHubPullRequestEventModelMapper.Map(eventData);
                    PullRequestEvent?.Invoke(pr);
                    break;
            }
        }
    }

    public class GitHubPullRequestEventModelMapper
    {
        public PullRequestEventModel Map(JObject pullRequestEventData)
        {
            return pullRequestEventData.ToObject<PullRequestEventModel>();
        }
    }

    public class PullRequestEventModel
    {
        [JsonProperty("action")]
        public PullRequestEventAction Action { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        //public object Changes { get; }

        //public object PullRequest { get; }
    }

    public enum PullRequestEventAction
    {
        Assigned,
        Unassigned,
        Labeled,
        Unlabeled,
        Opened,
        Edited,
        Closed,
        Reopened,
        Synchronize,
        ReadyForReview,
        Locked,
        Unlocked
    }

    public class PullRequest
    {
        
    }
}
