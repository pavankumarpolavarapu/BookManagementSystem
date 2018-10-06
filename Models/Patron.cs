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

        [Required]
        public string Name { get; set; }

        [Phone]
        [Display (Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [Display (Name = "Email Address")]
        public string EmailId { get; set; }

        [CustomValidation (typeof (Patron), "RegistrationValidation")]
        [Display (Name = "Registration Date")]
        public DateTime RegistrationDate { get; set; }

        [Display (Name = "Expiration Date")]
        public DateTime? ExpirationDate { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

        [NotMapped]
        public bool IsActive {
            get {
                if (ExpirationDate.HasValue) {
                    if (ExpirationDate < DateTime.Now) {
                        return false;
                    } else {
                        return true;
                    }
                } else {
                    return true;
                }
            }
        }

        [NotMapped]
        public int ExpirationDays {
            get {
                if( ExpirationDate.HasValue ){
                return (int)((DateTime) DateTime.Now - (DateTime) ExpirationDate).TotalDays;
                }
                else{
                    return 0;
                }
            }
        }

        public static ValidationResult RegistrationValidation (DateTime? rDate, ValidationContext context) {
            if (rDate == null) {
                return ValidationResult.Success;
            }
            if (rDate <= DateTime.Today) {
                return ValidationResult.Success;
            }
            return new ValidationResult ("Registration Date cannot be in future");
        }
    }

}