using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLisaBLL.Managers.Interfaces;

namespace MVCLisa.Controllers
{
    public class RoleController : Controller
    {
        [Ninject.Inject]
        public IRoleManager RoleManager { get; set; }

        // GET: Role
        public ActionResult List()
        {
          /*  ServiceReference1.WebService1SoapClient testServer = new ServiceReference1.WebService1SoapClient();
            string str2 = testServer.GetAge("b101");*/
            
            return View(RoleManager.getRoles());
        }
    }
}