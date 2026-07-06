using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJ2MVCSampleBrowser.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class NonUrlActionAttribute: Attribute
    {
        private bool nonUrl;
        public bool NonUrl
        {
            get { return this.nonUrl; }
            set { this.NonUrl = value; }
        }
        public NonUrlActionAttribute()
        {

        }
    }
}