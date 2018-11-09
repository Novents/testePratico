using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestePratico.Data;
using TestePratico.Models;

namespace TestePratico.Controllers
{
    public class EstabelecimentoController : Controller
    {
        private TestePraticoContext db = new TestePraticoContext();

        // GET: Estabelecimento
        public ActionResult Index()
        {
            return View(db.Estabelecimento.ToList());
        }

        // GET: Estabelecimento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(estabelecimento);
        }

        // GET: Estabelecimento/Create
        public ActionResult Create()
        {
            Estabelecimento est = new Estabelecimento();
            return View(est);
        }

        // POST: Estabelecimento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "estabelecimentoID, razao_social, fantasia, cnpj, email, endereco, cidade, estado, telefone, data_cadastro, categoriaID, status, agencia, conta")] Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                db.Estabelecimento.Add(estabelecimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estabelecimento);
        }

        // GET: Estabelecimento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(estabelecimento);
        }

        // POST: Estabelecimento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "estabelecimentoID,razao_social,fantasia,cnpj,email,endereco,cidade,estado,telefone,data_cadastro,categoria,status,agencia,conta")] Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estabelecimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estabelecimento);
        }

        // GET: Estabelecimento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(estabelecimento);
        }

        // POST: Estabelecimento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            db.Estabelecimento.Remove(estabelecimento);
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
