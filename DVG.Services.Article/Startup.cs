using DVG.Services.Article.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DVG.Services.Article {
      public class Startup {
            public Startup(IConfiguration configuration) {
                  Configuration = configuration;
            }

            public IConfiguration Configuration { get; }

            // This method gets called by the runtime. Use this method to add services to the container.
            public void ConfigureServices(IServiceCollection services) {

                  services.AddSingleton<IArticleRepository, ArticleRepository>();

                  #region Api Versioning
                  services.AddApiVersioning(config => {
                        config.DefaultApiVersion = new ApiVersion(1, 0);
                        config.AssumeDefaultVersionWhenUnspecified = true;
                        config.ReportApiVersions = true;
                  });
                  services.AddVersionedApiExplorer(options => {
                        options.GroupNameFormat = "'v'VVV";
                        options.SubstituteApiVersionInUrl = true;
                  });
                  #endregion

                  services.AddControllers();
                  services.AddSwaggerGen(c => {
                        c.SwaggerDoc("v1", new OpenApiInfo { Title = "DVG.Services.Article", Version = "v1" });
                        c.SwaggerDoc("v2", new OpenApiInfo { Title = "DVG.Services.Article", Version = "v2" });
                        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                        c.IncludeXmlComments(xmlPath);
                  });
            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider) {
                  if (env.IsDevelopment()) {
                        app.UseDeveloperExceptionPage();
                        app.UseSwagger();
                        //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DVG.Services.Article v1"));
                        app.UseSwaggerUI(options => {
                              foreach (var description in provider.ApiVersionDescriptions) {
                                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
                              }
                        });
                  }

                  app.UseHttpsRedirection();

                  app.UseRouting();

                  app.UseAuthorization();

                  app.UseEndpoints(endpoints => {
                        endpoints.MapControllers();
                  });
            }
      }
}
