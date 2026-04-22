#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Navigations;
using Syncfusion.EJ2.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using Syncfusion.EJ2;
using Newtonsoft.Json;
using Syncfusion.EJ2.Popups;


namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: CRUD
        public ActionResult CRUD()
        {
            //Add icons in Toolbar.
            List<ToolbarItem> items = new List<ToolbarItem>();
            items.Add(new ToolbarItem { TooltipText = "Add", Id = "Add", PrefixIcon = "e-ddb-icons e-add", Text = "Add" });
            items.Add(new ToolbarItem { Type = ItemType.Separator });
            items.Add(new ToolbarItem { TooltipText = "Edit", Id = "Edit", PrefixIcon = "e-ddb-icons e-update", Text = "Edit" });
            items.Add(new ToolbarItem { Type = ItemType.Separator });
            items.Add(new ToolbarItem { TooltipText = "Delete", Id = "Delete", PrefixIcon = "e-ddb-icons e-delete", Text = "Delete" });
            items.Add(new ToolbarItem { Type = ItemType.Separator });
            items.Add(new ToolbarItem { TooltipText = "Reset", Id = "Reset", PrefixIcon = "e-ddc-icons e-reset", Text = "Reset" });

            ViewData["tbItems"] = items;

            DiagramCrudAction nodeCrud = new DiagramCrudAction()
            {
                //Define URL to perform CRUD operations with nodes records in database.
                Read = "https://js.syncfusion.com/demos/ejServices/api/Diagram/GetNodes",
                Create = "https://js.syncfusion.com/demos/ejServices/api/Diagram/AddNodes",
                Update = "https://js.syncfusion.com/demos/ejServices/api/Diagram/UpdateNodes",
                Destroy = "https://js.syncfusion.com/demos/ejServices/api/Diagram/DeleteNodes",
                CustomFields = new object[] { "Id", "Description", "Color" },
            };
            ViewData["NodeCrud"] = nodeCrud;

           


            ConnectionDataSource dataSource = new ConnectionDataSource()
            {
                Id = "Name",
                SourceID = "SourceNode",
                TargetID = "TargetNode",
                CustomFields = new object[] { "Id" },
                CrudAction = new CRUDAction()
                {
                    //Define URL to perform CRUD operations with connector records in database.
                    Read = "https://js.syncfusion.com/demos/ejServices/api/Diagram/GetConnectors",
                    Create = "https://js.syncfusion.com/demos/ejServices/api/Diagram/AddConnectors",
                    Update = "https://js.syncfusion.com/demos/ejServices/api/Diagram/UpdateConnectors",
                    Destroy = "https://js.syncfusion.com/demos/ejServices/api/Diagram/DeleteConnectors",
                    CustomFields = new object[] { "Id" },
                }
            };
            ViewData["DataSource"] = dataSource;

            DiagramDataSource DataSourceSettings = new DiagramDataSource();
            DataSourceSettings.Id = "Name";
            DataSourceSettings.CrudAction = nodeCrud;
            DataSourceSettings.ConnectionDataSource = dataSource;
            ViewData["DataSourceSettings"] = DataSourceSettings;

            //Button control rendered in dialog to update node bgColor and label.
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new DefaultButtonModel() { content = "Update", isPrimary = true } });
            ViewData["DefaultButtons"] = buttons;

            return View();
        }
    }
    public class DefaultButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
    public class CRUDAction
    {
        [DefaultValue(null)]
        [HtmlAttributeName("read")]
        [JsonProperty("read")]
        public string Read { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("create")]
        [JsonProperty("create")]
        public string Create { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("update")]
        [JsonProperty("update")]
        public string Update { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("destroy")]
        [JsonProperty("destroy")]
        public string Destroy { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("customFields")]
        [JsonProperty("customFields")]
        public object[] CustomFields { get; set; }
    }

    public class ConnectionDataSource : DiagramConnectionDataSource
    {
        [DefaultValue(null)]
        [HtmlAttributeName("id")]
        [JsonProperty("id")]
        public string Id { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("sourceID")]
        [JsonProperty("sourceID")]
        public string SourceID { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("targetID")]
        [JsonProperty("targetID")]
        public string TargetID { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("customFields")]
        [JsonProperty("customFields")]
        public object[] CustomFields { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("crudAction")]
        [JsonProperty("crudAction")]
        public CRUDAction CrudAction { get; set; }
    }
}