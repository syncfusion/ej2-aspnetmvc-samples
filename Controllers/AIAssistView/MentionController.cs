using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<ToolbarItemModel> MentionItems = new List<ToolbarItemModel>();

        public ActionResult Mention()
        {
            MentionItems.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh", tooltip = "Start new chat" });

            // Mention source data shown in the popup.
            var agents = new List<object>
            {
                new { id = "TechSupport", name = "TechSupport", description = "Help troubleshoot VPN connectivity issues.", placeholder = "Ask about VPN, network, or device issues", iconCss = "e-icons e-comment-status" },
                new { id = "HRAssistant", name = "HRAssistant", description = "What is the parental leave policy?", placeholder = "Ask about leave, benefits, and HR policies", iconCss = "e-icons e-people" },
                new { id = "KnowledgeBase", name = "KnowledgeBase", description = "Find details about the employee onboarding process.", iconCss = "e-icons e-objects" },
            };
            var commands = new List<object>
            {
                new { id = "table", name = "/table", description = "Answer as a markdown table", placeholder = "Format the response as a table", iconCss = "e-icons e-table" },
                new { id = "rewrite", name = "/rewrite", description = "Rewrite content for clarity and professionalism.", placeholder = "Improve clarity and professional tone", iconCss = "e-icons e-rename" },
                new { id = "checklist", name = "/checklist", description = "Convert a process into a step-by-step checklist.", iconCss = "e-icons e-list-unordered" }
            };

            // Mentions configuration consumed by the AIAssistView builder.
            var mentions = new List<object>
            {
                new
                {
                    mentionChar = "@",
                    dataSource = agents,
                    fields = new { text = "name", value = "id", iconCss = "iconCss" },
                    filterType = "StartsWith",
                    highlight = true
                },
                new
                {
                    mentionChar = "/",
                    dataSource = commands,
                    showMentionChar = false,
                    fields = new { text = "name", value = "id" },
                    itemTemplate = @"<div class='listItems'><span class='commandIcon ${iconCss}'></span><span class='commandName'>${name}</span><span class='commandDesc'>${description}</span></div>",
                    displayTemplate = @"<span class='e-aiassist-mention-item-chip'>${name}</span>"
                }
            };

            ViewData["ToolbarItems"] = MentionItems;
            ViewData["PromptSuggestionData"] = PromptResponseData.MentionSuggestions;
            ViewData["Agents"] = agents;
            ViewData["Commands"] = commands;
            ViewData["Mentions"] = mentions;

            return View();
        }
    }
}
