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

namespace EJ2MVCSampleBrowser.Models
{
    public class EmailData
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string Eimg { get; set; }
        public string EmailId { get; set; }

        public List<EmailData> EmailList()
        {
            List<EmailData> mention = new List<EmailData>();
            mention.Add(new EmailData { Name = "Selma Rose", Status = "active", Eimg = "2", EmailId = "selma@gmail.com" });
            mention.Add(new EmailData { Name = "Maria", Status = "active", Eimg = "1", EmailId = "maria@gmail.com" });
            mention.Add(new EmailData { Name = "Russo Kay", Status = "busy", Eimg = "8", EmailId = "russo@gmail.com" });
            mention.Add(new EmailData { Name = "Camden Kate", Status = "active", Eimg = "9", EmailId = "camden@gmail.com" });
            mention.Add(new EmailData { Name = "Robert", Status = "busy", Eimg = "dp", EmailId = "robert@gmail.com" });
            mention.Add(new EmailData { Name = "Garth", Status = "active", Eimg = "7", EmailId = "garth@gmail.com" });
            mention.Add(new EmailData { Name = "Andrew James", Status = "away", Eimg = "10", EmailId = "james@gmail.com" });
            mention.Add(new EmailData { Name = "Olivia", Status = "busy", Eimg = "5", EmailId = "olivia@gmail.com" });
            mention.Add(new EmailData { Name = "Sophia", Status = "away", Eimg = "6", EmailId = "sophia@gmail.com" });
            mention.Add(new EmailData { Name = "Margaret", Status = "active", Eimg = "3", EmailId = "margaret@gmail.com" });
            mention.Add(new EmailData { Name = "Ursula Ann", Status = "active", Eimg = "dp", EmailId = "ursula@gmail.com" });
            mention.Add(new EmailData { Name = "Laura Grace", Status = "away", Eimg = "4", EmailId = "laura@gmail.com" });
            mention.Add(new EmailData { Name = "Albert", Status = "active", Eimg = "pic03", EmailId = "albert@gmail.com" });
            mention.Add(new EmailData { Name = "William", Status = "away", Eimg = "10", EmailId = "william@gmail.com" });
            return mention;
        }

    }
    public class EmailDatas
    {
        public string Name { get; set; }
        public string Initial { get; set; }
        public string Email { get; set; }
        public string Color { get; set; }
        public string BgColor { get; set; }

        public List<EmailDatas> EmailList()
        {
            List<EmailDatas> mention = new List<EmailDatas>();
            mention.Add(new EmailDatas { Name = "Selma Rose", Initial = "SR", Email = "selma@gmail.com", Color = "#FAFDFF", BgColor = "#01579B" });
            mention.Add(new EmailDatas { Name = "Maria", Initial = "MA", Email = "maria@gmail.com", Color = "#004378", BgColor = "#ADDBFF" });
            mention.Add(new EmailDatas { Name = "Russo Kay", Initial = "RK", Email = "russo@gmail.com", Color = "#F9DEDC", BgColor = "#8C1D18" });
            mention.Add(new EmailDatas { Name = "Robert", Initial = "RO", Email = "robert@gmail.com", Color = "#FFD6F7", BgColor = "#37003A" });
            mention.Add(new EmailDatas { Name = "Camden Kate", Initial = "CK", Email = "camden@gmail.com", Color = "#FFFFFF", BgColor = "#464ECF" });
            mention.Add(new EmailDatas { Name = "Garth", Initial = "GA", Email = "garth@gmail.com", Color = "#FFFFFF", BgColor = "#008861" });
            mention.Add(new EmailDatas { Name = "Andrew James", Initial = "AJ", Email = "james@gmail.com", Color = "#FFFFFF", BgColor = "#53CA17" });
            mention.Add(new EmailDatas { Name = "Olivia", Initial = "OL", Email = "olivia@gmail.com", Color = "#FFFFFF", BgColor = "#8C1D18" });
            mention.Add(new EmailDatas { Name = "Sophia", Initial = "SO", Email = "sophia@gmail.com", Color = "#000000", BgColor = "#D0BCFF" });
            mention.Add(new EmailDatas { Name = "Margaret", Initial = "MA", Email = "margaret@gmail.comC", Color = "#000000B", BgColor = "#F2B8B5" });
            mention.Add(new EmailDatas { Name = "Ursula Ann", Initial = "UA", Email = "ursula@gmail.com", Color = "#000000", BgColor = "#47ACFB" });
            mention.Add(new EmailDatas { Name = "Laura Grace", Initial = "LG", Email = "laura@gmail.com", Color = "#000000", BgColor = "#FFE088" });
            mention.Add(new EmailDatas { Name = "Albert", Initial = "AL", Email = "albert@gmail.com", Color = "#FFFFFF", BgColor = "#00335B" });
            mention.Add(new EmailDatas { Name = "William", Initial = "WA", Email = "william@gmail.com", Color = "#FFFFFF", BgColor = "#163E02" });
            return mention;
        }

    }
}