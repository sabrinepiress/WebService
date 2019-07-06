using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebService.Models;

namespace WebService.Controllers
{
    public class ZipcodeController : Controller
    {
        /*
         * Alunos:
         * Elizandra Tomazzelli
         * Hyanca Moura
         * Kevin Noviski
         * Sabrine Pires
         */
        private readonly Context _context;
        public ZipcodeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //recupera do banco e mostra na view
            return View(_context.Zipcode);
        }

        public IActionResult ConsultarZipcode(string Cep)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("https://viacep.com.br/ws/"+Cep+"/json/");
            Zipcode cep = JsonConvert.DeserializeObject<Zipcode>(json);
            _context.Zipcode.Add(cep);
            _context.SaveChanges();

            //gravar objeto no banco
            return RedirectToAction("Index");
        }
       
    }
}