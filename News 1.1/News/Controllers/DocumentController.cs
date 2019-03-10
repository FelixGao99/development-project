using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using News.Models;

namespace News.Controllers
{
    public class DocumentController : Controller
    {
        private DocumentDataContext db = new DocumentDataContext();

        //
        // GET: /Document/

        public ActionResult Index()
        {
            return View(db.Documents.ToList());
        }
        //[HttpPost] LinQ语句
        //public ActionResult Index(int? ID)
        //{
        //    var News_BiaoTi = db.News_BiaoTi.Include(M => m.genre);
        //ViewBag.GenreID = new SelectList(db.Genres, "GenreID","strGenre");
        //        if(GenreID == null)
        //    {
        //         news = News.OrderBy(K => K.News_BiaoTi);

        //    }
        //    else
        //{
        //    news - news.Where(g => g.GenreID ==GenreID).OrderBy (k => k.News_BiaoTi)
        //}
        //    return View(Index);
        //}
        //
        // GET: /Document/Details/5

        public ActionResult Details(int id = 0)
        {
            Document document = db.Documents.Find(id);
            if (document == null)
            {
                return HttpNotFound();
            }
            return View(document);
        }

        //
        // GET: /Document/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Document/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Document document)
        {
            if (ModelState.IsValid)
            {
                db.Documents.Add(document);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(document);
        }

        //
        // GET: /Document/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Document document = db.Documents.Find(id);
            if (document == null)
            {
                return HttpNotFound();
            }
            return View(document);
        }

        //
        // POST: /Document/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Document document)
        {
            if (ModelState.IsValid)
            {
                db.Entry(document).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(document);
        }

        //
        // GET: /Document/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Document document = db.Documents.Find(id);
            if (document == null)
            {
                return HttpNotFound();
            }
            return View(document);
        }

        //
        // POST: /Document/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Document document = db.Documents.Find(id);
            db.Documents.Remove(document);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}