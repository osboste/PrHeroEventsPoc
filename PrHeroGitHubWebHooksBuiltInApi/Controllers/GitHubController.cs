using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json.Linq;
using PrHeroEventsPoc;

namespace PrHeroGitHubWebHooksBuiltInApi.Controllers
{
    public class GitHubController : ControllerBase
    {
        private IGitHubEventManager _eventManager;

        public GitHubController(IGitHubEventManager eventManager)
        {
            _eventManager = eventManager;
        }

        [GitHubWebHook]
        public IActionResult GitHub(string id, string @event, JObject data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _eventManager.HandleGitHubEvent(@event, data);

            return Ok();
        }
    }
}
