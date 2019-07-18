using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace salesLeadNet.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContactMethod
    {
        Email,Phone,Sms,CarrierPigeon
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum State
    {
        AL, AK, AR, AZ, CA, CO, CT, DC, DE, FL, GA, HI,
        IA, ID, IL, IN, KS, KY, LA, MA, MD, ME, MI, MN, MO, MS, MT, NC, ND, NE, NH, NJ, NM,
        NV, NY, OK, OH, OR, PA, RI, SC, SD, TN, TX, UT, VA, VT, WA, WI, WV, WY

    }

    public class Lead
    {
        [IgnoreDataMember]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must provide a phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        public State? State { get; set; }
        [StringLength(25)]
        public string City { get; set; }
        [Required(ErrorMessage = "Zip is Required")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }
        [Display(Name = "Preferred contact method")]
        public ContactMethod? ContactMethod { get; set;}
        [IgnoreDataMember]

        public int BuyIdicator { get; set; }

    }
}
