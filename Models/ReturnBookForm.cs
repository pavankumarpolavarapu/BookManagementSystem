using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BookManagement.Models {
    public class ReturnBookForm {
        public int ReservationId { get; set; }

        [Display (Name = "Actual Return Date")]
        [DataType (DataType.Date)]
        public DateTime? ActualReturnDate { get; set; }

    }
}