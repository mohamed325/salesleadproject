using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using salesLeadNet.Models;
using Microsoft.EntityFrameworkCore;
namespace salesLeadNet.Services
{
    /*
    The IleadService interface 
    Contains all method definition for leadservice class
    that implements the businiessl logic and database code
*/
    public interface ILeadService
    {
        //definition for mehtod that return sorted leads
        Task<Lead[]> GetSalesLeadsAsync();
        //defintion that adds leads to the database
        Task<bool> AddLeadAsync(Lead newLead);
       
    }
}
