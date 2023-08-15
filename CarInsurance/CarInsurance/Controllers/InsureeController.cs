using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            // Setting base price
            double cost = 50;

            // Logic to calculate cost for user age
            DateTime rightNow = DateTime.Now;
            DateTime ageCheckYoung = rightNow.AddYears(-18);
            DateTime ageCheckOld = rightNow.AddYears(-25);
            int ageDifferenceYoung = DateTime.Compare(ageCheckYoung, insuree.DateOfBirth);
            int ageDifferenceOld = DateTime.Compare(ageCheckOld, insuree.DateOfBirth);
            if (ageDifferenceYoung <= 0)
            {
                cost += 100;
            }
            else if ((ageDifferenceYoung > 0) && (ageDifferenceOld <= 0))
            {
                cost += 50;
            }
            else
            {
                cost += 25;
            }

            // Logic to calculate cost for car age
            if ((insuree.CarYear < 2000) || (insuree.CarYear > 2015))
            {
                cost += 25;
            }

            // Logic to calculate cost for Porsche
            if (insuree.CarMake.ToLower() == "porsche")
            {
                cost += 25;
                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    cost += 25;
                }
            }

            // Logic to calculate cost for speeding tickets
            int speedFee = insuree.SpeedingTickets * 10;
            cost += speedFee;

            // Logic to calculate cost for DUI
            bool DUICheck = insuree.DUI;
            if (DUICheck) { cost = cost * 1.25; }

            // Logic to calculate cost for Full Coverage
            bool fullCoverage = insuree.CoverageType;
            if (fullCoverage) { cost = cost * 1.5; }

            insuree.Quote = Convert.ToInt32(cost);

            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var insureeList = new List<Insuree>();
                foreach (var insuree in insurees)
                {
                    var Insuree = new Insuree();
                    Insuree.Id = insuree.Id;
                    Insuree.FirstName = insuree.FirstName;
                    Insuree.LastName = insuree.LastName;
                    Insuree.EmailAddress = insuree.EmailAddress;
                    Insuree.Quote = insuree.Quote;
                    insureeList.Add(Insuree);
                }
                return View(insureeList);
            }
                
        }
    }
}
