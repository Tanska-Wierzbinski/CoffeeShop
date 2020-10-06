using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Application.DTOs.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class OrderController : Controller
    {
        // GET: OrderController
        public ActionResult Index()
        {
            //WYSWIETLIC GIGANT GUZIOL DO ZLOZENIA ZAMOWIENIA ------------------------------
            return View();
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            //WYSWIETLIC PANEL Z KAWAMI DO WYBORU -----------------------------------------
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddOrderDto newOrder, IFormCollection collection)
        {
            //var result = await _orderService.AddPost(newOrder);
            //return RedirectToAction(nameof(Details), new {detailsOrder = result});
             
        }

        // GET: OrderController/Details/5
        public ActionResult Details(DetailsOrderDto detailsOrder)
        {
            //WYSWIETLIC WSZYSTKIE ZAMOWIONE KAWY ZE SZCZEGOLAMI I CENAMI-----------------
            //MOZLIWOSC NAPIWKU ----------------------------------------------------------
            //MOZLIWOSC EDYCJI WYBRANYCH KAW----------------------------------------------
            return View();
        }

        // GET: OrderController/Summary/5
        public ActionResult Summary(int id)
        {
            //WYSWIETLIC WSZYSTKIE NR ZAMOWIENIA------------------------------------------
            //CZAS OCZEKIWANIA------------------------------------------------------------
            //KWOTE DO ZAPLATY------------------------------------------------------------
            return View();
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
