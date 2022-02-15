using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using movies.client.Apimodels;
using movies.client.dbentities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace movies.client.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private Icustomerservices customerservices;

        public CustomerController(Icustomerservices _customerservices,db_balajiContext _context)
        {
            customerservices = _customerservices;

        }
        // GET: CustomerController
        public async Task<ActionResult> Index()
        {
            await LogTokenAndClaims();
            return View(customerservices.GetCustomers());
        }
        public async Task LogTokenAndClaims()
        {
            var identitytoken = await HttpContext.GetTokenAsync(OpenIdConnectParameterNames.IdToken);
            Debug.WriteLine($"Identity Token:{identitytoken}");
            foreach(var claim in User.Claims)
            {
                Debug.WriteLine($"claim Type:{claim.Type}-claim value:{claim.Value}");
            }
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
