using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using wardrobeProject_test1.Models;

namespace wardrobeProject_test1.Controllers
{
    public class ShoesModelsController : Controller
    {
        public ActionResult ManageShoes()
        {
            return View(db.ShoesModels.ToList());
        }

       
        private wardrobeProject_test1Context db = new wardrobeProject_test1Context();

        // GET: ShoesModels
        public ActionResult Index()
        {
            return View(db.ShoesModels.ToList());
        }

        // GET: ShoesModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoesModel shoesModel = db.ShoesModels.Find(id);
            if (shoesModel == null)
            {
                return HttpNotFound();
            }
            return View(shoesModel);
        }

        // GET: ShoesModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoesModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShoeID,Nickname,Photo,Type,Color,Season,Occasion")] ShoesModel shoesModel)
        {
            if (ModelState.IsValid)
            {
                db.ShoesModels.Add(shoesModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shoesModel);
        }

        // GET: ShoesModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoesModel shoesModel = db.ShoesModels.Find(id);
            if (shoesModel == null)
            {
                return HttpNotFound();
            }
            return View(shoesModel);
        }

        // POST: ShoesModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShoeID,Nickname,Photo,Type,Color,Season,Occasion")] ShoesModel shoesModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shoesModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shoesModel);
        }

        // GET: ShoesModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoesModel shoesModel = db.ShoesModels.Find(id);
            if (shoesModel == null)
            {
                return HttpNotFound();
            }
            return View(shoesModel);
        }

        // POST: ShoesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShoesModel shoesModel = db.ShoesModels.Find(id);
            db.ShoesModels.Remove(shoesModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
