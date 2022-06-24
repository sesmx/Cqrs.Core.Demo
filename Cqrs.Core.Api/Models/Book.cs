using System.ComponentModel.DataAnnotations;

namespace Cqrs.Core.Api.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
