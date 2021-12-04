﻿using Blog.CoreLayer.DataAccess.Abstract;
using Blog.EntityLayer.Concrete;

namespace Blog.DataAccessLayer.Abstract.Repositories
{
    public interface IArticleRepository : IEntityRepository<Article>
    {
    
    }
}
