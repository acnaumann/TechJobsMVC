﻿using System.Collections.Generic;
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

        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.columns = ListController.columnChoices;

            if (searchType.Equals("all")) 
            {
                if (searchTerm == null || searchTerm == "")
                {
                    List<Dictionary<string, string>> jobs = JobData.FindAll();
                    //ViewBag.title = "All Jobs"; 
                    ViewBag.jobs = jobs;
                    return View("Index");
                }
                else
                {
                    List<Dictionary<string, string>> jobs = JobData.FindByValue(searchTerm);
                    //ViewBag.title = "Jobs with " + ListController.columnChoices[searchType] + ": " + searchTerm;
                    ViewBag.jobs = jobs;
                    return View("Index");
                }
                
            }
            else if (searchTerm == null || searchTerm == "")  //string.IsNullOrEmpty(searchTerm)
            {
                return View("Index");
            }
            else
            {
                
                List<Dictionary<string, string>> jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
                //ViewBag.title = "Jobs with " + ListController.columnChoices[searchType] + ": " + searchTerm;
                ViewBag.jobs = jobs;
                return View("Index");
            }
            
        }


    }
}
