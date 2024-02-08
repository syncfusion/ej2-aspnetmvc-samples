#region Copyright
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Collections;
using System.Xml;
using System.IO;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region  EmployeeReport
        public ActionResult NestedMailMerge(string Group1, string Group2, string Group3, string Button)
        {
            if (Group1 == null || Group2 == null || Group3 == null)
                return View();
            if (Button == "View Template")
            {
                if (Group2 == "Report")
                    return new TemplateResult("Template_Report.doc", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);
                else
                    return new TemplateResult("Template_Letter.doc", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);
            }
            string dataPath = string.Empty;
            if (Group2 == "Report")
                dataPath = ResolveApplicationDataPath("Template_Report.doc", "Data\\Word");
            else
                dataPath = ResolveApplicationDataPath("Template_Letter.doc", "Data\\Word");
            // Creating a new document.
            WordDocument document = new WordDocument();
            // Load template
            document.Open(dataPath, FormatType.Doc);

            if (Group3 == "Explicit")
            {
                DataSet ds = new DataSet();
                ds.ReadXml(ResolveApplicationDataPath("Employees.xml", "Data\\Word"));
                ArrayList commands = new ArrayList();

                //DictionaryEntry contain "Source table" (KEY) and "Command" (VALUE)
                DictionaryEntry entry = new DictionaryEntry("Employees", string.Empty);
                commands.Add(entry);

                // To retrive customer details
                DataTable table = ds.Tables["Customers"];
                string relation = table.ParentRelations[0].ChildColumns[0].ColumnName + " = %Employees." + table.ParentRelations[0].ParentColumns[0].ColumnName + "%";
                entry = new DictionaryEntry("Customers", relation);
                commands.Add(entry);

                // To retrieve order details
                table = ds.Tables["Orders"];
                relation = table.ParentRelations[0].ChildColumns[0].ColumnName + " = %Customers." + table.ParentRelations[0].ParentColumns[0].ColumnName + "%";
                entry = new DictionaryEntry("Orders", relation);
                commands.Add(entry);

                //Executes nested Mail merge using explicit relational data.
                document.MailMerge.ExecuteNestedGroup(ds, commands);
            }
            else
            {
                 MailMergeDataTable dataTable = GetMailMergeDataTable();
                //Executes nested Mail merge using implicit relational data.
                document.MailMerge.ExecuteNestedGroup(dataTable);
            }

            try
            {
                #region Document SaveOption
                //Save as .doc format
                if (Group1 == "WordDoc")
                {
                    return document.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                //Save as .docx format
                else if (Group1 == "WordDocx")
                {
                    return document.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                // Save as WordML(.xml) format
                else if (Group1 == "WordML")
                {
                    return document.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                //Save as .pdf format
                else if (Group1 == "Pdf")
                {
                    DocToPDFConverter converter = new DocToPDFConverter();
                    PdfDocument pdfDoc = converter.ConvertToPDF(document);

                    return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                }
                #endregion Document SaveOption
            }
            catch (Exception)
            { }
            return View();
        }
        #endregion  EmployeeReport
        /// <summary>
        /// Gets the mail merge data table.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private MailMergeDataTable GetMailMergeDataTable()
        {
            List<EmployeeDetailsImplicit> employees = new List<EmployeeDetailsImplicit>();
            FileStream fs = new FileStream(ResolveApplicationDataPath("Employees.xml", "Data\\Word"), FileMode.Open, FileAccess.Read);

            XmlReader reader = XmlReader.Create(fs);

            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "EmployeesList")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            while (reader.LocalName != "EmployeesList")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "Employees":
                            employees.Add(GetEmployee(reader));
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "EmployeesList") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }

            MailMergeDataTable dataTable = new MailMergeDataTable("Employees", employees);

            reader.Close();
            fs.Dispose();
            return dataTable;
        }
        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private EmployeeDetailsImplicit GetEmployee(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "Employees")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            EmployeeDetailsImplicit employee = new EmployeeDetailsImplicit();
            while (reader.LocalName != "Employees")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "EmployeeID":
                            employee.EmployeeID = reader.ReadElementContentAsString();
                            break;
                        case "LastName":
                            employee.LastName = reader.ReadElementContentAsString();
                            break;
                        case "FirstName":
                            employee.FirstName = reader.ReadElementContentAsString();
                            break;
                        case "Address":
                            employee.Address = reader.ReadElementContentAsString();
                            break;
                        case "City":
                            employee.City = reader.ReadElementContentAsString();
                            break;
                        case "Country":
                            employee.Country = reader.ReadElementContentAsString();
                            break;
                        case "Extension":
                            employee.Extension = reader.ReadElementContentAsString();
                            break;
                        case "Customers":
                            employee.Customers.Add(GetCustomer(reader));
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Employees") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return employee;
        }
        /// <summary>
        /// Gets the customer.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private CustomerDetailsImplicit GetCustomer(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "Customers")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            CustomerDetailsImplicit customer = new CustomerDetailsImplicit();
            while (reader.LocalName != "Customers")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "EmployeeID":
                            customer.EmployeeID = reader.ReadElementContentAsString();
                            break;
                        case "CustomerID":
                            customer.CustomerID = reader.ReadElementContentAsString();
                            break;
                        case "CompanyName":
                            customer.CompanyName = reader.ReadElementContentAsString();
                            break;
                        case "ContactName":
                            customer.ContactName = reader.ReadElementContentAsString();
                            break;
                        case "City":
                            customer.City = reader.ReadElementContentAsString();
                            break;
                        case "Country":
                            customer.Country = reader.ReadElementContentAsString();
                            break;
                        case "Orders":
                            customer.Orders.Add(GetOrders(reader));
                            break;
                    }
                    reader.Read();
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Customers") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return customer;
        }
        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private OrderDetails GetOrders(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "Orders")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            OrderDetails order = new OrderDetails();
            while (reader.LocalName != "Orders")
            {
                if (reader.NodeType != XmlNodeType.EndElement)
                {
                    switch (reader.LocalName)
                    {
                        case "OrderID":
                            order.OrderID = reader.ReadElementContentAsString();
                            break;
                        case "CustomerID":
                            order.CustomerID = reader.ReadElementContentAsString();
                            break;
                        case "OrderDate":
                            order.OrderDate = reader.ReadElementContentAsString();
                            break;
                        case "RequiredDate":
                            order.RequiredDate = reader.ReadElementContentAsString();
                            break;
                        case "ShippedDate":
                            order.ShippedDate = reader.ReadElementContentAsString();
                            break;
                    }
                    reader.Read();
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Orders") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return order;
        }
    }

    #region Mailmerge data objects
    public class EmployeeDetailsImplicit
    {
        #region Fields
        private string m_employeeID;
        private string m_lastName;
        private string m_firstName;
        private string m_address;
        private string m_city;
        private string m_country;
        private string m_extension;
        private List<CustomerDetailsImplicit> m_customers;
        #endregion

        #region Properties
        public string EmployeeID
        {
            get { return m_employeeID; }
            set { m_employeeID = value; }
        }
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        public string Address
        {
            get { return m_address; }
            set { m_address = value; }
        }
        public string City
        {
            get { return m_city; }
            set { m_city = value; }
        }
        public string Country
        {
            get { return m_country; }
            set { m_country = value; }
        }
        public string Extension
        {
            get { return m_extension; }
            set { m_extension = value; }
        }
        public List<CustomerDetailsImplicit> Customers
        {
            get
            {
                if (m_customers == null)
                    m_customers = new List<CustomerDetailsImplicit>();
                return m_customers;
            }
            set
            {
                m_customers = value;
            }
        }
        #endregion

        #region Constructor
        public EmployeeDetailsImplicit()
        {
            m_customers = new List<CustomerDetailsImplicit>();
        }
        #endregion
    }
    public class CustomerDetailsImplicit
    {
        #region Fields
        private string m_employeeID;
        private string m_customerID;
        private string m_companyName;
        private string m_contactName;
        private string m_city;
        private string m_country;
        private List<OrderDetails> m_orders;
        #endregion

        #region Properties
        public List<OrderDetails> Orders
        {
            get
            {
                if (m_orders == null)
                    m_orders = new List<OrderDetails>();
                return m_orders;
            }
            set
            {
                m_orders = value;
            }
        }
        public string EmployeeID
        {
            get { return m_employeeID; }
            set { m_employeeID = value; }
        }
        public string CustomerID
        {
            get { return m_customerID; }
            set { m_customerID = value; }
        }
        public string CompanyName
        {
            get { return m_companyName; }
            set { m_companyName = value; }
        }
        public string ContactName
        {
            get { return m_contactName; }
            set { m_contactName = value; }
        }
        public string City
        {
            get { return m_city; }
            set { m_city = value; }
        }
        public string Country
        {
            get { return m_country; }
            set { m_country = value; }
        }
        #endregion

        #region Constructor
        public CustomerDetailsImplicit()
        {
            m_orders = new List<OrderDetails>();
        }
        #endregion
    }
    public class OrderDetails
    {
        #region Fields
        private string m_orderID;
        private string m_customerID;
        private string m_orderDate;
        private string m_requiredDate;
        private string m_shippedDate;
        #endregion

        #region Properties
        public string OrderID
        {
            get { return m_orderID; }
            set { m_orderID = value; }
        }
        public string CustomerID
        {
            get { return m_customerID; }
            set { m_customerID = value; }
        }
        public string OrderDate
        {
            get { return m_orderDate; }
            set { m_orderDate = value; }
        }
        public string RequiredDate
        {
            get { return m_requiredDate; }
            set { m_requiredDate = value; }
        }
        public string ShippedDate
        {
            get { return m_shippedDate; }
            set { m_shippedDate = value; }
        }
        #endregion
    }
    #endregion
}