using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DVG.Oto.Web.Models.Api;
using DVG.Oto.Web.Repositories;
using Microsoft.Extensions.Configuration;

namespace DVG.Oto.Web.Pages {
      public class IndexModel : PageModel {
            private readonly ILogger<IndexModel> _logger;
            private readonly IArticleRepository _articleRepository;
            private readonly ICategoryRepository _categoryRepository;
            private readonly IConfiguration _configuration;
            [BindProperty]
            public IEnumerable<ArticleEntity> Articles { get; set; }
            public IndexModel(ILogger<IndexModel> logger, IArticleRepository articleRepository, ICategoryRepository categoryRepository, IConfiguration configuration) {
                  _logger = logger;
                  _articleRepository = articleRepository;
                  _categoryRepository = categoryRepository;
                  _configuration = configuration;
            }

            public async Task OnGetAsync() {
                  var siteId = Guid.Parse(_configuration["SiteId"]);
                  Articles = await _articleRepository.GetArticleBySite(siteId);
            }
      }
}
