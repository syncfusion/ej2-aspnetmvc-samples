using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.BlockEditor;
using System.Collections.Generic;
using System.Web.Mvc;
using static EJ2MVCSampleBrowser.Models.BlockData;
namespace EJ2MVCSampleBrowser.Controllers.BlockEditor
{
    public partial class BlockEditorController : Controller
    {
        public List<BlockModel> BlockDataOverview { get; set; }
        public List<UserModel> MentionUsers { get; set; }
        public InlineToolbarSettings InlineToolbarSetting { get; set; }
        public ImageBlockSettings ImageBlockSettings { get; set; }
        public ActionResult Overview()
        {
            BlockDataOverview = new BlockData().GetBlockDataOverview();
            ViewData["BlockDataOverview"] = BlockDataOverview;
            MentionUsers = new BlockData().GetUniqueMentionUsers();
            ViewData["MentionUsers"] = MentionUsers;
            InlineToolbarSettings = new InlineToolbarSettings()
            {
                Items = new string[] { "Transform", "Bold", "Italic", "Underline", "StrikeThrough", "Uppercase", "Lowercase", "Subscript", "Superscript", "InlineCode", "Link", "Color", "Backgroundcolor" }
            };
            ImageBlockSettings = new ImageBlockSettings()
            {
                SaveUrl = "https://services.syncfusion.com/aspnet/production/api/RichTextEditor/SaveFile",
                Path = "https://services.syncfusion.com/aspnet/production/RichTextEditor/"
            };
            ViewData["InlineToolbarSettings"] = InlineToolbarSettings;
            ViewData["ImageBlockSettings"] = ImageBlockSettings;
            return View();
        }
    }
}