using Demo.Refit.Mvc.Model_Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Refit.Mvc.Services
{

    public interface INameAgeService
    {
        Task<ResponseNameAge> GetNameAge(string name);
    }

    public class NameAgeService : INameAgeService
    {

        private readonly INameAgeApi _nameAgeApi;

        public NameAgeService(INameAgeApi nameAgeApi)
        {
            _nameAgeApi = nameAgeApi;
        }
        public Task<ResponseNameAge> GetNameAge(string name)
        {
            return _nameAgeApi.GetNameAge(name);
        }
    }
}
