using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using salesLeadNet.Services;
using salesLeadNet.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
    }
}
