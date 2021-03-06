#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using samplebrowser.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class ListBoxController : Controller
    {
        //
        // GET: /Events/

        List<Countries> c = new List<Countries>();
        public ActionResult Events()
        {
            c.Add(new Countries { country = "Australia" });
            c.Add(new Countries { country = "Austria" });
            c.Add(new Countries { country = "Bangladesh" });
            c.Add(new Countries { country = "Brazil" });
            c.Add(new Countries { country = "Canada" });
            c.Add(new Countries { country = "China" });
            c.Add(new Countries { country = "Denmark" });
            c.Add(new Countries { country = "Europe" });
            c.Add(new Countries { country = "France" });
            c.Add(new Countries { country = "Germany" });
            c.Add(new Countries { country = "India" });
            c.Add(new Countries { country = "Japan" });
            c.Add(new Countries { country = "Kuwait" });
            c.Add(new Countries { country = "Malaysia" });
            c.Add(new Countries { country = "NewZealand" });
            ViewBag.datasource = c;
            return View();
        }
    }
}
