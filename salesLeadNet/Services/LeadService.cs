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

            var leads = _context.Leads.OrderByDescending(x => x.BuyIdicator);

            var leadsOhioTop = leads.OrderByDescending(x => x.State.ToString().Equals("OH"));

            return leadsOhioTop.Where(x => x.BuyIdicator > 0).ToArrayAsync();

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
            int ineligible = 0;
            int byCarrierPigeon = 1;
            int byEmailOrSms = 2;
            int byPhone = 3;
            int highlyLikely = 4;

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
            if (newLead.ContactMethod == ContactMethod.Email || newLead.ContactMethod == ContactMethod.Sms)
            {
                newLead.BuyIdicator += byEmailOrSms;
            }
           
            if (newLead.ContactMethod == ContactMethod.CarrierPigeon)
            {
                newLead.BuyIdicator += byCarrierPigeon;
            }

            if (newLead.State == State.AL || newLead.State == State.HI)
            {
                newLead.BuyIdicator = ineligible;
            }
            return newLead;
        }
    }
}
