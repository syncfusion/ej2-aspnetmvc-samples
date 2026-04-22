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

   public class Countries1
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Expanded { get; set; }
        public bool Selected { get; set; }
    }
   
    public class TreeviewHierarchical
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Expanded { get; set; }
       

        public List<Countries1> Child;

        public List<TreeviewHierarchical> getTreeviewHierarchicalModel()
        {
            List<TreeviewHierarchical> TreeviewHierarchical = new List<TreeviewHierarchical>();
            List<Countries1> Countries1 = new List<Countries1>();

            TreeviewHierarchical.Add(new TreeviewHierarchical
            {
                Code = "NA",
                Name = "North America",
                Expanded = true,
                Child = Countries1,
            });
            Countries1.Add(new Countries1 { Code = "USA", Name = "United States of America", Selected = true });
            Countries1.Add(new Countries1 { Code = "CUB", Name = "Cuba" });
            Countries1.Add(new Countries1 { Code = "MEX", Name = "Mexico" });
            List<Countries1> Countries2 = new List<Countries1>();
            TreeviewHierarchical.Add(new TreeviewHierarchical
            {
                Code = "AF",
                Name = "Africa",
                Child = Countries2,
            });
            Countries2.Add(new Countries1 { Code = "NGA", Name = "Nygeria" });
            Countries2.Add(new Countries1 { Code = "EGY", Name = "Egypt" });
            Countries2.Add(new Countries1 { Code = "ZAF", Name = "South Africa" });
            List<Countries1> Countries3 = new List<Countries1>();
            TreeviewHierarchical.Add(new TreeviewHierarchical
            {
                Code = "AS",
                Name = "Asia",
                Child = Countries3,
            });
            Countries3.Add(new Countries1 { Code = "CHN", Name = "China" });
            Countries3.Add(new Countries1 { Code = "IND", Name = "India" });
            Countries3.Add(new Countries1 { Code = "JPN", Name = "Japan" });
            List<Countries1> Countries4 = new List<Countries1>();
            TreeviewHierarchical.Add(new TreeviewHierarchical
            {
                Code = "EU",
                Name = "Europe",
                Child = Countries4,
            });
            Countries4.Add(new Countries1 { Code = "DNK", Name = "Denmark" });
            Countries4.Add(new Countries1 { Code = "FIN", Name = "Finland" });
            Countries4.Add(new Countries1 { Code = "AUT", Name = "Austria" });

            List<Countries1> Countries5 = new List<Countries1>();
            TreeviewHierarchical.Add(new TreeviewHierarchical
            {
                Code = "SA",
                Name = "South America",
                Child = Countries5,
            });
            Countries5.Add(new Countries1 { Code = "BRA", Name = "Brazil" });
            Countries5.Add(new Countries1 { Code = "COL", Name = "Colombia" });
            Countries5.Add(new Countries1 { Code = "ARG", Name = "Argentina" });

            List<Countries1> Countries6 = new List<Countries1>();
            TreeviewHierarchical.Add(new TreeviewHierarchical
            {
                Code = "OC",
                Name = "Oceania",
                Child = Countries6,
            });
            Countries6.Add(new Countries1 { Code = "AUS", Name = "Australia" });
            Countries6.Add(new Countries1 { Code = "NZL", Name = "Newzealand" });
            Countries6.Add(new Countries1 { Code = "WSM", Name = "Samoa" });

            List<Countries1> Countries7 = new List<Countries1>();
            TreeviewHierarchical.Add(new TreeviewHierarchical
            {
                Code = "AN",
                Name = "Antartica",
                Child = Countries7,
            });
            Countries7.Add(new Countries1 { Code = "BVT", Name = "Bouvet Island" });
            Countries7.Add(new Countries1 { Code = "ATF", Name = "French Southern Lands" });

            return TreeviewHierarchical;
        }


    }
   
}

