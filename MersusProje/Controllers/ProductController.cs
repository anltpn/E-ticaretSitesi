﻿
using MersusProjeCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MersusProje.Controllers
{
    public class ProductController : AndControllerBase
    {
        // GET: Product
        [Route("Urun/{title}/{id}")]
        public ActionResult Detail(string title, int id)
        {
            var db = new AndDB();
            var prod = db.Products.Where(x => x.ID == id).FirstOrDefault();
            return View(prod);
        }
    }
}