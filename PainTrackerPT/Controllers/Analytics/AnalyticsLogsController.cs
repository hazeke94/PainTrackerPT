using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Data.Analytics;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Analytics;

namespace PainTrackerPT.Controllers
{
    public class AnalyticsLogsController : Controller
    {
        
        private readonly IGinyuGateway _gateway;
        private readonly IGFPatientGateway _patientGateway;

        public AnalyticsLogsController(IGinyuGateway gateway, IGFPatientGateway _patient)
        {
            _gateway = gateway;
            _patientGateway = _patient;
        }

        // GET: AnalyticsLogs
        public async Task<IActionResult> Index()
        {
            //Currently Retrieving a specific user information for testing    
            //return View(_gateway.SelectAll());
            return View(_patientGateway.SelectById(1));
        }

        // GET: AnalyticsLogs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analyticsLog = _gateway.Find(id);

            if (analyticsLog == null)
            {
                return NotFound();
            }

            return View(analyticsLog);
        }

        // GET: AnalyticsLogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnalyticsLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,timeStamp")] AnalyticsLog analyticsLog)
        {
            if (ModelState.IsValid)
            {
                analyticsLog.Id = Guid.NewGuid();
                
                _gateway.Insert(analyticsLog);
                _gateway.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(analyticsLog);
        }

        // GET: AnalyticsLogs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
           
            var analyticsLog = _gateway.Find(id);
            if (analyticsLog == null)
            {
                return NotFound();
            }
            return View(analyticsLog);
        }

        // POST: AnalyticsLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Description,timeStamp")] AnalyticsLog analyticsLog)
        {
            if (id != analyticsLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _gateway.Update(analyticsLog);
                    _gateway.Save();
                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnalyticsLogExists(analyticsLog.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(analyticsLog);
        }

        // GET: AnalyticsLogs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analyticsLog = _gateway.Find(id);
            if (analyticsLog == null)
            {
                return NotFound();
            }

            return View(analyticsLog);
        }

        // POST: AnalyticsLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {            
            _gateway.Delete(id);
            _gateway.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool AnalyticsLogExists(Guid id)
        {
            return _gateway.Exist(id);
        }
    }
}
