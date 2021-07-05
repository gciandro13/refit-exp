using Demo.Refit.Mvc.Model_Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Refit.Mvc.Services
{

    public interface IGithubService
    {
        Task<String> GetMarkdown(string msg);
    }
    public class GithubService : IGithubService
    {
        private readonly IGithubApi _githubApi;

        public GithubService(IGithubApi githubApi)
        {
            _githubApi = githubApi;
        }

        public Task<String> GetMarkdown(string msg)
        {
            var req = new RenderRequest
            {
                Text = msg
            };
            return _githubApi.GetMarkdown(req);
        }
    }
}
