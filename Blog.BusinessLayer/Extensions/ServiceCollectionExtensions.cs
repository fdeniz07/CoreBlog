using Blog.BusinessLayer.Abstract;
using Blog.BusinessLayer.Concrete;
using Blog.DataAccessLayer.Abstract.UnitOfWorks;
using Blog.DataAccessLayer.Concrete.EntityFramework.Contexts;
using Blog.DataAccessLayer.Concrete.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.BusinessLayer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<MsDbContext>(); // Context'imizi kayit ediyoruz. Aslinda bu yapi da bir Scope'dur.
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService,ArticleManager>();
            serviceCollection.AddScoped<ICommentService,CommentManager>(); // ICommentService istendiginde ona, CommentManager gönderecegiz.

            #region Scope Nedir?
            /*
             * Yapilan her request'te nesne tekrar olusur ve bir request icerisinde sadece bir tane nesne kullanilir. Bu yöntem icin de AddScope() metodu kullaniliyor.
             * Transient ve Scoped kullanim sekilleri nesne olusturma zamanlari acisindan biraz karistirilabilir. Transient'da her nesne cagrimindan yeni bir instance olusur
             * ve o request sonlanana kadar ayni nesne kullanilir. Request bazinda stateless nesne kullanilmasi istenen durumlarda Scoped bagimliliklari olusturabiliriz.
             *
             * Kaynak : http://umutluoglu.com/2017/01/asp-net-core-dependency-injection/
             */
            #endregion

            return serviceCollection;
        }
    }
}
