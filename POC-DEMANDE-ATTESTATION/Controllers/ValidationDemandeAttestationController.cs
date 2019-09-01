using Newtonsoft.Json;
using POC_DEMANDE_ATTESTATION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Services;
using System.Web.Services;

namespace POC_DEMANDE_ATTESTATION.Controllers
{
    public class ValidationDemandeAttestationController : Controller
    {
        // GET: ValidationDemandeAttestation
        public ActionResult Index()
        {



            return View();
        }
        [WebMethod]
        [ScriptMethod]
        public string GetList()
        {
            #region -- ************************************ --
            /*
                List<DemandeAttestation> List = new List<DemandeAttestation>() 
                    {
                      new DemandeAttestation()   { Date= "17/05/2015", NomPrenom="Holande Chirac",Objet="Présidentielles",Statut="Refusée",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      new DemandeAttestation()   { Date= "23/11/2017", NomPrenom="Nicola De Pinprenaux",Objet="Municipale",Statut="En Attente",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Jean-Patrik Bouche-Trou",Objet="Réservation",Statut="<span class='badge badge-light'>Validée</span>",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      //new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Adeline Dubois",Objet="Candidature",Statut="Validéee",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      //new DemandeAttestation()   { Date= "18/03/2016", NomPrenom="Hassan Hasni",Objet="Achat immobilier",Statut="<span class='badge badge-light'>En attente</span>",Controller="ValidationDemandeAttestation",Action="ViewRequest"},
                      //new DemandeAttestation()   { Date= "11/12/2017", NomPrenom="Marie Dbois-Gueneck",Objet="Garde d'enfant",Statut="<span class='badge badge-success'>Validée</span>",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      // new DemandeAttestation()   { Date= "18/03/2016", NomPrenom="Hassan Hasni",Objet="Achat immobilier",Statut="<span class='badge badge-light'>En attente</span>",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      //new DemandeAttestation()   { Date= "11/12/2017", NomPrenom="Marie Dbois-Gueneck",Objet="Garde d'enfant",Statut="<span class='badge badge-success'>Validée</span>",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      //new DemandeAttestation()   { Date= "17/05/2015", NomPrenom="Holande Chirac",Objet="Présidentielles",Statut="<span class='badge badge-danger'>Refusée</span>",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      //new DemandeAttestation()   { Date= "23/11/2017", NomPrenom="Nicola De Pinprenaux",Objet="Municipale",Statut="<span class='badge badge-light'>En attente</span>",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      //new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Jean-Patrik Bouche-Trou",Objet="Réservation",Statut="<span class='badge badge-light'>En attente</span>",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      //new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Adeline Dubois",Objet="Candidature",Statut="<span class='badge badge-success'>Validée</span>",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      //new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Jean-Patrik Bouche-Trou",Objet="Réservation",Statut="<span class='badge badge-light'>En attente</span>",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                      //new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Adeline Dubois",Objet="Candidature",Statut="<span class='badge badge-success'>Validée</span>",Controller="ValidationDemandeAttestation",Action="ViewRequest" },

                };
                return JsonConvert.SerializeObject(List.ToArray());
                */ 
            #endregion

            #region --  Refactor --

            List<DemandeAttestation> List = new List<DemandeAttestation>()
            {
                  new DemandeAttestation()   {
                      Date = "17/05/2015",
                      NomPrenom ="Holande Chirac",
                      Objet ="Présidentielles",
                      Statut ="Refusée",
                      Controller ="ValidationDemandeAttestation",
                      Action ="ViewRequest"
                  },
                  new DemandeAttestation()   {
                      Date = "23/11/2017",
                      NomPrenom ="Nicola De Pinprenaux",
                      Objet ="Municipale",
                      Statut ="En attente",
                      Controller ="ValidationDemandeAttestation",
                      Action ="ViewRequest"
                  },
                  new DemandeAttestation()   {
                      Date = "08/09/2018",
                      NomPrenom ="Jean-Patrik Bouche-Trou",
                      Objet ="Réservation",
                      Statut ="Validée",
                      Controller ="ValidationDemandeAttestation",
                      Action ="ViewRequest"
                  },
                  new DemandeAttestation()   {
                      Date = "08/09/2018",
                      NomPrenom ="Adeline Dubois",
                      Objet ="Candidature",
                      Statut ="Validée",
                      Controller ="ValidationDemandeAttestation",
                      Action ="ViewRequest"
                  },
                  new DemandeAttestation()   {
                      Date = "18/03/2016",
                      NomPrenom ="Hassan Hasni",
                      Objet ="Achat immobilier",
                      Statut ="En attente",
                      Controller ="ValidationDemandeAttestation",
                      Action ="ViewRequest"
                  },
                  new DemandeAttestation()   {
                      Date = "11/12/2017",
                      NomPrenom ="Marie Dbois-Gueneck",
                      Objet ="Garde d'enfant",
                      Statut ="Validée",
                      Controller ="ValidationDemandeAttestation",
                      Action ="ViewRequest"
                  },
               
                  
                  new DemandeAttestation()   {
                      Date = "18/03/2016",
                      NomPrenom ="Hassan Hasni"
                      ,Objet="Achat immobilier",
                      Statut ="En attente",
                      Controller ="ValidationDemandeAttestation",
                      Action ="ViewRequest"
                  },
                  new DemandeAttestation()   {
                      Date = "11/12/2017",
                      NomPrenom ="Marie Dbois-Gueneck",
                      Objet ="Garde d'enfant",
                      Statut ="Validée",
                      Controller ="ValidationDemandeAttestation",
                      Action ="ViewRequest"
                  },
                  new DemandeAttestation()   {
                      Date = "17/05/2015",
                      NomPrenom ="Holande Chirac",
                      Objet ="Présidentielles",
                      Statut ="Refusée",
                      Controller ="ValidationDemandeAttestation",
                      Action ="ViewRequest" },
                  new DemandeAttestation()   {
                      Date = "23/11/2017",
                      NomPrenom ="Nicola De Pinprenaux",
                      Objet ="Municipale",
                      Statut ="En attente",
                      Controller ="ValidationDemandeAttestation",
                      Action ="ViewRequest"
                  },
                  //new DemandeAttestation()   {
                  //    Date = "08/09/2018",
                  //    NomPrenom ="Jean-Patrik Bouche-Trou",
                  //    Objet ="Réservation",
                  //    Statut ="En attente",
                  //    Controller ="ValidationDemandeAttestation",
                  //    Action ="ViewRequest"
                  //},
                  //new DemandeAttestation()   {
                  //    Date = "08/09/2018",
                  //    NomPrenom ="Adeline Dubois",
                  //    Objet ="Candidature",
                  //    Statut ="Validée",
                  //    Controller ="ValidationDemandeAttestation",
                  //    Action ="ViewRequest"
                  //},
                  //new DemandeAttestation()   {
                  //    Date = "08/09/2018",
                  //    NomPrenom ="Jean-Patrik Bouche-Trou",
                  //    Objet ="Réservation",
                  //    Statut ="En attente",
                  //    Controller ="ValidationDemandeAttestation",
                  //    Action ="ViewRequest"
                  //},
                  //new DemandeAttestation()   {
                  //    Date = "08/09/2018",
                  //    NomPrenom ="Adeline Dubois",
                  //    Objet ="Candidature",
                  //    Statut ="Validée",
                  //    Controller ="ValidationDemandeAttestation",
                  //    Action ="ViewRequest"
                  //}
            };
            return JsonConvert.SerializeObject(List.ToArray());
            
            #endregion
        }

        // GET: ValidationDemandeAttestation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ValidationDemandeAttestation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ValidationDemandeAttestation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ValidationDemandeAttestation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ValidationDemandeAttestation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ValidationDemandeAttestation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ValidationDemandeAttestation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: ValidationDemandeAttestation/AllNewRequest
        public ActionResult AllNewRequest()
        {
            return View();
        }

        // GET: ValidationDemandeAttestation/AllValidatedRequest 
        public ActionResult AllValidatedRequest()
        {
            return View();
        }

        // GET: ValidationDemandeAttestation/ViewRequest     
        public ActionResult ViewRequest()
        {
            return View();
        }

        // GET: ValidationDemandeAttestation/ValidatedRequest    
        public ActionResult ValidatedRequest()
        {
            return RedirectToAction("Index");
        }

        // --  Ouverture la popup de refut

    }
}
