using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using pc1Laboratorio.Models;
using pc1Laboratorio.Data;

namespace pc1Laboratorio.Controllers
{
    
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.gameStore.ToList());
        }
        public IActionResult Create(){
            return View();
        }
        [HttpPost] 
        public IActionResult Create(Producto objRegistro)
        {
            _context.Add(objRegistro);
            _context.SaveChanges();
            ViewData["Message"] = "El Alumno ya esta Registrado";
            return View();
        }
        
    }
}