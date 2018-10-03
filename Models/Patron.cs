using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BookManagement.Models {
    public class Patron {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

        [NotMapped]
        public bool IsActive { get; set; }
    }
}