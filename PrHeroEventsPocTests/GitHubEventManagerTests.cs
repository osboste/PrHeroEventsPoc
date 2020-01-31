﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PrHeroEventsPoc
{
    [TestClass]
    public class GitHubEventManagerTest
    {
        string json = @"{
  'action': 'opened',
  'number': 2,
  'pull_request': {
    'url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/pulls/2',
    'id': 369631372,
    'node_id': 'MDExOlB1bGxSZXF1ZXN0MzY5NjMxMzcy',
    'html_url': 'https://github.com/osboste/PrHeroEventsPoc/pull/2',
    'diff_url': 'https://github.com/osboste/PrHeroEventsPoc/pull/2.diff',
    'patch_url': 'https://github.com/osboste/PrHeroEventsPoc/pull/2.patch',
    'issue_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues/2',
    'number': 2,
    'state': 'open',
    'locked': false,
    'title': 'work',
    'user': {
      'login': 'osboste',
      'id': 59744414,
      'node_id': 'MDQ6VXNlcjU5NzQ0NDE0',
      'avatar_url': 'https://avatars0.githubusercontent.com/u/59744414?v=4',
      'gravatar_id': '',
      'url': 'https://api.github.com/users/osboste',
      'html_url': 'https://github.com/osboste',
      'followers_url': 'https://api.github.com/users/osboste/followers',
      'following_url': 'https://api.github.com/users/osboste/following{/other_user}',
      'gists_url': 'https://api.github.com/users/osboste/gists{/gist_id}',
      'starred_url': 'https://api.github.com/users/osboste/starred{/owner}{/repo}',
      'subscriptions_url': 'https://api.github.com/users/osboste/subscriptions',
      'organizations_url': 'https://api.github.com/users/osboste/orgs',
      'repos_url': 'https://api.github.com/users/osboste/repos',
      'events_url': 'https://api.github.com/users/osboste/events{/privacy}',
      'received_events_url': 'https://api.github.com/users/osboste/received_events',
      'type': 'User',
      'site_admin': false
    },
    'body': '',
    'created_at': '2020-01-31T15:19:52Z',
    'updated_at': '2020-01-31T15:19:52Z',
    'closed_at': null,
    'merged_at': null,
    'merge_commit_sha': null,
    'assignee': null,
    'assignees': [],
    'requested_reviewers': [],
    'requested_teams': [],
    'labels': [],
    'milestone': null,
    'commits_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/pulls/2/commits',
    'review_comments_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/pulls/2/comments',
    'review_comment_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/pulls/comments{/number}',
    'comments_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues/2/comments',
    'statuses_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/statuses/0a277faf790e00faf752567c43aa19276169b483',
    'head': {
      'label': 'osboste:Initial',
      'ref': 'Initial',
      'sha': '0a277faf790e00faf752567c43aa19276169b483',
      'user': {
        'login': 'osboste',
        'id': 59744414,
        'node_id': 'MDQ6VXNlcjU5NzQ0NDE0',
        'avatar_url': 'https://avatars0.githubusercontent.com/u/59744414?v=4',
        'gravatar_id': '',
        'url': 'https://api.github.com/users/osboste',
        'html_url': 'https://github.com/osboste',
        'followers_url': 'https://api.github.com/users/osboste/followers',
        'following_url': 'https://api.github.com/users/osboste/following{/other_user}',
        'gists_url': 'https://api.github.com/users/osboste/gists{/gist_id}',
        'starred_url': 'https://api.github.com/users/osboste/starred{/owner}{/repo}',
        'subscriptions_url': 'https://api.github.com/users/osboste/subscriptions',
        'organizations_url': 'https://api.github.com/users/osboste/orgs',
        'repos_url': 'https://api.github.com/users/osboste/repos',
        'events_url': 'https://api.github.com/users/osboste/events{/privacy}',
        'received_events_url': 'https://api.github.com/users/osboste/received_events',
        'type': 'User',
        'site_admin': false
      },
      'repo': {
        'id': 237315852,
        'node_id': 'MDEwOlJlcG9zaXRvcnkyMzczMTU4NTI=',
        'name': 'PrHeroEventsPoc',
        'full_name': 'osboste/PrHeroEventsPoc',
        'private': false,
        'owner': {
          'login': 'osboste',
          'id': 59744414,
          'node_id': 'MDQ6VXNlcjU5NzQ0NDE0',
          'avatar_url': 'https://avatars0.githubusercontent.com/u/59744414?v=4',
          'gravatar_id': '',
          'url': 'https://api.github.com/users/osboste',
          'html_url': 'https://github.com/osboste',
          'followers_url': 'https://api.github.com/users/osboste/followers',
          'following_url': 'https://api.github.com/users/osboste/following{/other_user}',
          'gists_url': 'https://api.github.com/users/osboste/gists{/gist_id}',
          'starred_url': 'https://api.github.com/users/osboste/starred{/owner}{/repo}',
          'subscriptions_url': 'https://api.github.com/users/osboste/subscriptions',
          'organizations_url': 'https://api.github.com/users/osboste/orgs',
          'repos_url': 'https://api.github.com/users/osboste/repos',
          'events_url': 'https://api.github.com/users/osboste/events{/privacy}',
          'received_events_url': 'https://api.github.com/users/osboste/received_events',
          'type': 'User',
          'site_admin': false
        },
        'html_url': 'https://github.com/osboste/PrHeroEventsPoc',
        'description': 'Initial',
        'fork': false,
        'url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc',
        'forks_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/forks',
        'keys_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/keys{/key_id}',
        'collaborators_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/collaborators{/collaborator}',
        'teams_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/teams',
        'hooks_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/hooks',
        'issue_events_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues/events{/number}',
        'events_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/events',
        'assignees_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/assignees{/user}',
        'branches_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/branches{/branch}',
        'tags_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/tags',
        'blobs_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/blobs{/sha}',
        'git_tags_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/tags{/sha}',
        'git_refs_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/refs{/sha}',
        'trees_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/trees{/sha}',
        'statuses_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/statuses/{sha}',
        'languages_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/languages',
        'stargazers_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/stargazers',
        'contributors_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/contributors',
        'subscribers_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/subscribers',
        'subscription_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/subscription',
        'commits_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/commits{/sha}',
        'git_commits_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/commits{/sha}',
        'comments_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/comments{/number}',
        'issue_comment_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues/comments{/number}',
        'contents_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/contents/{+path}',
        'compare_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/compare/{base}...{head}',
        'merges_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/merges',
        'archive_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/{archive_format}{/ref}',
        'downloads_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/downloads',
        'issues_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues{/number}',
        'pulls_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/pulls{/number}',
        'milestones_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/milestones{/number}',
        'notifications_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/notifications{?since,all,participating}',
        'labels_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/labels{/name}',
        'releases_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/releases{/id}',
        'deployments_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/deployments',
        'created_at': '2020-01-30T22:12:04Z',
        'updated_at': '2020-01-31T14:11:47Z',
        'pushed_at': '2020-01-31T15:19:35Z',
        'git_url': 'git://github.com/osboste/PrHeroEventsPoc.git',
        'ssh_url': 'git@github.com:osboste/PrHeroEventsPoc.git',
        'clone_url': 'https://github.com/osboste/PrHeroEventsPoc.git',
        'svn_url': 'https://github.com/osboste/PrHeroEventsPoc',
        'homepage': null,
        'size': 17,
        'stargazers_count': 0,
        'watchers_count': 0,
        'language': 'C#',
        'has_issues': true,
        'has_projects': true,
        'has_downloads': true,
        'has_wiki': true,
        'has_pages': false,
        'forks_count': 0,
        'mirror_url': null,
        'archived': false,
        'disabled': false,
        'open_issues_count': 1,
        'license': null,
        'forks': 0,
        'open_issues': 1,
        'watchers': 0,
        'default_branch': 'master'
      }
    },
    'base': {
      'label': 'osboste:master',
      'ref': 'master',
      'sha': 'eda346d3134ebbf0237a84a342a1c1c026291d4a',
      'user': {
        'login': 'osboste',
        'id': 59744414,
        'node_id': 'MDQ6VXNlcjU5NzQ0NDE0',
        'avatar_url': 'https://avatars0.githubusercontent.com/u/59744414?v=4',
        'gravatar_id': '',
        'url': 'https://api.github.com/users/osboste',
        'html_url': 'https://github.com/osboste',
        'followers_url': 'https://api.github.com/users/osboste/followers',
        'following_url': 'https://api.github.com/users/osboste/following{/other_user}',
        'gists_url': 'https://api.github.com/users/osboste/gists{/gist_id}',
        'starred_url': 'https://api.github.com/users/osboste/starred{/owner}{/repo}',
        'subscriptions_url': 'https://api.github.com/users/osboste/subscriptions',
        'organizations_url': 'https://api.github.com/users/osboste/orgs',
        'repos_url': 'https://api.github.com/users/osboste/repos',
        'events_url': 'https://api.github.com/users/osboste/events{/privacy}',
        'received_events_url': 'https://api.github.com/users/osboste/received_events',
        'type': 'User',
        'site_admin': false
      },
      'repo': {
        'id': 237315852,
        'node_id': 'MDEwOlJlcG9zaXRvcnkyMzczMTU4NTI=',
        'name': 'PrHeroEventsPoc',
        'full_name': 'osboste/PrHeroEventsPoc',
        'private': false,
        'owner': {
          'login': 'osboste',
          'id': 59744414,
          'node_id': 'MDQ6VXNlcjU5NzQ0NDE0',
          'avatar_url': 'https://avatars0.githubusercontent.com/u/59744414?v=4',
          'gravatar_id': '',
          'url': 'https://api.github.com/users/osboste',
          'html_url': 'https://github.com/osboste',
          'followers_url': 'https://api.github.com/users/osboste/followers',
          'following_url': 'https://api.github.com/users/osboste/following{/other_user}',
          'gists_url': 'https://api.github.com/users/osboste/gists{/gist_id}',
          'starred_url': 'https://api.github.com/users/osboste/starred{/owner}{/repo}',
          'subscriptions_url': 'https://api.github.com/users/osboste/subscriptions',
          'organizations_url': 'https://api.github.com/users/osboste/orgs',
          'repos_url': 'https://api.github.com/users/osboste/repos',
          'events_url': 'https://api.github.com/users/osboste/events{/privacy}',
          'received_events_url': 'https://api.github.com/users/osboste/received_events',
          'type': 'User',
          'site_admin': false
        },
        'html_url': 'https://github.com/osboste/PrHeroEventsPoc',
        'description': 'Initial',
        'fork': false,
        'url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc',
        'forks_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/forks',
        'keys_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/keys{/key_id}',
        'collaborators_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/collaborators{/collaborator}',
        'teams_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/teams',
        'hooks_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/hooks',
        'issue_events_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues/events{/number}',
        'events_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/events',
        'assignees_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/assignees{/user}',
        'branches_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/branches{/branch}',
        'tags_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/tags',
        'blobs_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/blobs{/sha}',
        'git_tags_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/tags{/sha}',
        'git_refs_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/refs{/sha}',
        'trees_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/trees{/sha}',
        'statuses_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/statuses/{sha}',
        'languages_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/languages',
        'stargazers_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/stargazers',
        'contributors_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/contributors',
        'subscribers_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/subscribers',
        'subscription_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/subscription',
        'commits_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/commits{/sha}',
        'git_commits_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/commits{/sha}',
        'comments_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/comments{/number}',
        'issue_comment_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues/comments{/number}',
        'contents_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/contents/{+path}',
        'compare_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/compare/{base}...{head}',
        'merges_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/merges',
        'archive_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/{archive_format}{/ref}',
        'downloads_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/downloads',
        'issues_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues{/number}',
        'pulls_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/pulls{/number}',
        'milestones_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/milestones{/number}',
        'notifications_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/notifications{?since,all,participating}',
        'labels_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/labels{/name}',
        'releases_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/releases{/id}',
        'deployments_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/deployments',
        'created_at': '2020-01-30T22:12:04Z',
        'updated_at': '2020-01-31T14:11:47Z',
        'pushed_at': '2020-01-31T15:19:35Z',
        'git_url': 'git://github.com/osboste/PrHeroEventsPoc.git',
        'ssh_url': 'git@github.com:osboste/PrHeroEventsPoc.git',
        'clone_url': 'https://github.com/osboste/PrHeroEventsPoc.git',
        'svn_url': 'https://github.com/osboste/PrHeroEventsPoc',
        'homepage': null,
        'size': 17,
        'stargazers_count': 0,
        'watchers_count': 0,
        'language': 'C#',
        'has_issues': true,
        'has_projects': true,
        'has_downloads': true,
        'has_wiki': true,
        'has_pages': false,
        'forks_count': 0,
        'mirror_url': null,
        'archived': false,
        'disabled': false,
        'open_issues_count': 1,
        'license': null,
        'forks': 0,
        'open_issues': 1,
        'watchers': 0,
        'default_branch': 'master'
      }
    },
    '_links': {
      'self': {
        'href': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/pulls/2'
      },
      'html': {
        'href': 'https://github.com/osboste/PrHeroEventsPoc/pull/2'
      },
      'issue': {
        'href': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues/2'
      },
      'comments': {
        'href': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues/2/comments'
      },
      'review_comments': {
        'href': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/pulls/2/comments'
      },
      'review_comment': {
        'href': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/pulls/comments{/number}'
      },
      'commits': {
        'href': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/pulls/2/commits'
      },
      'statuses': {
        'href': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/statuses/0a277faf790e00faf752567c43aa19276169b483'
      }
    },
    'author_association': 'OWNER',
    'draft': false,
    'merged': false,
    'mergeable': null,
    'rebaseable': null,
    'mergeable_state': 'unknown',
    'merged_by': null,
    'comments': 0,
    'review_comments': 0,
    'maintainer_can_modify': false,
    'commits': 1,
    'additions': 35,
    'deletions': 58,
    'changed_files': 7
  },
  'repository': {
    'id': 237315852,
    'node_id': 'MDEwOlJlcG9zaXRvcnkyMzczMTU4NTI=',
    'name': 'PrHeroEventsPoc',
    'full_name': 'osboste/PrHeroEventsPoc',
    'private': false,
    'owner': {
      'login': 'osboste',
      'id': 59744414,
      'node_id': 'MDQ6VXNlcjU5NzQ0NDE0',
      'avatar_url': 'https://avatars0.githubusercontent.com/u/59744414?v=4',
      'gravatar_id': '',
      'url': 'https://api.github.com/users/osboste',
      'html_url': 'https://github.com/osboste',
      'followers_url': 'https://api.github.com/users/osboste/followers',
      'following_url': 'https://api.github.com/users/osboste/following{/other_user}',
      'gists_url': 'https://api.github.com/users/osboste/gists{/gist_id}',
      'starred_url': 'https://api.github.com/users/osboste/starred{/owner}{/repo}',
      'subscriptions_url': 'https://api.github.com/users/osboste/subscriptions',
      'organizations_url': 'https://api.github.com/users/osboste/orgs',
      'repos_url': 'https://api.github.com/users/osboste/repos',
      'events_url': 'https://api.github.com/users/osboste/events{/privacy}',
      'received_events_url': 'https://api.github.com/users/osboste/received_events',
      'type': 'User',
      'site_admin': false
    },
    'html_url': 'https://github.com/osboste/PrHeroEventsPoc',
    'description': 'Initial',
    'fork': false,
    'url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc',
    'forks_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/forks',
    'keys_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/keys{/key_id}',
    'collaborators_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/collaborators{/collaborator}',
    'teams_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/teams',
    'hooks_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/hooks',
    'issue_events_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues/events{/number}',
    'events_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/events',
    'assignees_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/assignees{/user}',
    'branches_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/branches{/branch}',
    'tags_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/tags',
    'blobs_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/blobs{/sha}',
    'git_tags_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/tags{/sha}',
    'git_refs_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/refs{/sha}',
    'trees_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/trees{/sha}',
    'statuses_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/statuses/{sha}',
    'languages_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/languages',
    'stargazers_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/stargazers',
    'contributors_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/contributors',
    'subscribers_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/subscribers',
    'subscription_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/subscription',
    'commits_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/commits{/sha}',
    'git_commits_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/git/commits{/sha}',
    'comments_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/comments{/number}',
    'issue_comment_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues/comments{/number}',
    'contents_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/contents/{+path}',
    'compare_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/compare/{base}...{head}',
    'merges_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/merges',
    'archive_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/{archive_format}{/ref}',
    'downloads_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/downloads',
    'issues_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/issues{/number}',
    'pulls_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/pulls{/number}',
    'milestones_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/milestones{/number}',
    'notifications_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/notifications{?since,all,participating}',
    'labels_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/labels{/name}',
    'releases_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/releases{/id}',
    'deployments_url': 'https://api.github.com/repos/osboste/PrHeroEventsPoc/deployments',
    'created_at': '2020-01-30T22:12:04Z',
    'updated_at': '2020-01-31T14:11:47Z',
    'pushed_at': '2020-01-31T15:19:35Z',
    'git_url': 'git://github.com/osboste/PrHeroEventsPoc.git',
    'ssh_url': 'git@github.com:osboste/PrHeroEventsPoc.git',
    'clone_url': 'https://github.com/osboste/PrHeroEventsPoc.git',
    'svn_url': 'https://github.com/osboste/PrHeroEventsPoc',
    'homepage': null,
    'size': 17,
    'stargazers_count': 0,
    'watchers_count': 0,
    'language': 'C#',
    'has_issues': true,
    'has_projects': true,
    'has_downloads': true,
    'has_wiki': true,
    'has_pages': false,
    'forks_count': 0,
    'mirror_url': null,
    'archived': false,
    'disabled': false,
    'open_issues_count': 1,
    'license': null,
    'forks': 0,
    'open_issues': 1,
    'watchers': 0,
    'default_branch': 'master'
  },
  'sender': {
    'login': 'osboste',
    'id': 59744414,
    'node_id': 'MDQ6VXNlcjU5NzQ0NDE0',
    'avatar_url': 'https://avatars0.githubusercontent.com/u/59744414?v=4',
    'gravatar_id': '',
    'url': 'https://api.github.com/users/osboste',
    'html_url': 'https://github.com/osboste',
    'followers_url': 'https://api.github.com/users/osboste/followers',
    'following_url': 'https://api.github.com/users/osboste/following{/other_user}',
    'gists_url': 'https://api.github.com/users/osboste/gists{/gist_id}',
    'starred_url': 'https://api.github.com/users/osboste/starred{/owner}{/repo}',
    'subscriptions_url': 'https://api.github.com/users/osboste/subscriptions',
    'organizations_url': 'https://api.github.com/users/osboste/orgs',
    'repos_url': 'https://api.github.com/users/osboste/repos',
    'events_url': 'https://api.github.com/users/osboste/events{/privacy}',
    'received_events_url': 'https://api.github.com/users/osboste/received_events',
    'type': 'User',
    'site_admin': false
  }
}";

        [TestMethod]
        public void Test1()
        {
            var mgr = new GitHubEventManager();
            mgr.HandleGitHubEvent(@"pull_request", JObject.Parse(json));
        }
    }
}
