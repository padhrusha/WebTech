﻿using Microsoft.AspNetCore.Mvc;

namespace Padhrusha.UI.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
