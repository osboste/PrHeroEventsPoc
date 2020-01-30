using System;
using System.Collections.Generic;
using System.Text;
using Octokit;

namespace PrHeroEventsPoc
{
    public class GitHubEventManager
    {
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
