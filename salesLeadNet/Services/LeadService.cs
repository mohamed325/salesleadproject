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
