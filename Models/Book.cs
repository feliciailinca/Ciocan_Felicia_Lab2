using Ciocan_Felicia_Lab2.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Ciocan_Felicia_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Completarea câmpului Titlu este obligatorie")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Titlul trebuie să aibă între 3 și 150 de caractere")]
        [Display(Name = "Book Title")] 
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } 

        public int? AuthorsID { get; set; }
        public Authors? Authors { get; set; }
        public Borrowing? Borrowing { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }

    }
}

