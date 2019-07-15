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
            return leads.OrderByDescending(x => x.BuyIdicator).ToArrayAsync();
        }
        public async Task<bool> AddLeadAsync(Lead newLead)
        {
           Lead salesLead = AddBuyingIndicator(newLead);
           salesLead.Id = Guid.NewGuid();
            _context.Leads.Add(salesLead);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
       private Lead AddBuyingIndicator(Lead newLead)
        {
            int highlyLikely = 5;
            int byPhone = 4;
            int byEmailOrSms = 3;
            int byCarrierPigeon = 2;
            int livesOhio = 1;
            int ineligible = 0;

            if (newLead.Zip.StartsWith('7'))
            {
                newLead.BuyIdicator += highlyLikely;
            }
            if (newLead.Name.ToLower().Contains('z'))
            {
                newLead.BuyIdicator += highlyLikely;
            }
            if (newLead.ContactMethod == ContactMethod.Phone)
            {
                newLead.BuyIdicator += byPhone;
            }
            if (newLead.ContactMethod == ContactMethod.Email)
            {
                newLead.BuyIdicator += byEmailOrSms;
            }
            if (newLead.ContactMethod == ContactMethod.Sms)
            {
                newLead.BuyIdicator += byEmailOrSms;
            }
            if (newLead.ContactMethod == ContactMethod.CarrierPigeon)
            {
                newLead.BuyIdicator += byCarrierPigeon;
            }
            if (newLead.State == State.OH)
            {
                newLead.BuyIdicator += livesOhio;
            }
            if (newLead.State == State.Other || newLead.State == State.AL || newLead.State == State.HI)
            {
                newLead.BuyIdicator = ineligible;
            }
            return newLead;
        }
    }
}
