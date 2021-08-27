using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Risto.Core;
using Risto.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Risto.MVC.Controllers
{
    [Authorize]
    public class PiattoController : Controller
    {
        private readonly IBusinessLayer bl;

        public PiattoController(IBusinessLayer businessLayer)
        {
            this.bl = businessLayer;
        }

        [Route("Pia/Index", Order = 1)]
        [Route("PiattoIndex", Order = 2)]
        public IActionResult Index()
        {
            var model = bl.FetchPiatti();
            return View(model);
        }

        [HttpGet("pia/details/{id}")]
        public IActionResult Details(int id)
        {
            if (id <= 0)
            {
                return View("Error", new ErrorViewModel());
            }

            var pia = bl.GetPiattoById(id);

            if (pia == null)
            {
                return View("NotFound", new NotFoundViewModel()
                {
                    EntityId = id,
                    Message = "Something wrong"
                });
            }
            return View(pia);
        }

        [Authorize(Policy = "AccountRistoratore")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Policy = "Account")]
        [HttpPost]
        public IActionResult Create(PiattoViewModel data)
        {
            if (data == null)
            {
                return View("Error", new ErrorViewModel());
            }
            if (ModelState.IsValid)
            {
                PiattoResult result = bl.AddNewPiatto(new Piatto
                {
                    Nome = data.Nome,
                    Descrizione = data.Descrizione,
                    Tipologia = data.Tipologia,
                    Prezzo = data.Prezzo
                });
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return View("Error", new ErrorViewModel());
            }

            var model = bl.GetPiattoById(id);
            if (model == null)
            {
                return View("NotFound", new NotFoundViewModel { EntityId = id, Message = "Sorry, not found" });
            }
            var piaViewModel = new PiattoViewModel
            {
                Id = model.ID,
                Nome = model.Nome,
                Descrizione = model.Descrizione,
                Tipologia = model.Tipologia,
                Prezzo = model.Prezzo
            };
            return View(piaViewModel);
        }

        [HttpPost]
        public IActionResult Edit(PiattoViewModel model)
        {
            if (model == null)
            {
                return View("Error", new ErrorViewModel());
            }
            if (ModelState.IsValid)
            {
                var result = bl.EditPiatto(new Piatto
                {
                    ID = model.Id,
                    Nome = model.Nome,
                    Descrizione = model.Descrizione,
                    Tipologia = model.Tipologia,
                    Prezzo = model.Prezzo
                }
                );
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        public IActionResult Delete(int id)
        {
            var model = bl.GetPiattoById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Piatto data)
        {
            var piaToDelete = bl.GetPiattoById(data.ID);

            var result = bl.DeletePiatto(piaToDelete);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
