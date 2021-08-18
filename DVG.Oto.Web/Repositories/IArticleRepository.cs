using DVG.Oto.Web.Models.Api;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVG.Oto.Web.Repositories {
      public interface IArticleRepository {
            Task<IEnumerable<ArticleEntity>> GetArticleByCategory(Guid categoryId);
            Task<IEnumerable<ArticleEntity>> GetArticleBySite(Guid siteId);
      }
}