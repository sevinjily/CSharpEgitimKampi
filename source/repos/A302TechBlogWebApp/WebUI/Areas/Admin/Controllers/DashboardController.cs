using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        [Authorize]//ancaq qeydiyyatdan kecen(login olmus sexsler) admin sehifesine gire biler
        public IActionResult Index()
        {
            return View();
        }
    }
}
