using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class BlogLanguageServices
    {
        private readonly AppDbContext _context;
       
        public BlogLanguageServices(AppDbContext context)
        {
            _context = context;
        }

        public List<BlogLanguage> GetAllBlogs()
        {
            var blogs = _context.BlogLanguages.Include(x=>x.Blog).Where(x=>x.LangCode == "AZ").ToList();
            return blogs;
        }

        public BlogLanguage GetBlogById(int? id,string langcode )
        {
            if (langcode == null)
            {
                langcode = "RU";
            }

            var blog = _context.BlogLanguages
                .Include(x=>x.Blog)

                .FirstOrDefault(x=>x.BlogId == id && x.LangCode == langcode);

            if(blog == null)
            {
                return null;
            }


            return blog;
        }
    }
}
