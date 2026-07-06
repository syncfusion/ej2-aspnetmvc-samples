using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.BlockEditor;
using System.Collections.Generic;
using System.Web.Mvc;
using static EJ2MVCSampleBrowser.Models.BlockData;

namespace EJ2MVCSampleBrowser.Controllers.BlockEditor
{
    public partial class BlockEditorController : Controller
    {
        public List<BlockModel> BlockDataAPI { get; set; }
        public ActionResult API()
        {
            BlockDataAPI = new BlockData().GetBlockDataAPI();
            ViewData["BlockDataAPI"] = BlockDataAPI;
            return View();
        }
    }
}