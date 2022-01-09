using Microsoft.AspNetCore.Mvc;
using PizaaOrdering.Models;
using PizzaOrdering.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizaaOrdering.Controllers
{
    public class OrderPController : Controller
    {
        private readonly AppDBContext _auc;
        public OrderPController(AppDBContext auc)
        {
            _auc = auc;
        }
        /// <summary>
        /// get method
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult ordering(OrderPizza uc)
        {
            var result = _auc.Ordertabel.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var dobj = _auc.Ordertabel.Where(x => x.Id == Id).FirstOrDefault();
            return View(dobj);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var dobj = _auc.Ordertabel.Where(x => x.Id == Id).FirstOrDefault();
            return View(dobj);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var dobj = _auc.Ordertabel.Where(x => x.Id == Id).FirstOrDefault();
            return View(dobj);
        }
        /// <summary>
        /// Get request
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Create(OrderPizza uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            return RedirectToAction("ordering");
        }

        [HttpPost]
        public IActionResult Edit(OrderPizza uc)
        {
            _auc.Update(uc);
            _auc.SaveChanges();
            return RedirectToAction("ordering");
        }
        [HttpPost]
        public IActionResult Delete(OrderPizza uc)
        {
            _auc.Remove(uc);
            _auc.SaveChanges();

            return RedirectToAction("ordering");
        }
        [HttpPost]
        public IActionResult Details(OrderPizza uc)
        {
            _auc.Remove(uc);
            _auc.SaveChanges();
            return RedirectToAction("ordering");
        }


    }
}
