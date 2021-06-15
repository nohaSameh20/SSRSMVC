using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSRSWithMVC.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            string ssUrl = ConfigurationManager.AppSettings["SSRSReportUrl"].ToString();
            ReportViewer viewer = new ReportViewer();
            viewer.ShowPrintButton = true;
            viewer.ProcessingMode = ProcessingMode.Remote;
            viewer.SizeToReportContent = true;
            viewer.AsyncRendering = true;
            viewer.ServerReport.ReportServerUrl = new Uri(ssUrl);
            viewer.ServerReport.ReportPath = "/UserReport";

            
            ViewBag.ReportViewer = viewer;
            return View();
        }
    }
}