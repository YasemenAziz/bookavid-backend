using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bookavid_backend.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Writer { get; set; }

        public string Seller { get; set; }

        public Category Category { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Country Country { get; set; }

        [Required]
        public int CountryId { get; set; }

        public City City { get; set; }

        [Required]
        public int CityId { get; set; }

        public float Cost { get; set; }

        [Required]
        public Status Status { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public int View { get; set; }

        public string PhotoPath { get; set; }


    }
}
