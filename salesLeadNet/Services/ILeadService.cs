using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using salesLeadNet.Models;
using Microsoft.EntityFrameworkCore;
namespace salesLeadNet.Services
{
    public interface ILeadService
    {
        Task<Lead[]> GetSalesLeadsAsync();
        Task<bool> AddLeadAsync(Lead newLead);
    }
}
