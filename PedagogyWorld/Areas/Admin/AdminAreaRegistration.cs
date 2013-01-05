﻿using System.Web.Mvc;

namespace PedagogyWorld.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { Controller="States", action = "Main", id = UrlParameter.Optional },
                new[] { "PedagogyWorld.Areas.Admin.Controllers" }
            );
        }
    }
}