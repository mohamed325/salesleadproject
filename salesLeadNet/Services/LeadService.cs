using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using salesLeadNet.Models;
namespace salesLeadNet.Services
{
    public class LeadService : ILeadService
    {
        public Task<Lead[]> GetSalesLeadsAsync()
        {
            var fakeLead1 = new Lead
            {
                FirstName = "abdikarim",
                LastName = "Mohamed",
                Phone = "6148064034",
                City = "Westerville",
                State = "Ohio",
                Zip = 43081
                
            };
            var fakeLead2 = new Lead
            {
                FirstName = "Amal",
                LastName = "sharif",
                Phone = "61477962643",
                City = "Columbus",
                State = "Ohio",
                Zip = 43229

            };
            return Task.FromResult(new[] { fakeLead1, fakeLead2 });
        }
    }
}
