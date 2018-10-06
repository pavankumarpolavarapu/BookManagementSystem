using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BookManagement.Models {
    public class Book {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        [Required]
        public string Author { get; set; }
        public int Edition { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }

        [Display (Name = "Number of Pages")]
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        [Display (Name = "Published Date")]
        public DateTime PublishedDate { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}