#region Copyright Syncfusion Inc. 2001-2022
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Syncfusion.Presentation;
using System.Drawing;
using System.IO;


namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PowerPointController : Controller
    {
        //
        // GET: /Animation/

        public ActionResult ModifyingAnimation()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        
		public ActionResult ModifyingAnimation(string Browser,string button)
        {
		if (button == " Input Template ")
            {
                string filename = "ShapeWithAnimation.pptx";
				
				//New Instance of PowerPoint is created.[Equivalent to launching MS PowerPoint with no slides].
                IPresentation presentation = Presentation.Open(ResolveApplicationDataPath(filename));
				
                return new PresentationResult(presentation, "ShapeWithAnimation.pptx", HttpContext.ApplicationInstance.Response);
            }
        else
            {
                string filename = "ShapeWithAnimation.pptx";
				
				//New Instance of PowerPoint is created.[Equivalent to launching MS PowerPoint with no slides].
                IPresentation presentation = Presentation.Open(ResolveApplicationDataPath(filename));
                

                //Modify the existing animation
                ModifyAppliedAnimation(presentation);

                //Save the presentation
                return new PresentationResult(presentation, "ModifiedAnimationSample.pptx", HttpContext.ApplicationInstance.Response);
			}


        }

        #region Modify Animation

        private void ModifyAppliedAnimation(IPresentation presentation)
        {
            //Get the slide from the presentation
            ISlide slide = presentation.Slides[0];

            //Access the animation sequence to modify effects
            ISequence sequence = slide.Timeline.MainSequence;

            //Change the animation effect of the first effect
            IEffect loopEffect = sequence[0];
            loopEffect.Type = EffectType.Bounce;
        }
        #endregion
    }
}
