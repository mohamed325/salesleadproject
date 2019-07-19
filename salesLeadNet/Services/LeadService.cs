using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using salesLeadNet.Models;
using salesLeadNet.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace salesLeadNet.Services
{
    /*
   The leadService class 
   contains methods that implements 
   the businiessl logic and database code
*/
    public class LeadService : ILeadService
    {
        //a private variable to hold a reference to database context
        private readonly ApplicationDbContext _context;

        public string[] ContiguousStates { get;} = { "alabama", "arizona", "arkansas", "california", "colorado",
            "connecticut", "delaware", "florida", "georgia", "idaho", "illinois", "indiana", "iowa", "kansas", "kentucky", "louisiana", "Maine", "Maryland",
            "massachusetts", "michigan", "minnesota", "mississippi", "missouri", "montana", "nebraska", "nevada", "new hampshire", "new jersey",
            "new mexico", "new york", "north carolina", "north dakota", "ohio", "oklahoma", "oregon", "pennsylvania", "rhode island", "south carolina",
            "south dakota", "tennessee", "texas", "utah", "vermont", "virginia", "washington", "west virginia", "wisconsin", "wyoming", "ak", "ar", "az",
            "ca", "co", "ct", "de", "fl", "ga", "ia", "id", "il", "in", "ks", "ky", "la", "ma", "md", "me",
              "mi", "mn", "mo", "ms", "mt", "nc", "nd", "ne", "nh", "nj", "nm", "nv", "ny", "ok", "oh", "or", "pa", "ri",
              "sc", "sd", "tn", "tx", "ut", "va", "vt", "wa", "wi", "wv", "wy" };

        // injecct context from the service container
        public LeadService(ApplicationDbContext context)
        {
            _context = context;
           
        }
        //get leads from database, sort and returnit is an array
        Task<Lead[]> ILeadService.GetSalesLeadsAsync()
        {
            //get leads sorted by who is more likely to buy
            var leads = _context.Leads.OrderByDescending(x => x.BuyIdicator);
            //put ohio leads on top of the list
            var leadsOhioTop = leads.OrderByDescending(x => x.State.ToLower().Equals("oh") || x.State.ToLower().Equals("ohio"));
            //select all sorted leads, ignoring those ineligble, and return as array list
            return leadsOhioTop.Where(x => x.BuyIdicator > 0).ToArrayAsync();

        }
        //add leads into the database and return true if
        //successfully saved into the database
        public async Task<bool> AddLeadAsync(Lead newLead)
        {

           
            //get lead with buying idicator updated
            Lead salesLead = AddBuyingIndicator(newLead);

            //add the primary key id before saving to the database
                salesLead.Id = Guid.NewGuid();

            //add lead to the database table
                _context.Leads.Add(salesLead);
            //get the status of if teh data is saved
               var result = await _context.SaveChangesAsync();
            //return true if saved or false if not
            return result == 1;
        }
        /*
 AddBuyingIndicator updates each leads' indicator field 
  Uses 5 different base to increment the buyindictor field based on 
 the key indictors of leads buying.
*/
        private Lead AddBuyingIndicator(Lead newLead)
        {
            //rate 0 - 4 who is likely to buy
            //with 0 being ineligible and 4 highly likely to buy
            int ineligible = 0;
            int byCarrierPigeon = 1;
            int byEmailOrSms = 2;
            int byPhone = 3;
            int highlyLikely = 4;

            //if newlead's state is within the 48 states procede
            //rest of the logic otherwise with buyincator to zero and return
            if (Array.Exists(ContiguousStates, element => element.Equals(newLead.State.ToLower()))){


                //if newlead zip starts with 7 
                //increment Buyindictor with highlyLikely rate
                if (newLead.Zip.StartsWith('7'))
                {
                    newLead.BuyIdicator += highlyLikely;
                }
                //if newlead name has z 
                //increment Buyindictor with highlyLikely rate
                if (newLead.Name.ToLower().Contains('z'))
                {
                    newLead.BuyIdicator += highlyLikely;
                }
                //if newlead choose phone as contact
                //increment Buyindictor with byphone rate
                if (newLead.ContactMethod == ContactMethod.Phone)
                {
                    newLead.BuyIdicator += byPhone;
                }
                //if newlead choose email or sms as contact
                //increment Buyindictor with byemailorSms rate
                if (newLead.ContactMethod == ContactMethod.Email || newLead.ContactMethod == ContactMethod.Sms)
                {
                    newLead.BuyIdicator += byEmailOrSms;
                }
                //if newlead choose email or CarrierPigeon as contact
                //increment Buyindictor with byCarrierPigeon rate
                if (newLead.ContactMethod == ContactMethod.CarrierPigeon)
                {
                    newLead.BuyIdicator += byCarrierPigeon;
                }
            }
            else
            {
                //if new lead is not in the 48 states not eligible to buy
                newLead.BuyIdicator = ineligible;
            }
            return newLead;
        }
    }
}
