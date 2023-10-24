﻿using Microsoft.AspNetCore.Mvc;
using PTUDW_05.Models;

namespace PTUDW_05.Controllers
{
    public class ContactController : Controller
    {
        private readonly HarmicContext _context;

        public ContactController(HarmicContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public bool Create(string name, string phone, string email, string message)
        {
            try
            {
                TbContact contact = new TbContact();
                contact.Name = name;
                contact.Phone = phone;
                contact.Email = email;
                contact.Message = message;
                contact.IsRead = 0;
                contact.CreatedDate = DateTime.Now;
                _context.AddAsync(contact);
                _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
