﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(200)]
        public string? Title { get; set; }

        public string? Description { get; set; }
        public string? BookCode { get; set; }
        public string? Publisher { get; set; }
        public DateTime? PublishedYear { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Categories? Category { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Authors? Author { get; set; }

        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Avatar { get; set; } = "/images/books";
        public string? Pdf { get; set; } = "/pdf";
    }
}
