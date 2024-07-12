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
    public class Nvt_SACHController : Controller
    {
        private NguyenVanThao_2210900125Entities2 db = new NguyenVanThao_2210900125Entities2();

        // GET: Nvt_SACH
        public ActionResult NvtIndex()
        {
            var nvt_SACH = db.Nvt_SACH.Include(n => n.Nvt_TACGIA);
            return View(nvt_SACH.ToList());
        }

        // GET: Nvt_SACH/Details/5
        public ActionResult NvtDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nvt_SACH nvt_SACH = db.Nvt_SACH.Find(id);
            if (nvt_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nvt_SACH);
        }

        // GET: Nvt_SACH/Create
        public ActionResult NvtCreate()
        {
            ViewBag.Nvt_MaTG = new SelectList(db.Nvt_TACGIA, "Nvt_MaTG", "Nvt_TenTG");
            return View();
        }

        // POST: Nvt_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvtCreate([Bind(Include = "Nvt_MaSach,Nvt_TenSach,Nvt_SoTrang,Nvt_NamXB,Nvt_MaTG,Nvt_TrangThai")] Nvt_SACH nvt_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Nvt_SACH.Add(nvt_SACH);
                db.SaveChanges();
                return RedirectToAction("NvtIndex");
            }

            ViewBag.Nvt_MaTG = new SelectList(db.Nvt_TACGIA, "Nvt_MaTG", "Nvt_TenTG", nvt_SACH.Nvt_MaTG);
            return View(nvt_SACH);
        }

        // GET: Nvt_SACH/Edit/5
        public ActionResult NvtEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nvt_SACH nvt_SACH = db.Nvt_SACH.Find(id);
            if (nvt_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Nvt_MaTG = new SelectList(db.Nvt_TACGIA, "Nvt_MaTG", "Nvt_TenTG", nvt_SACH.Nvt_MaTG);
            return View(nvt_SACH);
        }

        // POST: Nvt_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvtEdit([Bind(Include = "Nvt_MaSach,Nvt_TenSach,Nvt_SoTrang,Nvt_NamXB,Nvt_MaTG,Nvt_TrangThai")] Nvt_SACH nvt_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvt_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NvtIndex");
            }
            ViewBag.Nvt_MaTG = new SelectList(db.Nvt_TACGIA, "Nvt_MaTG", "Nvt_TenTG", nvt_SACH.Nvt_MaTG);
            return View(nvt_SACH);
        }

        // GET: Nvt_SACH/Delete/5
        public ActionResult NvtDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nvt_SACH nvt_SACH = db.Nvt_SACH.Find(id);
            if (nvt_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nvt_SACH);
        }

        // POST: Nvt_SACH/Delete/5
        [HttpPost, ActionName("NvtDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NvtDeleteConfirmed(string id)
        {
            Nvt_SACH nvt_SACH = db.Nvt_SACH.Find(id);
            db.Nvt_SACH.Remove(nvt_SACH);
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
