using System;

using System.ComponentModel.DataAnnotations;
namespace salesLeadNet.Models
{
    public enum ContactMethod
    {
        Email,Phone,Sms,CarrierPigeon
    }
   
    public class Lead
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public ContactMethod? ContactMethod { get; set;}

    }
}
