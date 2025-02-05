using Microsoft.AspNetCore.Mvc;
using Mob.Models;
using System.Collections.Generic;

namespace consultaClientesMob.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public IActionResult Index()
        {
            return View(clientes);
        }

        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            if (cliente != null)
            {
                clientes.Add(cliente); // Adiciona o cliente na lista
            }

            return RedirectToAction("Index"); // Redireciona para atualizar a lista na View
        }
    }
}
