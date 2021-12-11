using System.Collections.Generic;
using Blog.BusinessLayer.Abstract;
using Blog.CoreLayer.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Blog.EntityLayer.Concrete;
using Blog.EntityLayer.Dtos;
using Blog.Web.Models;

namespace Blog.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly ICommentService _commentService;
        private readonly IWriterService _writerService;


        public ArticleController(IArticleService articleService, ICategoryService categoryService, ICommentService commentService, IWriterService writerService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _commentService = commentService;
            _writerService = writerService;
        }

        public async Task<IActionResult> Detail(int articleId,int writerId)
        {
            var articleResult = await _articleService.GetAsync(articleId);
            var articlesResult = await _articleService.GetAllByViewCountAsync(isAscending: false, takeSize: 5); // Azalan bir sekilde 5 makale gelecek
            var categoriesResult = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            var commentsResult = await _commentService.GetAllAsync();
            var writerResult = await _writerService.GetAsync(writerId); 
            //if (articleResult.ResultStatus == ResultStatus.Success)
            //{
            //    return View(new ArticleDetailViewModel
            //    {
            //        ArticleDto = articleResult.Data,
            //        ArticleDetailRightSideBarViewModel = new ArticleDetailRightSideBarViewModel
            //        {
            //            Writer = articleResult.Data.Article.Writer
            //        }
            //    });
            //}
            //return NotFound();

            if (articleResult.ResultStatus == ResultStatus.Success)
            {
                //ArticleDetailVewModel
                return View(new ArticleDetailViewModel
                {
                    ArticleDto = articleResult.Data,
                    //ArticleDetailRightSideBarViewModel = new ArticleDetailRightSideBarViewModel
                    //{
                    //    Writer = articleResult.Data.Article.Writer
                    //},
                    WriterAboutModel = new WriterAboutModel
                    {
                        Writer = articleResult.Data.Article.Writer,
                        Header = ""
                    },
                    //ArticleListDto = new ArticleListDto()
                    WriterArticlesViewModel = new WriterArticlesViewModel
                    {
                        Articles = articlesResult.Data.Articles,
                        Categories = categoriesResult.Data.Categories
                    }
                });
            }

            return NotFound();

        }
    }
}
