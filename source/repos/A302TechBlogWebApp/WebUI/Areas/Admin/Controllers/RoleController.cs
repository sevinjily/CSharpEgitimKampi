using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _rolemanager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _rolemanager = roleManager;
        }
       
        public IActionResult Index()
        {
            var roles = _rolemanager.Roles.ToList();
            return View(roles);
        }
        public IActionResult Create() 
        {
        return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole identityRole)
        {
           if(!ModelState.IsValid)
            {
                return View();
            }
            var checkRole = await _rolemanager.FindByNameAsync(identityRole.Name);
            if(checkRole != null) 
            {
                //ModelState.AddModelError("error", "Role name exist!");
                ViewData["Error"] = "Role name is exist!";
                return View();
            }
            await _rolemanager.CreateAsync(identityRole);
            return RedirectToAction("Index");
        }
    }
}
