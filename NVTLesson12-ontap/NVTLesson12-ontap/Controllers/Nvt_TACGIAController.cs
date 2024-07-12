using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NVTLesson12_ontap.Models;

namespace NVTLesson12_ontap.Controllers
{
    public class Nvt_TACGIAController : Controller
    {
        private NguyenVanThao_2210900125Entities2 db = new NguyenVanThao_2210900125Entities2();

        // GET: Nvt_TACGIA
        public ActionResult NvtIndex()
        {
            return View(db.Nvt_TACGIA.ToList());
        }

        // GET: Nvt_TACGIA/Details/5
        public ActionResult NvtDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nvt_TACGIA nvt_TACGIA = db.Nvt_TACGIA.Find(id);
            if (nvt_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nvt_TACGIA);
        }

        // GET: Nvt_TACGIA/Create
        public ActionResult NvtCreate()
        {
            return View();
        }

        // POST: Nvt_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvtCreate([Bind(Include = "Nvt_MaTG,Nvt_TenTG")] Nvt_TACGIA nvt_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Nvt_TACGIA.Add(nvt_TACGIA);
                db.SaveChanges();
                return RedirectToAction("NvtIndex");
            }

            return View(nvt_TACGIA);
        }

        // GET: Nvt_TACGIA/Edit/5
        public ActionResult NvtEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nvt_TACGIA nvt_TACGIA = db.Nvt_TACGIA.Find(id);
            if (nvt_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nvt_TACGIA);
        }

        // POST: Nvt_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvtEdit([Bind(Include = "Nvt_MaTG,Nvt_TenTG")] Nvt_TACGIA nvt_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvt_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NvtIndex");
            }
            return View(nvt_TACGIA);
        }

        // GET: Nvt_TACGIA/Delete/5
        public ActionResult NvtDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nvt_TACGIA nvt_TACGIA = db.Nvt_TACGIA.Find(id);
            if (nvt_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nvt_TACGIA);
        }

        // POST: Nvt_TACGIA/Delete/5
        [HttpPost, ActionName("NvtDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Nvt_TACGIA nvt_TACGIA = db.Nvt_TACGIA.Find(id);
            db.Nvt_TACGIA.Remove(nvt_TACGIA);
            db.SaveChanges();
            return RedirectToAction("NvtIndex");
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
