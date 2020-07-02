using System;
using System.ComponentModel.DataAnnotations;

namespace LettingAgent.Models
{
    public class Property
    {
        public int Id { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string PostCode { get; set; }

        public string PictureUrl { get; set; }
        public int DepositAmount { get; set; }
        public int Rent { get; set; }
        public int NumberOfBedrooms { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime AvailableDate { get; set; }
    }
}

