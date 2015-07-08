using System;
using Microsoft.AspNet.Mvc;

namespace HawkProto2
{
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly IPostRepository _repo;
        
        public CategoryListViewComponent(IPostRepository repo)
        {
            if (repo == null)
            {
                throw new ArgumentNullException(nameof(repo));
            }
            
            this._repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            return Content("CategoryListViewComponent");
        }
    }
}