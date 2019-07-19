using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace salesLeadNet.Models
{
    //display name string instead of the enum value
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContactMethod
    {
        Email,Phone,Sms,CarrierPigeon
    }

    /*
  The lead class 
  Contains all the database lead entity properties with some
  validation  
*/
    public class Lead
    {
        //hiding id during serilaztion
        [IgnoreDataMember]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must provide a phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        public string State { get; set; }
        [StringLength(25)]
        public string City { get; set; }
        [Required(ErrorMessage = "Zip is Required")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }
        [Display(Name = "Preferred contact method")]
        public ContactMethod? ContactMethod { get; set;}

        //hide secret idictor during serilization
        [IgnoreDataMember]
        public int BuyIdicator { get; set; }

    }
}
