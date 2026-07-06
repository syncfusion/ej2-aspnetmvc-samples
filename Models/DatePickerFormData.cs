using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJ2MVCSampleBrowser.Models
{
    public class DateFormats
    {
        public string Id { get; set; }
        public string Text { get; set; }

        public List<DateFormats> GetDateFormatsWithId()
        {
            return new List<DateFormats>
            {
                new DateFormats { Id = "format1", Text = "dd-MMM-yy" },
                new DateFormats { Id = "format2", Text = "yyyy-MM-dd" },
                new DateFormats { Id = "format3", Text = "dd-MMMM-yyyy" }
            };
        }

        public string[] GetInputFormats()
        {
            return new string[]
            {
                "dd/MM/yyyy", "ddMMMyy", "yyyyMMdd", "dd.MM.yy", "MM/dd/yyyy", "yyyy/MMM/dd", "dd-MM-yyyy"
            };
        }
    }
}