using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetElement.Web.Controllers
{
    /// <summary>
    /// Домашняя страница
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Информация о создателе
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            return View();
        }
    }
}