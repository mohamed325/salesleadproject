using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using salesLeadNet.Models;
namespace salesLeadNet.Services
{
    public interface ILeadService
    {
        Task<Lead[]> GetSalesLeadsAsync();
    }
}
