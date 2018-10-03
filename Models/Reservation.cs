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
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }

        public int PatronId { get; set; }
        public Patron Patron { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        [NotMapped]
        public int? DelayDays { get; set; }
    }
}