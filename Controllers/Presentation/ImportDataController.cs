#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
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

using Syncfusion.Presentation;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using System.Data;
using Syncfusion.OfficeChart;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PresentationController : Controller
    {
        //
        // GET: /ImportData/

        public ActionResult ImportData()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ImportData(string Browser)
        {
            //Gets the path of the Database
            string path = ResolveApplicationDataPath("DataBase.mdb");
            //Create a new instance of OleDbConnection
            OleDbConnection connection = new OleDbConnection();
            //Sets the string to open a Database
            connection.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Password=\"\";User ID=Admin;Data Source=" + path;
            //Opens the Database connection
            connection.Open();
            //Get all the data from the Database
            OleDbCommand query = new OleDbCommand("select * from StockData", connection);
            //Create a new instance of OleDbDataAdapter
            OleDbDataAdapter adapter = new OleDbDataAdapter(query);
            //Create a new instance of DataSet
            DataSet dataSet = new DataSet();
            //Adds rows in the Dataset
            adapter.Fill(dataSet);
            //Create a DataTable from the Dataset
            DataTable dataTable = dataSet.Tables[0];
            //Create a new instance of Presentation
            IPresentation presentation = Presentation.Create();
            //Set the number of rows to be present in the DataTable
            int RowsPerSlide = 5;
            List<DataTable> dataTables = SplitDataTable(dataTable, RowsPerSlide);
            int count = 1;
            //Export the data into the table of the Presentation
            foreach (DataTable splittedDataTable in dataTables)
            {
                //if the count of the splitted DataTable is equal to 1, then the data willl be imported as Table into the presentation
                if (count == 1)
                    ExportToPresentationSlide(presentation, splittedDataTable);
                //if the count of the splitted DataTable is greater than 1, then the data willl be imported as Chart into the presentation
                else
                    CreateChartFromDatatable(presentation, splittedDataTable);
                count++;
            }
            //Dispose all the resources
            connection.Close();
            connection.Dispose();
            query.Dispose();
            adapter.Dispose();
            dataSet.Dispose();
            return new PresentationResult(presentation, "Imported.pptx", HttpContext.ApplicationInstance.Response);

        }
        /// <summary>
        /// Exports the Data as table to the PowerPoint Slide
        /// </summary>
        /// <param name="presentation">The PowerPoint presentation instance</param>
        /// <param name="dataTable">The table which has the data</param>
        private static void ExportToPresentationSlide(IPresentation presentation, DataTable dataTable)
        {
            //Get a slide from presentation.
            ISlide slide = presentation.Slides.Add(SlideLayoutType.Blank);
            //Add table to the slide. 
            ITable table = slide.Tables.AddTable(dataTable.Rows.Count, dataTable.Columns.Count, 200, 200, 500.2, 165.36);
            //Disable the header row property
            table.HasHeaderRow = true;
            int rowIndex = 0;
            int colIndex = 0;
            //Add data to the table in presentation from the DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (object val in row.ItemArray)
                {
                    ICell cell = table[rowIndex, colIndex];
                    cell.TextBody.AddParagraph(val.ToString());
                    colIndex++;
                }
                colIndex = 0;
                rowIndex++;
            }
        }
        /// <summary>
        /// Split the table accoding to the number of rows
        /// </summary>
        /// <param name="tableToSplit">The table to be splitted</param>
        /// <param name="countLimit">The number of rows needed in splitted table</param>
        /// <returns>The splitted table</returns>
        private static List<DataTable> SplitDataTable(DataTable tableToSplit, int countLimit)
        {
            List<DataTable> tables = new List<DataTable>();
            int count = 0;
            DataTable copyTable = null;
            foreach (DataRow dr in tableToSplit.Rows)
            {
                if (count == 0 || count == countLimit)
                {
                    //Initialize a new instance of Datatable.
                    copyTable = new DataTable();
                    // Clone the structure of the table.
                    copyTable = tableToSplit.Clone();
                    // Add the new DataTable to the list.
                    tables.Add(copyTable);
                }
                // Import the current row.
                copyTable.ImportRow(dr);
                count++;
            }
            return tables;
        }

        /// <summary>
        /// Exports the tables and charts to the PowerPoint Slide
        /// </summary>
        /// <param name="presentation">The PowerPoint presnetation to export the charts and tables</param>
        /// <param name="dataTable">The table which has the data</param>
        private static void CreateChartFromDatatable(IPresentation pptxDoc, DataTable dataTable)
        {
            //Get the first slide in the PowerPoint presentation
            ISlide slide = pptxDoc.Slides.Add(SlideLayoutType.Blank);
            //Create a chart and add to the slide
            IPresentationChart chart = slide.Charts.AddChart(100, 10, 700, 500);
            int rowIndex = 1;
            int colIndex = 1;
            //Add data to the table in presentation from the DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (object val in row.ItemArray)
                {
                    string value = val.ToString();
                    chart.ChartData.SetValue(rowIndex, colIndex, value);
                    colIndex++;
                }
                colIndex = 1;
                rowIndex++;
            }
            //Creates a new chart series with the name
            IOfficeChartSerie openPrice = chart.Series.Add("Open Price");

            //Sets the data range of chart series – start row, start column, end row, end column
            openPrice.Values = chart.ChartData[2, 2, 5, 2];

            //Creates a new chart series with the name
            IOfficeChartSerie highPrice = chart.Series.Add("High Price");

            //Sets the data range of chart series – start row, start column, end row, end column
            highPrice.Values = chart.ChartData[2, 3, 5, 3];

            //Creates a new chart series with the name
            IOfficeChartSerie lowPrice = chart.Series.Add("Low Price");

            //Sets the data range of chart series – start row, start column, end row, end column
            lowPrice.Values = chart.ChartData[2, 4, 5, 4];

            //Sets the data range of the category axis
            chart.PrimaryCategoryAxis.CategoryLabels = chart.ChartData[2, 1, 5, 1];

            //Specifies the chart type
            chart.ChartType = OfficeChartType.Column_Clustered;

            //Set the title for the chart
            chart.ChartTitle = "Sales Report";
        }
    }
}
