using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCHomeWork.Models;

namespace MVCHomeWork.Controllers
{
    public class View_1Controller : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: View_1
        public ActionResult Index()
        {
            return View(db.View_1.ToList());
        }

        // GET: View_1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            View_1 view_1 = db.View_1.Find(id);
            if (view_1 == null)
            {
                return HttpNotFound();
            }
            return View(view_1);
        }

        // GET: View_1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: View_1/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,客戶名稱,統計銀行數,統計聯絡人數")] View_1 view_1)
        {
            if (ModelState.IsValid)
            {
                db.View_1.Add(view_1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(view_1);
        }

        // GET: View_1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            View_1 view_1 = db.View_1.Find(id);
            if (view_1 == null)
            {
                return HttpNotFound();
            }
            return View(view_1);
        }

        // POST: View_1/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,客戶名稱,統計銀行數,統計聯絡人數")] View_1 view_1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(view_1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(view_1);
        }

        // GET: View_1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            View_1 view_1 = db.View_1.Find(id);
            if (view_1 == null)
            {
                return HttpNotFound();
            }
            return View(view_1);
        }

        // POST: View_1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            View_1 view_1 = db.View_1.Find(id);
            db.View_1.Remove(view_1);
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
