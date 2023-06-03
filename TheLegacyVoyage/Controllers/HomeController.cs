using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheLegacyVoyage.Models;

namespace TheLegacyVoyage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            ViewBag.Description = "High Quality Minecraft servers for the last 10+ years!";
            ViewBag.Keywords = "minecraft, server, mc, minecraft server";
            ViewBag.Author = "www.thelegacyvoyage.xyz";
            ViewBag.OgUrl = "https://www.thelegacyvoyage.xyz";
            ViewBag.OgTitle = "The Legacy Voyage";
            ViewBag.OgDescription = "High Quality Minecraft servers for the last 10+ years!";
            ViewBag.OgImage = "https://image";
            ViewBag.ThemeColor = "#12345";

            ViewBag.ServerName = "The Legacy Voyage Network";
            ViewBag.DescriptionText = "High quality dedicated servers for the last 10+ years!";

            ViewBag.DiscordLink = "https://discord.gg/tWFdFsb";
            ViewBag.StoreLink = "https://the-legacy-voyage.tebex.io";

            return View();
        }

        public ActionResult Status()
        {
            ViewBag.DiscordLink = "https://discord.gg/tWFdFsb";
            ViewBag.StoreLink = "https://the-legacy-voyage.tebex.io";

            return View();
        }

        [Authorize]
        public ActionResult StaffApp()
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