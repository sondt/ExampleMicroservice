using DVG.Services.Article.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVG.Services.Article.Repositories {
      public class ArticleRepository : IArticleRepository {
            private readonly Services.ArticleService _articleService;
            public ArticleRepository() => _articleService = new Services.ArticleService();
            public Task<IEnumerable<ArticleEntity>> GetArticleByCategory(Guid categoryId) => _articleService.GetArticleByCategory(categoryId);
            public Task<IEnumerable<ArticleEntity>> GetArticleBySite(Guid siteId) => _articleService.GetArticleBySite(siteId);
      }
}
