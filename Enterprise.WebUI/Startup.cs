﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Enterprise.WebUI.Startup))]
namespace Enterprise.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
