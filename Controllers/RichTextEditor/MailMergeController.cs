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
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult MailMerge()
        {
            ViewData["MergeData"] = new MergeDataModel().MergeDataList;
            ViewData["MentionChar"] = '{';
            ViewData["RTEValue"] = @"<p>Dear <span contenteditable=""false"" class=""e-mention-chip""><span>{{FirstName}}</span></span> <span contenteditable=""false"" class=""e-mention-chip""><span>{{LastName}}</span></span>,</p>
                <p>We are thrilled to have you with us! Your unique promotional code for this month is: <span contenteditable=""false"" class=""e-mention-chip""><span>{{PromoCode}}</span></span>.</p>
                <p>Your current subscription plan is: <span contenteditable=""false"" class=""e-mention-chip""><span>{{SubscriptionPlan}}</span></span>.</p>
                <p>Your customer ID is: <span contenteditable=""false"" class=""e-mention-chip""><span>{{CustomerID}}</span></span>.</p>
                <p>Your promotional code expires on: <span contenteditable=""false"" class=""e-mention-chip""><span>{{ExpirationDate}}</span></span>.</p>
                <p>Feel free to browse our latest offerings and updates. If you need any assistance, don't hesitate to contact us at <a href=""mailto:{{SupportEmail}}""><span contenteditable=""false"" class=""e-mention-chip""><span>{{SupportEmail}}</span></span></a> or call us at <span contenteditable=""false"" class=""e-mention-chip""><span>{{SupportPhoneNumber}}</span></span>.</p>
                <p>Best regards,<br>The <span contenteditable=""false"" class=""e-mention-chip""><span>{{CompanyName}}</span></span> Team</p>";
            ViewData["Tools"] = new object[]  {
                "Bold",
                "Italic",
                "Underline",
                "|",
                "Formats",
                "Alignments",
                "OrderedList",
                "UnorderedList",
                "|",
                "CreateLink",
                "Image",
                "CreateTable",
                "|",
                new { tooltipText = "Merge Data", template = "#merge_data", command = "Custom" },
                new { tooltipText = "Insert Field", template = "#insert_Field", command = "Custom" },
                "SourceCode",
                "|",
                "Undo",
                "Redo",
            };
            ViewData["Items"] = new List<object>
            {
                new { text = "First Name" },
                new { text = "Last Name" },
                new { text = "Support Email" },
                new { text = "Company Name" },
                new { text = "Promo Code" },
                new { text = "Support Phone Number" },
                new { text = "Customer ID" },
                new { text = "Expiration Date" },
                new { text = "Subscription Plan" }
            };
            return View();
        }
    }
}
