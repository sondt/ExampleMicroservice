using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVG.Services.Article.Models {
      public class ArticleEntity {
            public Guid Id { get; set; }
            public string Title { get; set; }
            public string Sapo { get; set; }
            public string CustomForSiteA { get; set; }
            public string CustomForSiteB { get; set; }
            public Guid SiteId { get; set; }
            public Guid CategoryId { get; set; }
      }


}
