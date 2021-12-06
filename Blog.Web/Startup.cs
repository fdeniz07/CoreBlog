using Blog.BusinessLayer.AutoMapper.Profiles;
using Blog.BusinessLayer.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Blog.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation(); // Sen bir MVC uygulamasisin. / RazorRuntimeCompilation ile bircok kodu derlemeden calistirabiliriz.
            services.LoadMyService();
            services.AddAutoMapper(typeof(CategoryProfile), typeof(ArticleProfile), typeof(CommentProfile)); //Derlenme sirasinda Automapper in buradaki siniflari taramasi saglaniyor.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages(); // Gelistirme ortamindayken, Sayfa bulunmadiginda 404 hata sayfasina yönlendirecektir
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles(); // static dosyalarimiz: resim,css,js vb
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");

                //Admin Area icerisinde yapilacak islemlerin yolu
                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                );

                //Eger bizim baska area alanimiz varsa yukaridaki pattern :  "{area=User}/{controller=Home}/{action=Index}/{id?}" gibi


                //Site icerisinde gezinirken yönlendirme ayarlari
                endpoints.MapControllerRoute(
                    name: "article",
                    pattern: "{title}/{articleId}", //"{categoryName}/{title}/{articleId}",
                    defaults: new { controller = "Article", action = "Detail" }
                );

                endpoints.MapDefaultControllerRoute(); // Bu islem varsayilan olarak, sitemiz acildigindan default olarak HomeController ve Index kismina gider
            });
        }
    }
}
