﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
            BlogManager bm = new BlogManager(new EfBlogRepository());

            public IViewComponentResult Invoke(int id)
            {
                var values = bm.GetBlogListWithCategory();
                return View(values);
            }
    }
}
