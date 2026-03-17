#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using Syncfusion.EJ2.PivotView;
using EJ2MVCSampleBrowser.Models;


namespace EJ2MVCSampleBrowser.Controllers.PivotView
{
    public partial class PivotTableController : Controller
    {

        public ActionResult Overview()
        {
            var data = new UniversityData().ReadJSONData(HostingEnvironment.ApplicationPhysicalPath + "\\App_Data\\universitydata.json");
            ViewData["DataSource"] = data;
            ViewData["filterMembers"] = new string[] { "Africa", "Latin America" };
            ViewData["ExcludeFields"] = new string[] { "link", "logo" };
            return View();
        }
    }

    public class UniversityData
    {
        public string university { get; set; }
        public int year { get; set; }
        public int rank_display { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string type { get; set; }
        public string research_output { get; set; }
        public int? student_faculty_ratio { get; set; }
        public string international_students { get; set; }
        public string faculty_count { get; set; }
        public string link { get; set; }
        public string logo { get; set; }

        public List<UniversityData> ReadJSONData(string url)
        {
            WebClient myWebClient = new WebClient();
            Stream myStream = myWebClient.OpenRead(url);
            StreamReader stream = new StreamReader(myStream);
            string result = stream.ReadToEnd();
            stream.Close();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<UniversityData>>(result);
        }
    }
}
