#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion


using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.BlockEditor;
using Syncfusion.EJ2.Navigations;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.BlockEditor
{
    public partial class BlockEditorController : Controller
    {
        public List<object> CommandMenuItems { get; set; }
        public CommandMenuSettings CommandMenuSettings { get; set; }
        public string[] MarkdownInlineToolbarItems { get; set; }
        public InlineToolbarSettings InlineToolbarSettings { get; set; }
        public ActionResult MarkdownBlocks()
        {
            // Sidebar header
            ViewBag.SidebarHeaderText = "Markdown Templates";

            // Breadcrumb initial items
            ViewData["BreadcrumbItems"] = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Text = "Team" }
            };

            CommandMenuItems = new List<object>
            {
                new
                {
                    id = "bullet-list-command",
                    type = "BulletList",
                    groupBy = "General",
                    label = "Bullet List",
                    tooltip = "Create a bullet list",
                    iconCss = "e-icons e-list-unordered",
                    shortcut = "Ctrl+Shift+8"
                },
                new
                {
                    id = "numbered-list-command",
                    type = "NumberedList",
                    groupBy = "General",
                    label = "Numbered List",
                    tooltip = "Create a numbered list",
                    iconCss = "e-icons e-list-ordered",
                    shortcut = "Ctrl+Shift+9"
                },
                new
                {
                    id = "divider-command",
                    type = "Divider",
                    groupBy = "General",
                    label = "Divider",
                    tooltip = "Add a horizontal line",
                    iconCss = "e-icons e-be-divider",
                    shortcut = "Ctrl+Shift+-"
                },
                new
                {
                    id = "code-command",
                    type = "Code",
                    groupBy = "Insert",
                    label = "Code",
                    tooltip = "Insert a code block",
                    iconCss = "e-icons e-insert-code",
                    shortcut = "Ctrl+Alt+k"
                },
                new
                {
                    id = "table-command",
                    type = "Table",
                    groupBy = "Insert",
                    label = "Table",
                    tooltip = "Insert a table block",
                    iconCss = "e-icons e-table-2",
                    shortcut = "Ctrl+Alt+T"
                },
                new
                {
                    id = "paragraph-command",
                    type = "Paragraph",
                    groupBy = "Text Styles",
                    label = "Paragraph",
                    tooltip = "Add a paragraph",
                    iconCss = "e-icons e-be-paragraph",
                    shortcut = "Ctrl+Alt+P"
                },
                new
                {
                    id = "heading1-command",
                    type = "Heading",
                    groupBy = "Text Styles",
                    label = "Heading 1",
                    tooltip = "Page title or main heading",
                    iconCss = "e-icons e-be-h1",
                    shortcut = "Ctrl+Alt+1"
                },
                new
                {
                    id = "heading2-command",
                    type = "Heading",
                    groupBy = "Text Styles",
                    label = "Heading 2",
                    tooltip = "Section heading",
                    iconCss = "e-icons e-be-h2",
                    shortcut = "Ctrl+Alt+2"
                },
                new
                {
                    id = "heading3-command",
                    type = "Heading",
                    groupBy = "Text Styles",
                    label = "Heading 3",
                    tooltip = "Subsection heading",
                    iconCss = "e-icons e-be-h3",
                    shortcut = "Ctrl+Alt+3"
                },
                new
                {
                    id = "heading4-command",
                    type = "Heading",
                    groupBy = "Text Styles",
                    label = "Heading 4",
                    tooltip = "Smaller heading for nested content",
                    iconCss = "e-icons e-be-h4",
                    shortcut = "Ctrl+Alt+4"
                },
                new
                {
                    id = "quote-command",
                    type = "Quote",
                    groupBy = "Text Styles",
                    label = "Quote",
                    tooltip = "Insert a quote block",
                    iconCss = "e-icons e-blockquote",
                    shortcut = "Ctrl+Alt+Q"
                }
            };
            MarkdownInlineToolbarItems = new string[] { "Bold", "Italic", "Underline", "StrikeThrough" };
            CommandMenuSettings = new CommandMenuSettings()
            {
                PopupWidth = "298px",
                PopupHeight = "400px",
                Commands = CommandMenuItems
            };
            InlineToolbarSettings = new InlineToolbarSettings()
            {
                Enable = true,
                Items = MarkdownInlineToolbarItems
            };
            ViewData["MarkdownInlineToolbarItems"] = MarkdownInlineToolbarItems;
            ViewData["InlineToolbarSettings"] = InlineToolbarSettings;
            // Tree data (replicated from Core)
            var teamSessionsMdPath = "./../Content/blockeditor/mdfiles/Team Sessions.md";
            var treeData = new List<TreeNode>
            {
                new TreeNode
                {
                    id = "Team Sessions", name = "Team Sessions", mdFile = teamSessionsMdPath,
                    selected = true, expanded = true,
                    children = new List<TreeNode>
                    {
                        new TreeNode { id = "1", name = "Meeting minutes.md", mdFile = "./../Content/blockeditor/mdfiles/Meeting minutes.md" },
                        new TreeNode { id = "2", name = "Brain storming.md", mdFile = "./../Content/blockeditor/mdfiles/Brain storming.md" },
                        new TreeNode { id = "3", name = "Retrospective.md", mdFile = "./../Content/blockeditor/mdfiles/Retrospective.md" }
                    }
                }
            };

            ViewData["TreeData"] = treeData;

            // Expose paths
            ViewBag.InitialMdPath = teamSessionsMdPath;
            ViewBag.TeamSessionsMdPath = teamSessionsMdPath;
            ViewData["CommandMenuItems"] = CommandMenuItems;
            ViewData["CommandMenuSettings"] = CommandMenuSettings;

            // Sidebar Html Attributes to inject class="sidebar-content"
            ViewData["SidebarHtmlAttributes"] = new Dictionary<string, object> {
                { "class", "sidebar-content" }
            };

            // Toolbar items: separator + Left template (breadcrumb) + Right template (download button)
            var tbItems = new List<ToolbarItem>
            {
                new ToolbarItem { Type = ItemType.Separator },
                new ToolbarItem { Align = ItemAlign.Left, Template = "#leftTemplate" },
                new ToolbarItem { Align = ItemAlign.Right, Template = "#rightTemplate" }
            };
            ViewData["ToolbarItems"] = tbItems;

            return View();
        }

        // Tree node model
        public class TreeNode
        {
            public string id { get; set; }
            public string name { get; set; }
            public string mdFile { get; set; }
            public bool? selected { get; set; }
            public bool? expanded { get; set; }
            public List<TreeNode> children { get; set; }
        }
    }
}