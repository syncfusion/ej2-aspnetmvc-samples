using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Stepper
{
    public partial class StepperController : Controller
    {
        public ActionResult Template()
        {
            List<Step> stepperTemplate = new List<Step>();
            stepperTemplate.Add(new Step { IconCss = "e-icons e-check", Text = "Step 1" });
            stepperTemplate.Add(new Step { IconCss = "e-icons e-check", Text = "Step 2" });
            stepperTemplate.Add(new Step { IconCss = "e-icons e-check", Text = "Step 3" });
            stepperTemplate.Add(new Step { IconCss = "e-icons e-check", Text = "Step 4" });
            ViewData["StepperTemplate"] = stepperTemplate;
            return View();
        }
    }
}