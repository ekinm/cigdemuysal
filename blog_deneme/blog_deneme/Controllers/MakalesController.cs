using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using blog_deneme.Veritabani;
using PagedList;
using PagedList.Mvc;

namespace blog_deneme.Controllers
{
    public class MakalesController : Controller
    {
        private blogContext db = new blogContext();

       
        public ActionResult Index(string FindBy, string Find, int? page)
        {
            if (FindBy == "Icerik")
            {
                return View(db.Makale.Where(x => x.Icerik == Find || Find == null).ToList().ToPagedList(page ?? 1, 3));
            }

            else
            {
                return View(db.Makale.Where(x => x.Baslik.StartsWith(Find) || Find == null).ToList().ToPagedList(page ?? 1, 3));
            }


        }

        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makale makale = db.Makale.Find(id);
            if (makale == null)
            {
                return HttpNotFound();
            }
            return View(makale);
        }

       
        public ActionResult Create()
        {
            return View();
        }

      
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Baslik,Ozet,Icerik,Tarih,Url")] Makale makale)
        {
            if (ModelState.IsValid)
            {
                db.Makale.Add(makale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(makale);
        }

    
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makale makale = db.Makale.Find(id);
            if (makale == null)
            {
                return HttpNotFound();
            }
            return View(makale);
        }

       
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Baslik,Ozet,Icerik,Tarih,Url")] Makale makale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(makale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(makale);
        }

        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makale makale = db.Makale.Find(id);
            if (makale == null)
            {
                return HttpNotFound();
            }
            return View(makale);
        }

        // POST: Makales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Makale makale = db.Makale.Find(id);
            db.Makale.Remove(makale);
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
