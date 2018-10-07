using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BookManagement.Models {
    public class BorrowBookForm {
        public int ReservationId { get; set; }

        [CustomValidation (typeof (BorrowBookForm), "ValidateBook")]
        [Display (Name = "Book")]
        [Required (ErrorMessage = "Please select Book")]
        public int BookId { get; set; }

        [CustomValidation (typeof (BorrowBookForm), "ValidatePatron")]
        [Display (Name = "Patron")]
        [Required (ErrorMessage = "Please select Patron")]
        public int PatronId { get; set; }
        public static ValidationResult ValidateBook (int? bookId, ValidationContext context) {
            if (bookId == null) {
                return ValidationResult.Success;
            }
            var dbContext = context.GetService (typeof (AppDbContext)) as AppDbContext;

            ICollection<Reservation> reservations = dbContext.Reservation
                .Where (x => x.BookId == bookId.Value)
                .ToList ();
            foreach (var r in reservations) {
                if (r.ActualReturnDate == null) {
                    return new ValidationResult ("Book Reserved by Another Person as of date");
                }
            }
            return ValidationResult.Success;
        }

        public static ValidationResult ValidatePatron (int? PatronId, ValidationContext context) {
            if (PatronId == null) {
                return ValidationResult.Success;
            }
            var dbContext = context.GetService (typeof (AppDbContext)) as AppDbContext;
            var PatronExist = dbContext.Patron
                .Where (x => x.ExpirationDate == DateTime.MinValue)
                .FirstOrDefault (x => x.Id == PatronId.Value);
            if (PatronExist == null) {
                var PatronExpired = dbContext.Patron
                    .Where (x => x.ExpirationDate <= DateTime.Today)
                    .FirstOrDefault (x => x.Id == PatronId.Value);
                if (PatronExpired != null) {
                    return new ValidationResult ("Patron not Found");
                } else {
                    return ValidationResult.Success;
                }
            } else {
                return ValidationResult.Success;
            }

        }
    }
}