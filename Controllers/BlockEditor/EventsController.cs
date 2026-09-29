using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.BlockEditor;
using System.Collections.Generic;
using System.Web.Mvc;
using static EJ2MVCSampleBrowser.Models.BlockEditorEvents;

namespace EJ2MVCSampleBrowser.Controllers.BlockEditor
{
    public partial class BlockEditorController : Controller
    {
        public List<BlockModel> BlockDataEvents { get; set; }
        public ActionResult Events()
        {
            BlockDataEvents = new BlockEditorEvents().GetBlockDataEvents();
            ViewData["BlockDataEvents"] = BlockDataEvents;
            return View();
        }
    }
}