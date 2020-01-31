using System;
using System.Collections.Generic;
using System.Text;
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
        public void HandleGitHubEvent(string eventType, JObject eventData)
        {

        }
    }

    public class PullRequestEvent
    {
        public PullRequestEvent(string action, int number, object changes, object pullRequest)
        {

        }

        public PullRequestEventAction Action { get; }

        public int Number { get; }

        public object Changes { get; }

        public object PullRequest { get; }
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
