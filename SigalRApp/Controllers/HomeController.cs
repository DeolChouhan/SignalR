using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SigalRApp.Models;

namespace SigalRApp.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult InsertData(DevTest model)
        {
            string msg="";
            try {
                using (DevTestContext context = new DevTestContext())
                {
                    if (model.ID > 0)
                    {
                        var data = context.DevTests.FirstOrDefault(d => d.ID == model.ID);
                        data.Clicks = model.Clicks;
                        data.AffiliateName = model.AffiliateName;
                        data.CampaignName = model.CampaignName;
                        data.Conversions = model.Conversions;
                        data.Date = model.Date;
                        data.Impressions = model.Impressions;
                    }
                    else
                    {
                        context.DevTests.Add(model);
                    
                    }
                    context.SaveChanges();
                    msg = "Data Saved Successfully..";
                }
                DevTestHub.NotifyCurrentDevInformationToAllClients();
            }
            catch(Exception cc)
            {
                msg = "Error Occur";
            
            }
            
            var jsonresult = new
            {
                msg = msg
            };
            return Json(jsonresult);
        }

        [HttpGet]
        public ActionResult GetAllData()
        {
            string msg = "";
            List<DevTest> list = new List<DevTest>();
            try
            {
                using (DevTestContext context = new DevTestContext())
                {
                    list = context.DevTests.ToList();
                }
            }
            catch (Exception cc)
            {
                msg = "Error Occur";

            }
            return PartialView("~/Views/Shared/_PartialAllData.cshtml", list);
        }

        [HttpPost]
        public JsonResult DeleteData(int id)
        {
            string msg = "";
            try
            {
                using (DevTestContext context = new DevTestContext())
                {
                    var data = context.DevTests.FirstOrDefault(d => d.ID == id);
                    context.DevTests.Remove(data);
                    context.SaveChanges();
                    msg = "Data Deleted Successfully..";
                }
                DevTestHub.NotifyCurrentDevInformationToAllClients();
            }
            catch (Exception cc)
            {
                msg = "Error Occur";

            }

            var jsonresult = new
            {
                msg = msg
            };
            return Json(jsonresult);
        }


        [HttpGet]
        public JsonResult GetDataById(int id)
        {
            string msg = "";
            string modelDate = "";
            DevTest model = new DevTest();
            try
            {
                using (DevTestContext context = new DevTestContext())
                {
                    model = context.DevTests.FirstOrDefault(d => d.ID == id);
                    modelDate = Convert.ToDateTime(model.Date).ToShortDateString();
                }
            }
            catch (Exception cc)
            {
                msg = "Error Occur";

            }

            var jsonresult = new
            {
                msg = msg,
                Result = model,
                modelDate=modelDate
            };
            return Json(jsonresult,JsonRequestBehavior.AllowGet);
        }

    }
}