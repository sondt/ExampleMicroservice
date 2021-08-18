using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DVG.Services.Article.Models;
namespace DVG.Services.Article.Services {
      public class ArticleService {
            List<ArticleEntity> Articles;
            public ArticleService() {
                  InitData();
            }
            private void InitData() {
                  Articles = new List<ArticleEntity>();
                  var siteId01 = Guid.Parse("42280692-3C6A-4C8F-9630-91912A8791A6");
                  var siteId02 = Guid.Parse("E34D73B9-7670-41BA-AEFA-46D9E91B3F9F");

                  //init artiles for site 01
                  Articles.Add(new ArticleEntity { CustomForSiteA = "custom 01", CustomForSiteB = "", Id = Guid.Parse("C8C9942D-F7CB-4B77-84D7-799B991AF585"), 
                        Sapo = "Mới đây, để kỷ niệm sinh nhật 1 tuổi, MG Việt Nam đã triển khai chương trình “Quà tưng bừng - Mừng sinh nhật lớn” với nhiều quà tặng hấp dẫn trong tháng 8 này",
                        Title = "MG Việt Nam triển khai chương trình “Quà tưng bừng - Mừng sinh nhật lớn” với nhiều quà tặng hấp dẫn", SiteId = siteId01, CategoryId= Guid.Parse("728A3FDF-29C9-47FA-A3AA-8BFC44B02458")
                  });
                  Articles.Add(new ArticleEntity {
                        CustomForSiteA = "custom 02", CustomForSiteB = "", Id = Guid.Parse("55CA475F-F2A6-4863-A51F-E8A1914FA0E9"),
                        Sapo = "Chỉ còn vài ngày nữa Hyundai Grand i10 thế hệ mới sẽ ra mắt người tiêu dùng trong nước. Những chiếc xe thuộc bản cũ đang được đại lý rao bán với giá từ 300 triệu đồng",
                        Title = "Chuẩn bị ra mắt thế hệ mới, Hyundai Grand i10 bản cũ được thanh lý với giá cực hời", SiteId = siteId01, CategoryId = Guid.Parse("728A3FDF-29C9-47FA-A3AA-8BFC44B02458")
                  });
                  Articles.Add(new ArticleEntity {
                        CustomForSiteA = "custom 03", CustomForSiteB = "", Id = Guid.Parse("0CCBB7FD-CA46-4AB8-BC61-012AA50665EB"),
                        Sapo = "Mitsubishi Motors Việt Nam (MMV) vừa công bố chương trình ưu đãi hỗ trợ 50% lệ phí trước bạ cùng hàng loạt quà tặng giá trị cho hàng loạt mẫu xe, trong đó có Mitsubishi Xpander",
                        Title = "MMV tung ưu đãi khủng tháng 8, Mitsubishi Xpander giảm 50% lệ phí trước bạ", SiteId = siteId01, CategoryId = Guid.Parse("15A298F0-17D8-454A-BFF1-BF2DDD49B029")
                  });


                  //init artiles for site 02
                  Articles.Add(new ArticleEntity {
                        CustomForSiteA = "", CustomForSiteB = "CCC", Id = Guid.Parse("1DDA4DE3-CD9B-48E2-B45E-66A57AD95CE8"),
                        Sapo = "Here it is, prancing around in the desert",
                        Title = "2022 Subaru WRX teaser renders fan service with manual gearbox", SiteId = siteId02, CategoryId = Guid.Parse("6D9D2283-C77D-4B3A-91C0-6073455F5788")
                  });
                  Articles.Add(new ArticleEntity {
                        CustomForSiteA = "", CustomForSiteB = "BBB", Id = Guid.Parse("95279CEB-87A7-46CF-A436-3B8A132205D9"),
                        Sapo = "This means its local launch should be soon enough.",
                        Title = "Next-gen 2022 Toyota Land Cruiser spotted on Philippine shores", SiteId = siteId02, CategoryId = Guid.Parse("6D9D2283-C77D-4B3A-91C0-6073455F5788")
                  });
                  Articles.Add(new ArticleEntity {
                        CustomForSiteA = "", CustomForSiteB = "AAA", Id = Guid.Parse("11B3AD5E-2373-4CE3-80FE-A0F8B6565017"),
                        Sapo = "The Chinese automaker also has some interesting models arriving soon.",
                        Title = "GAC PH can service non-GAC cars in its dealerships", SiteId = siteId02, CategoryId = Guid.Parse("B72355F6-CF8E-4FA2-9F5C-03538773FC36")
                  });

            }

            public Task<IEnumerable<ArticleEntity>> GetArticleBySite(Guid siteId) {
                  return Task.FromResult(Articles.Where(o => o.SiteId == siteId));
            }

            public Task<IEnumerable<ArticleEntity>> GetArticleByCategory(Guid categoryId) {
                  return Task.FromResult(Articles.Where(o => o.CategoryId == categoryId));
            }
      }
}
