using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DVG.Oto.Web.Models.Api;
using DVG.Oto.Web.Extensions;
namespace DVG.Oto.Web.Repositories {
      public class ArticleRepository : IArticleRepository {
            private readonly HttpClient _client;
            public ArticleRepository(HttpClient client) => _client = client;

            public async Task<IEnumerable<ArticleEntity>> GetArticleByCategory(Guid categoryId) {
                  var response = await _client.GetAsync($"https://localhost:44357/v1/getbycategory/{categoryId}");
                  return await response.ReadContentAs<List<ArticleEntity>>();
            }

            public async Task<IEnumerable<ArticleEntity>> GetArticleBySite(Guid siteId) {
                  var response = await _client.GetAsync($"https://localhost:44357/v1/getbysite/{siteId}");
                  return await response.ReadContentAs<List<ArticleEntity>>();
            }
      }
}
