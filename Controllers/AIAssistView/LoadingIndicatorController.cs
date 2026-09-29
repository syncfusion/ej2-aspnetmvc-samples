using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<ToolbarItemModel> LoadingIndicatorItems = new List<ToolbarItemModel>();
        public ActionResult LoadingIndicator()
        {
            LoadingIndicatorItems.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh" });
            ViewData["ToolbarItems"] = LoadingIndicatorItems;
            ViewData["PromptResponseData"] = new PromptResponseData().GetAllPromptResponseData();
            ViewData["PromptSuggestionData"] = new PromptResponseData().GetAllSuggestionData();

            List<LoadingTypeModel> loadingTypes = new List<LoadingTypeModel>();
            loadingTypes.Add(new LoadingTypeModel { Value = "dot", Text = "Dot" });
            loadingTypes.Add(new LoadingTypeModel { Value = "spinner", Text = "Spinner" });
            loadingTypes.Add(new LoadingTypeModel { Value = "text", Text = "Text" });
            loadingTypes.Add(new LoadingTypeModel { Value = "textIndicator", Text = "Text with indicator" });
            ViewData["LoadingTypeDataSource"] = loadingTypes;

            return View();
        }

        public class LoadingTypeModel
        {
            public string Value { get; set; }
            public string Text { get; set; }
        }
    }
}
