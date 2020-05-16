using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFC_1.Models;

using Microsoft.EntityFrameworkCore;

namespace EFC_1.Controllers
{
    public class HomeController : Controller
    {
        //variable de solo lectura
        private readonly AppDbContext contexto;

        public HomeController(AppDbContext con ){
            this.contexto = con;
        } 
        //como la llamada a ToListAsync tenemos que poner el metodo asincrono
        public async Task<IActionResult> Index()
        {
            // ToListAsync() nos devolvera todos los registros 
            var clientes = await contexto.Clientes.ToListAsync();
            return View(clientes);
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
