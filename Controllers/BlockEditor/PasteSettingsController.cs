using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.BlockEditor;
using System.Collections.Generic;
using System.Web.Mvc;
using static EJ2MVCSampleBrowser.Models.BlockEditorPasteSettings;

namespace EJ2MVCSampleBrowser.Controllers.BlockEditor
{
    public partial class BlockEditorController : Controller
    {
        public List<BlockModel> BlockDataPaste { get; set; }
        public ActionResult PasteSettings()
        {
            BlockDataPaste = new BlockEditorPasteSettings().GetBlockDataPaste();
            ViewData["BlockDataPaste"] = BlockDataPaste;
            return View();
        }
    }
}