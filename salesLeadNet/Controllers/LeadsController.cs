﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using salesLeadNet.Services;
using salesLeadNet.Models;
using Microsoft.AspNetCore.Mvc;



namespace salesLeadNet.Controllers
{
    public class LeadsController : Controller
    {
        private readonly ILeadService _salesLeadService;
        public LeadsController(ILeadService salesLeadService)
        {
            _salesLeadService = salesLeadService;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            //get sales lead from database
            var salesLeads = await _salesLeadService.GetSalesLeadsAsync();

            //put sales lead into a model
            var model = new LeadViewModel()
            {
                Leads = salesLeads
        };
            //pass the view to a model and render
            return View(model);
        }
        //get create form
        public IActionResult Create()
        {
            return View();
        }

        //post data
         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddLead([Bind("Name,Phone,City,State,Zip,ContactMethod")] Lead newLead)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _salesLeadService.AddLeadAsync(newLead);
            if (!successful)
            {
                return BadRequest("Could not add sales lead.");
            }
            return RedirectToAction("Index");
        }
    }
}
