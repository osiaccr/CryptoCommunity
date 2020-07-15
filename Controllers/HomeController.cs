using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CryptoCommunity.Models;
using CryptoCommunity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CryptoCommunity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IConfiguration configuration)
        {
            _logger = logger;
            _context = context;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            List<ListingType> listingTypes = await _context.ListingTypes.ToListAsync();
            List<Listing> listings = await _context.Listings.ToListAsync();
            List<Socialmedia> socialmedias = await _context.Socialmedias.ToListAsync();
            List<SocialmediaType> socialmediaTypes = await _context.SocialmediaTypes.ToListAsync();

            return View(new IndexViewModel { ListingTypes = listingTypes, Listings = listings, Socialmedias = socialmedias, SocialmediaTypes = socialmediaTypes}); 
        }

        public async Task<IActionResult> Apply()
        {
            ViewData["ListingtypeId"] = new SelectList(_context.ListingTypes, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OnApply(ApplyFormModel applyForm)
        {
            if(!ModelState.IsValid)
            {
                TempData["UserMessage"] = JsonConvert.SerializeObject(new AlertComponentModel() { CssClassName = "alert-danger", Text = "Completeaza datele corect si trimite din nou." });
                return RedirectToAction("Apply");
            }

            Listing listing = new Listing
            {
                Name = applyForm.Name,
                Description = applyForm.Description,
                ShortDestription = applyForm.ShortDestription,
                ListingTypeId = applyForm.ListingTypeId,
                SocialmediaList = applyForm.SocialmediaList,
                DateAdded = DateTime.Now,
                IsVisible = false,
                IsAddedBySelf = true
            };

            if (applyForm.File.Length > 0)
            {
                string filePath = Path.Combine(_configuration["StoredFilesPath"], Path.GetRandomFileName() + Guid.NewGuid().ToString() + Path.GetExtension(applyForm.File.FileName));
                using (var stream = System.IO.File.Create(filePath))
                {
                    await applyForm.File.CopyToAsync(stream);
                }
                listing.PhotoURL = filePath;
            }
            else
            {
                TempData["UserMessage"] = JsonConvert.SerializeObject(new AlertComponentModel() { CssClassName = "alert-danger", Text = "Completeaza datele corect si trimite din nou." });
                return RedirectToAction("Apply");
            }

            _context.Listings.Add(listing);
            _ = await _context.SaveChangesAsync();

            TempData["UserMessage"] = JsonConvert.SerializeObject(new AlertComponentModel() { CssClassName = "alert-success", Text = "Am primit aplicatia! O vom evalua in curand." });
            return RedirectToAction("Apply");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
