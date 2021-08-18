using DVG.Services.Article.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVG.Services.Article.Repositories {
      public interface IArticleRepository {
            Task<IEnumerable<ArticleEntity>> GetArticleBySite(Guid siteId);
            Task<IEnumerable<ArticleEntity>> GetArticleByCategory(Guid categoryId);
      }
}
