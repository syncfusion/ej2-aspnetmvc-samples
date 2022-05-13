#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
using System.Drawing;
using Syncfusion.XlsIO;
using System.Data;
using System.Dynamic;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: //Import JSON/

        public ActionResult ImportJSON(string SaveOption)
        {
            if (SaveOption == null)
                return View();
            string fileName = "ImportJSONTemplate.xlsx";
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
          
            //Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
            //After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath(fileName));
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];

            IEnumerable salesPersons = GetCustomDynamicObjects();

            //Import Dynamic Object to worksheet
            sheet.ImportData(salesPersons, 4, 1, true);
            
            try
            {
                //Saving the workbook to disk. This spreadsheet is the result of opening and modifying
                //an existing spreadsheet and then saving the result to a new workbook.

                if (SaveOption == "Xls")
                {
                    workbook.Version = ExcelVersion.Excel97to2003;
                    return excelEngine.SaveAsActionResult(workbook, "ImportJSON.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
                }
                else
                    return excelEngine.SaveAsActionResult(workbook, "ImportJSON.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
            }
            catch (Exception)
            {
            }

            //Close the workbook.
            workbook.Close();
            excelEngine.Dispose();
            return View();
        }
        # region Helpher Methods       
        /// <summary>
        /// Gets the Collection of customized dynamic objects from the JSON data.
        /// </summary>
        /// <returns>Collection of Customer Objects</returns>
        private IList<CustomDynamicObject> GetCustomDynamicObjects()
        {
            string jsonString = System.IO.File.ReadAllText(ResolveApplicationDataPath("salespersons.json"));
            JObject jsonObject = JObject.Parse(jsonString);
            List<CustomDynamicObject> customers = ((JArray)(jsonObject["SalesPersons"])).ToObject<List<CustomDynamicObject>>();
            return customers;
        }
        # endregion

        #region Helper Classes
        /// <summary>
        /// Custom dynamic object class
        /// </summary>
        public class CustomDynamicObject : DynamicObject
        {
            /// <summary>
            /// The dictionary property used store the data
            /// </summary>
            internal Dictionary<string, object> properties = new Dictionary<string, object>();
            /// <summary>
            /// Provides the implementation for operations that get member values.
            /// </summary>
            /// <param name="binder">Get Member Binder object</param>
            /// <param name="result">The result of the get operation.</param>
            /// <returns>true if the operation is successful; otherwise, false.</returns>
            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                result = default(object);

                if (properties.ContainsKey(binder.Name))
                {
                    result = properties[binder.Name];
                    return true;
                }
                return false;
            }
            /// <summary>
            /// Provides the implementation for operations that set member values.
            /// </summary>
            /// <param name="binder">Set memeber binder object</param>
            /// <param name="value">The value to set to the member</param>
            /// <returns>true if the operation is successful; otherwise, false.</returns>
            public override bool TrySetMember(SetMemberBinder binder, object value)
            {
                properties[binder.Name] = value;
                return true;
            }
            /// <summary>
            /// Return all dynamic member names
            /// </summary>
            /// <returns>the property name list</returns>
            public override IEnumerable<string> GetDynamicMemberNames()
            {
                return properties.Keys;
            }
        }
        #endregion
    }
}
