using Google.Apis.Customsearch.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace searchEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    [HttpPost]
        public ActionResult GoogleSearch()
        {
            const string apiKey = "Your ApiKey";
            const string searchEngineId = "003470263288780838160:ty47piyybua";
            string query = Request.Form["query"];
            CustomsearchService customSearchService = new CustomsearchService(new Google.Apis.Services.BaseClientService.Initializer() { ApiKey = apiKey });
            Google.Apis.Customsearch.v1.CseResource.ListRequest listRequest = customSearchService.Cse.List(query);
            listRequest.Cx = searchEngineId;
            var search = listRequest.Execute();
            ViewBag.Message = search;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       /* [HttpPost]
        public ActionResult Index()
        {
            ViewBag.Title = "test";
            return RedirectToAction("index");
            
        }*/
    }
}