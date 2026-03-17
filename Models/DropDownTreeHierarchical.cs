#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Models
{

   public class Countries2
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Expanded { get; set; }
    }
   
    public class DropDownTreeHierarchical
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Expanded { get; set; }
       

        public List<Countries2> Child;

        public List<DropDownTreeHierarchical> getDropDownTreeHierarchical()
        {
            List<DropDownTreeHierarchical> DropDownTreeHierarchical = new List<DropDownTreeHierarchical>();
            List<Countries2> Countries1 = new List<Countries2>();

            DropDownTreeHierarchical.Add(new DropDownTreeHierarchical
            {
                Code = "NA",
                Name = "North America",
                Expanded = true,
                Child = Countries1,
            });
            Countries1.Add(new Countries2 { Code = "USA", Name = "United States of America"});
            Countries1.Add(new Countries2 { Code = "CUB", Name = "Cuba" });
            Countries1.Add(new Countries2 { Code = "MEX", Name = "Mexico" });
            List<Countries2> Countries2 = new List<Countries2>();
            DropDownTreeHierarchical.Add(new DropDownTreeHierarchical
            {
                Code = "AF",
                Name = "Africa",
                Child = Countries2,
            });
            Countries2.Add(new Countries2 { Code = "NGA", Name = "Nygeria" });
            Countries2.Add(new Countries2 { Code = "EGY", Name = "Egypt" });
            Countries2.Add(new Countries2 { Code = "ZAF", Name = "South Africa" });
            List<Countries2> Countries3 = new List<Countries2>();
            DropDownTreeHierarchical.Add(new DropDownTreeHierarchical
            {
                Code = "AS",
                Name = "Asia",
                Child = Countries3,
            });
            Countries3.Add(new Countries2 { Code = "CHN", Name = "China" });
            Countries3.Add(new Countries2 { Code = "IND", Name = "India" });
            Countries3.Add(new Countries2 { Code = "JPN", Name = "Japan" });
            List<Countries2> Countries4 = new List<Countries2>();
            DropDownTreeHierarchical.Add(new DropDownTreeHierarchical
            {
                Code = "EU",
                Name = "Europe",
                Child = Countries4,
            });
            Countries4.Add(new Countries2 { Code = "DNK", Name = "Denmark" });
            Countries4.Add(new Countries2 { Code = "FIN", Name = "Finland" });
            Countries4.Add(new Countries2 { Code = "AUT", Name = "Austria" });

            List<Countries2> Countries5 = new List<Countries2>();
            DropDownTreeHierarchical.Add(new DropDownTreeHierarchical
            {
                Code = "SA",
                Name = "South America",
                Child = Countries5,
            });
            Countries5.Add(new Countries2 { Code = "BRA", Name = "Brazil" });
            Countries5.Add(new Countries2 { Code = "COL", Name = "Colombia" });
            Countries5.Add(new Countries2 { Code = "ARG", Name = "Argentina" });

            List<Countries2> Countries6 = new List<Countries2>();
            DropDownTreeHierarchical.Add(new DropDownTreeHierarchical
            {
                Code = "OC",
                Name = "Oceania",
                Child = Countries6,
            });
            Countries6.Add(new Countries2 { Code = "AUS", Name = "Australia" });
            Countries6.Add(new Countries2 { Code = "NZL", Name = "Newzealand" });
            Countries6.Add(new Countries2 { Code = "WSM", Name = "Samoa" });

            List<Countries2> Countries7 = new List<Countries2>();
            DropDownTreeHierarchical.Add(new DropDownTreeHierarchical
            {
                Code = "AN",
                Name = "Antartica",
                Child = Countries7,
            });
            Countries7.Add(new Countries2 { Code = "BVT", Name = "Bouvet Island" });
            Countries7.Add(new Countries2 { Code = "ATF", Name = "French Southern Lands" });

            return DropDownTreeHierarchical;
        }
    }  
}

