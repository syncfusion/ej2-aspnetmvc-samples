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
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Sparkline
{
    public partial class SparklineController : Controller
    {
        // GET: Axisvalue
        public ActionResult Axisvalue()
        {
            ViewData["datetime"] = DataSource.GetDatetimeData();
            ViewData["category"] = DataSource.GetCategoryData();
            ViewData["numeric"] = DataSource.GetNumericData();
            return View();
        }

        public class DataSource
        {
            public DateTime xDate;
            public double yval;
            public int x;
            public string xval;

            public static List<DataSource> GetDatetimeData()
            {
                List<DataSource> data1 = new List<DataSource>();
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 1), yval = 4  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 2), yval = 4.5 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 3), yval = 8  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 4), yval = 7  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 5), yval = 6  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 8), yval = 8  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 9), yval = 8  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 10),yval = 6.5 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 11),yval = 4  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 12),yval = 5.5 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 15),yval =  8 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 16),yval =  6 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 17),yval =  6.5 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 18),yval =  7.5 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 19),yval =  7.5 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 22),yval =  4 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 23),yval =  8 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 24),yval =  6 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 25),yval =  7.5 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 26),yval =  4.5 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 29),yval =  6 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 30),yval =  5 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 31),yval = 7 });
                return data1;                
            }

            public static List<DataSource> GetCategoryData()
            {
                List<DataSource> data2 = new List<DataSource>();
                data2.Add(new DataSource() { xval = "Robert" , yval = 60});
                data2.Add(new DataSource() { xval = "Andrew", yval = 65 });
                data2.Add(new DataSource() { xval = "Suyama", yval = 70 });
                data2.Add(new DataSource() { xval = "Michael", yval = 80 });
                data2.Add(new DataSource() { xval = "Janet", yval = 55 });
                data2.Add(new DataSource() { xval = "Davolio", yval = 90 });
                data2.Add(new DataSource() { xval = "Fuller", yval = 75 });
                data2.Add(new DataSource() { xval = "Nancy", yval = 85 });
                data2.Add(new DataSource() { xval = "Margaret", yval = 77 });
                data2.Add(new DataSource() { xval = "Steven", yval = 68 });
                data2.Add(new DataSource() { xval = "Laura", yval = 96 });
                data2.Add(new DataSource() { xval = "Elizabeth", yval = 57 });
                return data2;
            }

            public static List<DataSource> GetNumericData()
            {
                List<DataSource> data3 = new List<DataSource>();
                data3.Add(new DataSource() { x = 1, yval = 190});
                data3.Add(new DataSource() { x = 2, yval = 165});
                data3.Add(new DataSource() { x = 3, yval = 158});
                data3.Add(new DataSource() { x = 4, yval = 175});
                data3.Add(new DataSource() { x = 5, yval = 200});
                data3.Add(new DataSource() { x = 6, yval = 180});
                data3.Add(new DataSource() { x = 7, yval = 210});
                return data3;
            }
        }
    }
}