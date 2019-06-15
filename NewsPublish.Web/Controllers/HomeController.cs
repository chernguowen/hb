using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPublish.Model.Response;
using NewsPublish.Service;
using NewsPublish.Web.Models;

namespace NewsPublish.Web.Controllers
{
    public class HomeController : Controller
    {
        private NewsService _newService;
        private BannerService _bannerService;

        public HomeController(NewsService newsService, BannerService bannerService)
        {
            this._bannerService = bannerService;
            this._newService = newsService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "首页";
            return View(_newService.GetNewsClassifyList());
        }

        //获取banner
        [HttpGet]
        public JsonResult GetBanner()
        {
            return Json(_bannerService.GetBannerList());
        }
        //获取新闻总数
        [HttpGet]
        public JsonResult GetTotalNews()
        {
            return Json(_newService.GetNewsCount(c => true));
        }
        //获取首页新闻
        [HttpGet]
        public JsonResult GetHomeNews()

        {
            return Json(_newService.GetNewsList(c => true, 6));
        }

        //获取最新评论的新闻
        [HttpGet]
        public JsonResult GetNewCommentNewsList()
        {
            return Json(_newService.GetNewCommentNewsList(c => true, 5));
        }
        //搜索新闻
        [HttpGet]
        public JsonResult SearchOneNews(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
                return Json(new ResponseModel { code = 0, result = "请输入关键字" });
            return Json(_newService.GetSearchOneNews(c => c.Title.Contains(keyword)));

        }

        public ActionResult Wrong()
        {
            ViewData["Title"] = "404";
            return View(_newService.GetNewsClassifyList());
        }





    }
}
