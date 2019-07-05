using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.ViewComponents
{
    //Either add attribute / extend the class with ViewComponent / name the class suffixing with ViewComponent 
    [ViewComponent]
    public class MonthlySpecialViewComponent : ViewComponent
    {
        private readonly BlogDataContext _db;

        public MonthlySpecialViewComponent(BlogDataContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var monthlySpecials = _db.MonthlySpecials.ToArray();
            return View(monthlySpecials);
        }
    }
}
