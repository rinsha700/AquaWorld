using AquaWorld.Models;
using AquaWorld.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AquaWorld.Controllers
{
    public class AquaController : Controller
    {
        IAquaService AquaService;
        public AquaController(IAquaService AquaService)
        {
            this.AquaService = AquaService;
        }
        // GET: AquaController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddFish(Aqua newAqua)
        {
            AquaService.Add(newAqua);
            
            return View();
        }


    }
}

