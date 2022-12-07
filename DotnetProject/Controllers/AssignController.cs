using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetProject.Controllers
{
    public class AssignController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AssignController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // GET: AssignController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: AssignController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AssignController1/Create
        public ActionResult Create()
        {
            ViewData["IdentityUsers"] = new SelectList(_userManager.Users.ToList(),"Id","Email");
            ViewData["IdentityRoles"] = new SelectList(_roleManager.Roles.ToList(), "Id", "Name");

            return View();
        }

        // POST: AssignController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var userId = collection["UserId"];
                var roleId = collection["RoleId"];

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AssignController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AssignController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AssignController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AssignController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
