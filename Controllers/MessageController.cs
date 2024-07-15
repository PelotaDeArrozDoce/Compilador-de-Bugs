using Microsoft.AspNetCore.Mvc;
using Compilador_de_Bugs.Models;
using System.Collections.Generic;

namespace Compilador_de_Bugs.Controllers
{
    public class MessageController : Controller
    {

        private static List<Message> messages = new List<Message>();

        [HttpGet]
        public IActionResult Index()
        {
            return View(messages);
        }
        [HttpPost]
        public IActionResult Index(Message message)
        {
            messages.Add(message);

            return View(messages);
        }
        public IActionResult Mensagem()
        {
            return View();
        }

    }
}