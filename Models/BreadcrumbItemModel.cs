using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace EJ2MVCSampleBrowser.Models
{
    public class BreadcrumbItemModel
    {
        public string Text { get; set; }
        public string IconCss { get; set; }

        public List<BreadcrumbItemModel> Items { get; set; }
    }
}
