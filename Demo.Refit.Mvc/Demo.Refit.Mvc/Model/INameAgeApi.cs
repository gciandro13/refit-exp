using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Refit.Mvc.Model_Refit
{
    [Headers("User-Agent: Refit Demo App")]
    public interface INameAgeApi
    {
        [Get("/")]
        Task<ResponseNameAge> GetNameAge(string name);
    }
}
