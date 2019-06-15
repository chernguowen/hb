using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPublish.Model.Request;
using NewsPublish.Model.Response;
using NewsPublish.Service;
using NewsPublish.Web.Models;

namespace NewsPublish.Web.Controllers
{

    public class NewsController : Controller
    {

        private NewsService _newService;
        private BannerService _bannerService;
        private CommentService _commentService;

        public NewsController(NewsService newsService, BannerService bannerService, CommentService commentService)
        {
            this._bannerService = bannerService;
            this._newService = newsService;
            this._commentService = commentService;
        }

        //新闻分类页
        public IActionResult Classify(int id)
        {
            if (id <= 0)
            {
                Response.Redirect("/Home/Index");
            }
            var classify = _newService.GetOneNewsClassify(id);
            ViewData["ClassifyName"] = "首页";
            ViewData["NewsList"] = new ResponseModel();
            ViewData["newCommentNews"] = new ResponseModel();
            ViewData["Title"] = "首页";
            if (classify.code == 0)
            {
                Response.Redirect("/Home/Index");
            }
            else
            {
                ViewData["ClassifyName"] = classify.data.Name;
                var newsList = _newService.GetNewsList(c => c.NewsClassifyId == id, 100);
                ViewData["NewsList"] = newsList;
                var newCommentNews = _newService.GetNewCommentNewsList(c => c.NewsClassifyId == id, 6);
                ViewData["newCommentNews"] = newCommentNews;
                ViewData["Title"] = classify.data.Name;
            }
            return View(_newService.GetNewsClassifyList());
        }


        //新闻详情页
        public IActionResult Detail(int id)
        {
            ViewData["Title"] = "详情页";
            if (id < 0)
            {
                Response.Redirect("/Home/Index");
            }
            var news = _newService.GetoneNews(id);
            ViewData["News"] = new ResponseModel();
            ViewData["RecommendNews"] = new ResponseModel();
            ViewData["Comments"] = new ResponseModel();
            if (news.code == 0)
            {
                Response.Redirect("/Home/Index");
            }
            else
            {
                ViewData["Title"] = news.data.Title;
                ViewData["News"] = news;
                var recommendNews = _newService.GetRecommentNewsList(id);
                ViewData["RecommendNews"] = recommendNews;
                var comments = _commentService.GetCommentList(c => c.NewsId == id);
                ViewData["Comments"] = comments;
            }
            return View(_newService.GetNewsClassifyList());
        }
        [HttpPost]
        public JsonResult AddComment(AddComments comment)
        {
            if (comment.NewsId <= 0)
            {
                return Json(new ResponseModel { code = 0, result = "新闻不存在" });
            }
            if (string.IsNullOrEmpty(comment.Contents))
            {
                return Json(new ResponseModel { code = 0, result = "新闻不存在" });
            }
            return Json(_commentService.AddComments(comment));
        }




    }
}