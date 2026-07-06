using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJ2MVCSampleBrowser.Models
{
    public class DropDownModel
    {
        public object scrollFormats()
        {

            List<object> scrollFormats = new List<object>();

            scrollFormats.Add(new

            {

                text = "Infinity",

                value = "Infinity"

            });

            scrollFormats.Add(new

            {

                text = "Diagram",

                value = "Diagram"

            });

            scrollFormats.Add(new

            {

                text = "Limited",

                value = "Limited"

            });

            return scrollFormats;

        }
    }
}