using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsPublish.Model.Entity;
using NewsPublish.Model.Request;
using NewsPublish.Model.Response;
using NewsPublish.Service;


namespace NewsPublish.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private NewsService _newsServices;
        private IHostingEnvironment _host;
        public NewsController(NewsService newsService, IHostingEnvironment host)
        {
            this._newsServices = newsService;
            this._host = host;
        }
        public ActionResult Index()
        {
            var newClassifys = _newsServices.GetNewsClassifyList();
            return View(newClassifys);
        }
        [HttpGet]
        public JsonResult GetNews(int pageIndex, int PageSize, int classifyId, string keyword)
        {
            List<Expression<Func<News, bool>>> wheres = new List<Expression<Func<News, bool>>>();
            if (classifyId > 0)
            {
                wheres.Add(c => c.NewsClassifyId == classifyId);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                wheres.Add(c => c.Title.Contains(keyword));
            }
            int total = 0;
            var news = _newsServices.NewsPageQuery(PageSize, pageIndex, out total, wheres);
            return Json(new { total = total, data = news.data });
        }

        #region 新闻类别 
        public ActionResult NewsClassify()
        {
            var newClassifys = _newsServices.GetNewsClassifyList();
            return View(newClassifys);
        }


        public ActionResult NewsclassifyAdd()
        {

            return View();
        }

        [HttpPost]

        public JsonResult NewsclassifyAdd(AddNewsClassify newsClassify)
        {
            if (string.IsNullOrEmpty(newsClassify.Name))
                return Json(new ResponseModel { code = 0, result = "请输入新闻类别" });

            return Json(_newsServices.AddNewsClassify(newsClassify));
        }

        public ActionResult NewsClassifyEdit(int id)
        {
            return View(_newsServices.GetOneNewsClassify(id));
        }
        [HttpPost]
        public JsonResult NewsClassifyEdit(EditNewsClassify newsClassify)
        {
            if (string.IsNullOrEmpty(newsClassify.Name))
                return Json(new ResponseModel { code = 0, result = "请输入新闻类别" });

            return Json(_newsServices.EditNewsClassify(newsClassify));
        }
        #endregion


        #region 添加新闻
        public ActionResult NewsAdd()
        {
            var newClassifys = _newsServices.GetNewsClassifyList();
            return View(newClassifys);
        }

        [HttpPost]
        public async Task<JsonResult> AddNews(AddNews news, IFormCollection collection)
        {
            if (news.NewsClassifyId <= 0 || string.IsNullOrEmpty(news.Title) || string.IsNullOrEmpty(news.Contents))
                return Json(new ResponseModel { code = 0, result = "参数有误" });
            var files = collection.Files;
            if (files.Count > 0)
            {
                string webRootPath = _host.WebRootPath;
                string relativeDirPath = "\\NewsPic";
                string absolutePath = webRootPath + relativeDirPath;
                string[] fileTypes = new string[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".pdf" };//定义图片格式 
                string extension = Path.GetExtension(files[0].FileName); //获取文件后缀名
                if (fileTypes.Contains(extension.ToLower()))//判断上传的文件包含后缀名
                {
                    if (!Directory.Exists(absolutePath)) Directory.CreateDirectory(absolutePath);
                    string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + extension;
                    var filePath = absolutePath + "\\" + fileName;
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await files[0].CopyToAsync(stream);

                    }
                    news.Image = "/NewsPic/" + fileName;
                    return Json(_newsServices.AddNews(news));
                }
                return Json(new ResponseModel { code = 0, result = "图片格式有问题吗" });
            }
            return Json(new ResponseModel { code = 0, result = "请上传图片" });

        }
        #endregion



[HttpPost]
public JsonResult DelNews(int id)
        {
            if (id <= 0)
                return Json(new ResponseModel { code = 0, result = "新闻不存在" });
            return Json(_newsServices.DelOneNews(id));
        }






    }



}