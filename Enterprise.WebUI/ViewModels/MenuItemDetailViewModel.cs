using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enterprise.WebUI.ViewModels
{
    public class MenuItemDetailViewModel
    {
        public MenuItem MenuItem { get; set; }

        public IList<MenuItem> RelatedMenuItems { get; set; }

    }
}