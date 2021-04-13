using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectCare01.Data;
using ProjectCare01.Models;

namespace ProjectCare01.Controllers
{
	public class ContactUs : Controller
	{
		private readonly ApplicationDBContext _context;

		public ContactUs(ApplicationDBContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
