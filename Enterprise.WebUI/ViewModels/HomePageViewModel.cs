using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enterprise.WebUI.ViewModels
{
    public class HomePageViewModel
    {
        public List<MenuItem> ListMenuItems { get; set; }

        public int TotalPage { get; set; }

        public int CurrentPage { get; set; }
    }
}