using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BookManagement.Models {
    public class Reservation {
        [Key]
        public int Id { get; set; }

        [DataType (DataType.Date)]
        [Display (Name = "Borrow Date")]
        public DateTime BorrowDate { get; set; }

        [DataType (DataType.Date)]
        [Display (Name = "Return Date")]
        public DateTime ReturnDate { get; set; }

        [DataType (DataType.Date)]
        [Display (Name = "Actual Return Date")]
        public DateTime? ActualReturnDate { get; set; }

        [Required]
        [Display (Name = "Patron ID")]
        public int PatronId { get; set; }
        public Patron Patron { get; set; }

        [Required]
        [Display (Name = "Book ID")]
        public int BookId { get; set; }

        public Book Book { get; set; }

        [NotMapped]
        public int? DelayDays {
            get {
                if (ActualReturnDate.HasValue) {
                    if (((DateTime) ActualReturnDate - (DateTime) ReturnDate).TotalDays > 0) {
                        return (int) ((DateTime) ActualReturnDate - (DateTime) ReturnDate).TotalDays;
                    } else {
                        return 0;
                    }
                } else if (ReturnDate < DateTime.Now) {
                    return (int) (DateTime.Now - ReturnDate).TotalDays;
                } else {
                    return 0;
                }

            }
        }
    }
}