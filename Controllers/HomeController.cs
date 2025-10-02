#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Azure;
using Azure.AI.OpenAI;
using OpenAI;
using OpenAI.Chat;
using Syncfusion.EJ2.Layouts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using static EJ2MVCSampleBrowser.Controllers.AIAssistView.AIAssistViewController;
using System.ComponentModel.DataAnnotations;

namespace EJ2MVCSampleBrowser.Controllers
{
    public class HomeController : Controller
    {
        public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();


        public ActionResult Index()
        {
            Items.Add(new ToolbarItemModel { iconCss = "e-icons e-refresh", align = "Right" });
            ViewBag.Items = Items;
            var PromptSuggestionData = new string[]
            {
                "What are the best tools for organizing my tasks?",
                "How can I maintain work-life balance effectively?"
            };
            ViewBag.PromptSuggestionData = PromptSuggestionData;
            return View();
        }

        public class ToolbarItemModel
        {
            public string iconCss { get; set; }
            public string align { get; set; }
        }

        // Define the missing PromptRequest class
        public class PromptRequest
        {
            [Required] // Ensures the Prompt field is not null or empty
            public string Prompt { get; set; }
        }

        [System.Web.Mvc.HttpPost]
        public async Task<ActionResult> GetAIResponse([System.Web.Http.FromBody] PromptRequest request)
        {
            try
            {
                _logger.LogInformation("Received request with prompt: {Prompt}", request?.Prompt);

                if (string.IsNullOrEmpty(request?.Prompt))
                {
                    _logger.LogWarning("Prompt is null or empty.");
                    return BadRequest("Prompt cannot be empty.");
                }

                // Azure OpenAI configuration
                string endpoint = ""; // Replace with your Azure OpenAI endpoint
                string apiKey = ""; // Replace with your Azure OpenAI API key
                string deploymentName = "gpt-4o-mini"; // Replace with your Azure OpenAI deployment name (e.g., gpt-4o-mini)

                var credential = new AzureKeyCredential(apiKey);
                var client = new AzureOpenAIClient(new Uri(endpoint), credential);
                var chatClient = client.GetChatClient(deploymentName);

                var chatCompletionOptions = new ChatCompletionOptions();
                var completion = await chatClient.CompleteChatAsync(
                    new[] { new UserChatMessage(request.Prompt) },
                    chatCompletionOptions
                );

                string responseText = completion.Value.Content[0].Text;
                if (string.IsNullOrEmpty(responseText))
                {
                    _logger.LogError("Azure OpenAI API returned no text.");
                    return BadRequest("No response from Azure OpenAI.");
                }

                _logger.LogInformation("Azure OpenAI response received: {Response}", responseText);
                return Json(responseText);
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception in Azure OpenAI call: {Message}", ex.Message);
                return BadRequest($"Error generating response: {ex.Message}");
            }
        }

        private ActionResult BadRequest(string v)
        {
            throw new NotImplementedException();
        }

        public ActionResult SitemapXml()
        {
            string xml = GetSiteMapdocument();
            return this.Content(xml, System.Net.Mime.MediaTypeNames.Text.Xml, Encoding.UTF8);
        }

        [HttpGet]
        public string GetHtml(string path)
        {
            var localPath = Server.MapPath("~/" + path);
            return System.IO.File.ReadAllText(localPath);
        }

        private string GetSiteMapdocument()
        {
            XNamespace xmlns = "http://www.sitemaps.org/schemas/sitemap/0.9";
            XElement root = new XElement(xmlns + "urlset");
            var controllers = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => typeof(Controller).IsAssignableFrom(type)
                || type.Name.EndsWith("controller")).ToList();
            string path = Request.Url.ToString().Replace("sitemap.xml", "");
            if (Request.Url.ToString().IndexOf("aspnetmvc.syncfusion.com") > -1)
            {
                path = "https://ej2.syncfusion.com/aspnetmvc/demos/";
            }

            foreach (var controller in controllers)
            {
                if (controller.Name.Replace("Controller", "").IndexOf("Views") == -1 && controller.Name.Replace("Controller", "").IndexOf("Home") == -1)
                {
                    var methods = controller.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                        .Where(method => typeof(ActionResult).IsAssignableFrom(method.ReturnType));
                    foreach (var method in methods)
                    {
                        string url = path + controller.Name.Replace("Controller", "") + "/" + method.Name;
                        XElement urlElement = new XElement(
                xmlns + "url",
                new XElement(xmlns + "loc", Uri.EscapeUriString(url)),
                 new XElement(
                    xmlns + "lastmod",
                    DateTime.UtcNow.ToString("yyyy-MM-dd")));
                        root.Add(urlElement);
                    }
                }
            }

            XDocument document = new XDocument(root);
            return document.ToString();
        }
    }

    public static class _logger
    {
        public static void LogInformation(string v, string prompt)
        {
            throw new NotImplementedException();
        }

        public static void LogWarning(string v)
        {
            throw new NotImplementedException();
        }

        public static void LogError(string v)
        {
            throw new NotImplementedException();
        }

        public static void LogError(string v, Exception ex)
        {
            throw new NotImplementedException();
        }

        public static void LogError(string v, string ex)
        {
            throw new NotImplementedException();
        }
    }
}
