using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DVG.Oto.Web.Models.Api;
using DVG.Oto.Web.Extensions;
using System.Net.Http;

namespace DVG.Oto.Web.Repositories {

      public class CategoryRepository : ICategoryRepository {
            private readonly HttpClient _client;
            public CategoryRepository(HttpClient client) => _client = client;

            public async Task<IEnumerable<Category>> GetAllBySite(Guid siteId) {
                  var response = await _client.GetAsync($"https://localhost:44307/v1/category/getallbysite/{siteId}");
                  return await response.ReadContentAs<List<Category>>();
            }

            public async Task<Category> GetByid(Guid categoryId) {
                  var response = await _client.GetAsync($"https://localhost:44307/v1/category/{categoryId}");
                  return await response.ReadContentAs<Category>();
            }
      }
}
