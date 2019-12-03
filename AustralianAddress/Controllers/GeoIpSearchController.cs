using AustralianAddress.Models;
using AustralianAddress.Repositories.SearchService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace AustralianAddress.Controllers
{
    public class GeoIpSearchController : Controller
    {

        // GET: GeoIpSearch
        public ActionResult SearchForm()
        {

            return View();

        }
        [HttpPost]
        public JsonResult Search(SearchModel Obj)
        {
            AddressFilter getFilterResult = new AddressFilter();
            var filterResult = getFilterResult.FilterByKey(Obj.Key);
            if (filterResult!=null
                 && filterResult.Any())
            {
                return Json(
                    new
                    {
                        Status = true,
                        Total = filterResult?.Count(),
                        Result = filterResult                    
                    });
            }
            return Json(
                    new
                    {
                        Status = false
                    });
        }
    }
}