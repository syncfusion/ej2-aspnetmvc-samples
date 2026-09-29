using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJ2MVCSampleBrowser.Models
{
    public class FormBuilderData
    {
        public Schema GetData()
        {
            Schema formSchema = new Schema
            {
                Properties = new Dictionary<string, object>(),
                Layout = new List<object>(),
                Settings = new SchemaSettings
                {
                    Name = "Untitled Form",
                    Width = "100%"
                }
            };
            return formSchema;
        }
    }

    public class Schema
    {
        [JsonProperty("properties")]
        public Dictionary<string, object> Properties { get; set; }

        [JsonProperty("layout")]
        public List<object> Layout { get; set; }

        [JsonProperty("settings")]
        public SchemaSettings Settings { get; set; }
    }

    public class SchemaSettings
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }
    }

}