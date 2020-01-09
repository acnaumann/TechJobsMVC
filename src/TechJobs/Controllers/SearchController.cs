using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results

        //public IActionResult Results(string column, string value)
        //{
        //    List<Dictionary<string, string>> jobs = JobData.FindByColumnAndValue(column, value);
        //    ViewBag.title = "Jobs with " + ListController.columnChoices[column] + ": " + value;
        //    ViewBag.jobs = jobs; 
        //    return View();
        //}


    }
}
