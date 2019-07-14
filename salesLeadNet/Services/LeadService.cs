using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using salesLeadNet.Models;
using salesLeadNet.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace salesLeadNet.Services
{
    public class LeadService : ILeadService
    {
        private readonly ApplicationDbContext _context;
        public LeadService(ApplicationDbContext context)
        {
            _context = context;
        }
        Task<Lead[]> ILeadService.GetSalesLeadsAsync()
        {
            //var fakeLead1 = new Lead
            //{
            //    FirstName = "abdikarim",
            //    LastName = "Mohamed",
            //    Phone = "6148064034",
            //    City = "Westerville",
            //    State = "Ohio",
            //    Zip = 43081

            //};
            //var fakeLead2 = new Lead
            //{
            //    FirstName = "Amal",
            //    LastName = "sharif",
            //    Phone = "61477962643",
            //    City = "Columbus",
            //    State = "Ohio",
            //    Zip = 43229

            //};
            //return Task.FromResult(new[] { fakeLead1, fakeLead2 });
            var leads = _context.Leads;
            return leads.ToArrayAsync();
        }
        public async Task<bool> AddLeadAsync(Lead newLead)
        {
            newLead.Id = Guid.NewGuid();

           
            _context.Leads.Add(newLead);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
    }
}
