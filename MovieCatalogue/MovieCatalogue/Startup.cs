﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieCatalogue.Startup))]
namespace MovieCatalogue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
