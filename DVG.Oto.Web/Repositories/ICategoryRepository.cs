using DVG.Oto.Web.Models.Api;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DVG.Oto.Web.Repositories {
      public interface ICategoryRepository {
            Task<IEnumerable<Category>> GetAllBySite(Guid siteId);
            Task<Category> GetByid(Guid categoryId);
      }
}