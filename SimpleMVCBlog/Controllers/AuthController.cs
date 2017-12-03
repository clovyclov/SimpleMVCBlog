﻿using SimpleMVCBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVCBlog.Controllers
{
    public class AuthController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }


            return View(form);
        }
    }
}