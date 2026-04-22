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
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;

namespace EJ2MVCSampleBrowser.Models
{
    public class MergeData
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }

    public class MergeDataModel
    {
        public List<MergeData> MergeDataList { get; set; }

        public MergeDataModel()
        {
            MergeDataList = new List<MergeData>
            {
                new MergeData { Text = "First Name", Value = "FirstName" },
                new MergeData { Text = "Last Name", Value = "LastName" },
                new MergeData { Text = "Support Email", Value = "SupportEmail" },
                new MergeData { Text = "Company Name", Value = "CompanyName" },
                new MergeData { Text = "Promo Code", Value = "PromoCode" },
                new MergeData { Text = "Support Phone Number", Value = "SupportPhoneNumber" },
                new MergeData { Text = "Customer ID", Value = "CustomerID" },
                new MergeData { Text = "Expiration Date", Value = "ExpirationDate" },
                new MergeData { Text = "Subscription Plan", Value = "SubscriptionPlan" }
            };
        }
    }
}
