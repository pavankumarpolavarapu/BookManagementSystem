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
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}