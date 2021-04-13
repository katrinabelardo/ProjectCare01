using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectCare01.Data;
using ProjectCare01.Models;

namespace ProjectCare01.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDBContext _context;
        public OrderController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Orders.ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Order record)
        {
            var order = new Order();
            order.OrderName = record.OrderName;
            order.Description = record.Description;
            order.Price = record.Price;
            order.DateAdded = record.DateAdded;
            order.Type = record.Type;

            _context.Orders.Add(order);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit (int? id)
        {
            if (id ==null)
            {
                return Redirect("Index");
            }
            var order = _context.Orders.Where(i => i.OrderID == id).SingleOrDefault();
            if (order==null)
            {
                return RedirectToAction("Index");
            }
            return View(order);
        }
        [HttpPost]
        public IActionResult Edit (int? id, Order record)
        {
            var order = _context.Orders.Where(i => i.OrderID == id).SingleOrDefault();
            order.OrderName = record.OrderName;
            order.Description = record.Description;
            order.Price = record.Price;
            order.DateModified = DateTime.Now;
            order.Type = record.Type;

            _context.Orders.Update(order);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("Index");
            }
            var order = _context.Orders.Where(i => i.OrderID == id).SingleOrDefault();
            if (order==null)
            {
                return RedirectToAction("Index");
            }
            _context.Orders.Remove(order);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
