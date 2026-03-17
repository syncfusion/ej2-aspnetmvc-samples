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
        // GET: Default
        public ActionResult Default()
        {
            ViewData["datasource"] = PopulationData.GetData();
            return View();
        }
    }
    public class PopulationData
    {
        public int x;
        public string xval;
        public double yval;
        public double yval1;
        public double yval2;
        public double yval3;
        public double yval4;
        public double yval5;
        public double yval6;
        public double yval7;
        public double yval8;
        public double yval9, yval10, yval11, yval12, yval13, yval14, yval15, yval16, yval17, yval18, yval19, yval20,
            yval21, yval22, yval23, yval24, yval25, yval26, yval27, yval28, yval29,
            yval30, yval31, yval32, yval33, yval34, yval35, yval36, yval37, yval38, yval39;
        public static List<PopulationData> GetData()
        {
            List<PopulationData> population = new List<PopulationData>();
            population.Add(new PopulationData() { x = 0, xval = "2005", yval = 20090440, yval1 = 32805040, yval2 = 1306314000, yval3 = 60656180, yval4= 82431390, yval5 = 1080264000, yval6 = 143420300, yval7 = 9001774, yval8 = 60441460, yval9 = 295734100, yval10 = 2.61, yval11 = 3.29, yval12 = 136.12, yval13 = 110.88, yval14 = 230.89, yval15 = 328.59, yval16 = 328.59, yval17 = 20.01, yval18 = 246.88, yval19 = 30.71, yval20 = 1 , yval21 = 1 , yval22 = 1 , yval23 = 1 , yval24 = 0 , yval25 = 1 , yval26 = 1 , yval27 =  1 , yval28 = 1 , yval29 = 1 , yval30 = 12.26, yval31 = 10.84, yval32 = 13.14, yval33 = 12.15, yval34 = 8.33, yval35 = 22.32, yval36 = 9.8  , yval37 = 10.36, yval38 = 10.78, yval39 = 14.14 });
            population.Add(new PopulationData() { x = 1, xval = "2006", yval = 20264080, yval1 = 33098930, yval2 = 1313974000, yval3 = 60876140, yval4= 82422300, yval5 = 1095352000, yval6 = 142893500, yval7 = 9016596, yval8 = 60609150, yval9 = 298444200, yval10 = 2.64, yval11 = 3.31, yval12 = 136.92, yval13 = 111.28, yval14 = 230.86, yval15 = 333.18, yval16 = 333.18, yval17 = 20.04, yval18 = 247.57, yval19 = 30.99, yval20 = -1, yval21 = -1, yval22 = 1 , yval23 = -1, yval24 = 1 , yval25 = -1, yval26 = 0 , yval27 =  -1, yval28 = 0 , yval29 = -1, yval30 = 12.14, yval31 = 10.78, yval32 = 13.25, yval33 = 11.99, yval34 = 8.25, yval35 = 22.01, yval36 = 9.95 , yval37 = 10.27, yval38 = 10.71, yval39 = 14.14 });
            population.Add(new PopulationData() { x = 2, xval = "2007", yval = 20434180, yval1 = 33390140, yval2 = 1321852000, yval3 = 63713930, yval4= 82400990, yval5 = 1129866000, yval6 = 141377800, yval7 = 9031088, yval8 = 60776240, yval9 = 301139900, yval10 = 2.66, yval11 = 3.34, yval12 = 137.74, yval13 = 99.02 , yval14 = 230.8 , yval15 = 343.68, yval16 = 343.68, yval17 = 20.07, yval18 = 248.25, yval19 = 30.65, yval20 = -1, yval21 = -1, yval22 = 1 , yval23 = 1 , yval24 = -1, yval25 = 1 , yval26 = -1, yval27 =  0 , yval28 = 0 , yval29 = -1, yval30 = 12.02, yval31 = 10.75, yval32 = 13.45, yval33 = 12.91, yval34 = 8.2 , yval35 = 22.69, yval36 = 10.92, yval37 = 10.2 , yval38 = 10.67, yval39 = 14.16 });
            population.Add(new PopulationData() { x = 3, xval = "2008", yval = 21007310, yval1 = 33212700, yval2 = 1330045000, yval3 = 64057790, yval4= 82369550, yval5 = 1147996000, yval6 = 140702100, yval7 = 9045389, yval8 = 60943910, yval9 = 303824600, yval10 = 2.73, yval11 = 3.33, yval12 = 138.59, yval13 = 99.56 , yval14 = 230.71, yval15 = 349.19, yval16 = 349.19, yval17 = 20.1 , yval18 = 248.93, yval19 = 30.92, yval20 = 1 , yval21 = -1, yval22 = 1 , yval23 = -1, yval24 = -1, yval25 = -1, yval26 = 1 , yval27 =  0 , yval28 = 0 , yval29 = -1, yval30 = 12.55, yval31 = 10.29, yval32 = 13.71, yval33 = 12.73, yval34 = 8.18, yval35 = 22.22, yval36 = 11.03, yval37 = 10.15, yval38 = 10.65, yval39 = 14.18 });
            population.Add(new PopulationData() { x = 4, xval = "2009", yval = 21262640, yval1 = 33487210, yval2 = 1338613000, yval3 = 64057790, yval4= 82329760, yval5 = 1166079000, yval6 = 140041200, yval7 = 9059651, yval8 = 61113200, yval9 = 307212100, yval10 = 2.75, yval11 = 3.35, yval12 = 139.48, yval13 = 99.56 , yval14 = 230.6 , yval15 = 354.73, yval16 = 354.73, yval17 = 20.12, yval18 = 250.86, yval19 = 31.26, yval20 = -1, yval21 = -1, yval22 = 1 , yval23 = -1, yval24 = -1, yval25 = -1, yval26 = 0 , yval27 =  0 , yval28 = 0 , yval29 = 1 , yval30 = 12.47, yval31 = 10.28, yval32 = 14   , yval33 = 12.57, yval34 = 8.18, yval35 = 21.76, yval36 = 11.1 , yval37 = 10.13, yval38 = 10.65, yval39 = 13.82 });
            population.Add(new PopulationData() { x = 5, xval = "2010", yval = 21515750, yval1 = 33759740, yval2 = 1330141000, yval3 = 64768390, yval4= 82282990, yval5 = 1173108000, yval6 = 139390200, yval7 = 9074055, yval8 = 62348450, yval9 = 310232900, yval10 = 2.78, yval11 = 3.38, yval12 = 138.6 , yval13 = 100.66, yval14 = 230.47, yval15 = 356.86, yval16 = 356.86, yval17 = 20.15, yval18 = 255.94, yval19 = 31.57, yval20 = -1, yval21 = -1, yval22 = -1, yval23 = -1, yval24 = -1, yval25 = -1, yval26 = 0 , yval27 =  0 , yval28 = 1 , yval29 = -1, yval30 = 12.39, yval31 = 10.28, yval32 = 12.17, yval33 = 12.43, yval34 = 8.21, yval35 = 21.34, yval36 = 11.11, yval37 = 10.14, yval38 = 12.34, yval39 = 13.83 });
            population.Add(new PopulationData() { x = 6, xval = "2011", yval = 21766710, yval1 = 34030590, yval2 = 1336718000, yval3 = 65312250, yval4= 81471830, yval5 = 1189173000, yval6 = 138739900, yval7 = 9074055, yval8 = 62698360, yval9 = 313232000, yval10 = 2.81, yval11 = 3.41, yval12 = 139.29, yval13 = 101.45, yval14 = 228.2 , yval15 = 361.75, yval16 = 361.75, yval17 = 20.18, yval18 = 257.37, yval19 = 31.88, yval20 = -1, yval21 = -1, yval22 = 0 , yval23 = -1, yval24 = 1 , yval25 = -1, yval26 = 0 , yval27 =  0 , yval28 = 0 , yval29 = -1, yval30 = 12.33, yval31 = 10.28, yval32 = 12.29, yval33 = 12.29, yval34 = 8.3 , yval35 = 20.97, yval36 = 11.05, yval37 = 10.18, yval38 = 12.29, yval39 = 13.83 });
            population.Add(new PopulationData() { x = 7, xval = "2012", yval = 22015580, yval1 = 34300080, yval2 = 1343240000, yval3 = 65630690, yval4= 81305860, yval5 = 1205074000, yval6 = 142517700, yval7 = 9103788, yval8 = 63047160, yval9 = 313847500, yval10 = 2.84, yval11 = 3.44, yval12 = 139.97, yval13 = 101.94, yval14 = 227.73, yval15 = 366.59, yval16 = 366.59, yval17 = 20.22, yval18 = 258.8 , yval19 = 31.94, yval20 = -1, yval21 = -1, yval22 = -1, yval23 = 0 , yval24 = 1 , yval25 = -1, yval26 = -1, yval27 =  1 , yval28 = -1, yval29 = -1, yval30 = 12.28, yval31 = 10.28, yval32 = 12.31, yval33 = 12.72, yval34 = 8.33, yval35 = 20.6 , yval36 = 10.94, yval37 = 10.24, yval38 = 12.27, yval39 = 13.68 });
            population.Add(new PopulationData() { x = 8, xval = "2013", yval = 22262500, yval1 = 34568210, yval2 = 1349586000, yval3 = 65951610, yval4= 81147260, yval5 = 1220800000, yval6 = 142500500, yval7 = 9119423, yval8 = 63395580, yval9 = 316668600, yval10 = 2.88, yval11 = 3.46, yval12 = 140.63, yval13 = 102.44, yval14 = 227.29, yval15 = 371.37, yval16 = 371.37, yval17 = 20.25, yval18 = 260.23, yval19 = 32.23, yval20 = -1, yval21 = -1, yval22 = -1, yval23 = -1, yval24 = 1 , yval25 = -1, yval26 = 1 , yval27 =  1 , yval28 = 0 , yval29 = -1, yval30 = 12.23, yval31 = 10.28, yval32 = 12.25, yval33 = 12.6 , yval34 = 8.37, yval35 = 20.24, yval36 = 12.11, yval37 = 10.33, yval38 = 12.26, yval39 = 13.66 });
            population.Add(new PopulationData() { x = 9, xval = "2014", yval = 22507620, yval1 = 34834840, yval2 = 1355693000, yval3 = 66259010, yval4= 80996690, yval5 = 1236345000, yval6 = 142470300, yval7 = 9723809, yval8 = 63742980, yval9 = 318892100, yval10 = 2.91, yval11 = 3.49, yval12 = 141.26, yval13 = 102.92, yval14 = 226.87, yval15 = 376.1 , yval16 = 376.1 , yval17 = 21.59, yval18 = 261.66, yval19 = 32.45, yval20 = -1, yval21 = -1, yval22 = -1, yval23 = -1, yval24 = 1 , yval25 = -1, yval26 = -1, yval27 =  1 , yval28 = -1, yval29 = -1, yval30 = 12.19, yval31 = 10.29, yval32 = 12.17, yval33 = 12.6 , yval34 = 8.42, yval35 = 19.89, yval36 = 11.87, yval37 = 11.92, yval38 = 12.22, yval39 = 13.42 });
            return population;
        }                                         
        
    }
}