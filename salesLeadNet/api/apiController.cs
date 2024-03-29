﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using salesLeadNet.Services;
using salesLeadNet.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace salesLeadNet.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        private readonly ILeadService _salesLeadService;
        public ApiController(ILeadService salesLeadService)
        {
            _salesLeadService = salesLeadService;
        }
        // GET: api/values
        [Route("~/api/getleads")]
        [HttpGet]
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
            return Json(model);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       
        [HttpPost]

        [Route("~/api/addlead")]
        public async Task<IActionResult> AddLead([Bind("Name,Phone,City,State,Zip,ContactMethod")] Lead newLead)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var successful = await _salesLeadService.AddLeadAsync(newLead);
            if (!successful)
            {
                return BadRequest("Could not add sales lead.");
            }
            return CreatedAtAction("Get", new { id = newLead.Id }, newLead);
        }

       
    }
}
