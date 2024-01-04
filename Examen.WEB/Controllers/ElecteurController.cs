using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.WEB.Controllers
{
    public class ElecteurController : Controller
    {
        IElecteurService electeurService;

        public ElecteurController(IElecteurService electeurService)
        {
            this.electeurService = electeurService;
        }

        // GET: ElecteurController
        public ActionResult Index()
        {
            return View(electeurService.GetAll());
        }

        // GET: ElecteurController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ElecteurController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ElecteurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Electeur electeur)
        {
            try
            {
                electeurService.Add(electeur);
                electeurService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ElecteurController/Edit/5
        public ActionResult Edit(int id)
        {

            return View(electeurService.GetById(id));
        }

        // POST: ElecteurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Electeur electeur)
        {
            try
            {
                electeur.ElecteurId=id;
                electeurService.Update(electeur);
                electeurService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ElecteurController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(electeurService.GetById(id));
        }

        // POST: ElecteurController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Electeur electeur)
        {
            try
            {
                electeur.ElecteurId = id;
                electeurService.Delete(electeur);
                electeurService.Commit();                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
