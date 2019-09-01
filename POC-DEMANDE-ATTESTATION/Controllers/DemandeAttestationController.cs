using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POC_DEMANDE_ATTESTATION.Controllers
{
    public class DemandeAttestationController : Controller
    {
        // GET: DemandeAttestation
        public ActionResult Index()
        {
            Session["Menu1"] = "Attestation De Travail";
            Session["Menu2"] = "Consultation Liste Des Demandes";
            return View();
        }

        // GET: DemandeAttestation/Details/5
        public ActionResult Details(int id)
        {
            Session["Menu1"] = "Attestation De Travail";
            Session["Menu2"] = "Détail Demande";
            return View();
        }

        // GET: DemandeAttestation/Create
        public ActionResult Create()
        {
            Session["Menu1"] = "Attestation De Travail";
            Session["Menu2"] = "Nouvelle Demande";
            return View();
        }

        // POST: DemandeAttestation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Session["Menu1"] = "Attestation De Travail";
                Session["Menu2"] = "Nouvelle Demande";
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DemandeAttestation/Edit/5
        public ActionResult Edit(int id)
        {
            Session["Menu1"] = "Attestation De Travail";
            Session["Menu2"] = "Modifier une Demande";
            return View();
        }

        // POST: DemandeAttestation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Session["Menu1"] = "Attestation De Travail";
                Session["Menu2"] = "Modifier une Demande";
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DemandeAttestation/Delete/5
        public ActionResult Delete(int id)
        {
            Session["Menu1"] = "Attestation De Travail";
            Session["Menu2"] = "Annuler une Demande";
            return View();
        }

        // POST: DemandeAttestation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Session["Menu1"] = "Attestation De Travail";
                Session["Menu2"] = "Annuler une Demande";
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
