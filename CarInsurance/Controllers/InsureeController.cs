using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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

        //adds Admin to views
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

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
            if (ModelState.IsValid)
            {
                //gets current date
                var currentDate = DateTime.Today;
                //gets user age
                int userAge = insuree.DateOfBirth.Year;
                //subtracts date of birth year from current date year to get age
                userAge = currentDate.Year - insuree.DateOfBirth.Year;

                //starts quote at $50
                insuree.Quote = 50m;

                //Creates if statements adding $100 to customers 18 or under
                if (userAge <=18)
                {
                    insuree.Quote += 100;
                }
                //if statement for age if between 19 to 25 adding $50 monthly total
                if (userAge >= 19 && userAge <= 25)
                {
                    insuree.Quote += 50;
                }
                //if statement for users 26 or over and adds $25
                if (userAge >= 26)
                {
                    insuree.Quote += 25;
                }
                //if car year is before 2000 adds 25 dollars
                if (insuree.CarYear < 2000)
                {
                    insuree.Quote += 25;
                }
                //if car year after 2015 adds 25
                if (insuree.CarYear > 2015)
                {
                    insuree.Quote += 25;
                }
                //if porsche adds 25
                if (insuree.CarMake == "Porsche")
                {
                    insuree.Quote += 25;
                    //if model 911 carrera add extra 25
                    if(insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                    {
                        insuree.Quote += 25;
                    }
                }
                //for every ticket adds $10
                if (insuree.SpeedingTickets > 0)
                {
                    insuree.Quote += insuree.SpeedingTickets * 10;
                }
                //if bool for adding 25% to the total
                if (insuree.DUI == true)
                {
                    insuree.Quote = Convert.ToDecimal(insuree.Quote * 1.25m);
                }
                //if full coverage adds 50%
                if (insuree.CoverageType == true)
                {
                    insuree.Quote = Convert.ToDecimal(insuree.Quote * 1.5m);
                }

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
    }
}
