using DVG.Services.Article.Models;
using DVG.Services.Article.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVG.Services.Article.Controllers.v1._0 {

      [ApiController]
      [Route("[controller]")]
      public class ArticleController : Controller {
            private readonly IArticleRepository _articleRepository;
            public ArticleController(IArticleRepository articleRepository) {
                  _articleRepository = articleRepository;
            }

            /// <summary>
            /// Get articles by site
            /// </summary>
            /// <param name="id">Site id</param>
            /// <returns>Return list article</returns>
            [HttpGet]
            [Route("/v{version:apiVersion}/getbysite/{id}")]
            public async Task<IEnumerable<ArticleEntity>> GetArticleBySite(Guid id) {
                  return await _articleRepository.GetArticleBySite(id);
            }

            /// <summary>
            /// Get articles by category
            /// </summary>
            /// <param name="id">Category id</param>
            /// <returns>Return list article</returns>
            [HttpGet]
            [Route("/v{version:apiVersion}/getbycategory/{id}")]
            public async Task<IEnumerable<ArticleEntity>> GetArticleByCategory(Guid id) {
                  return await _articleRepository.GetArticleByCategory(id);
            }
      }
}
