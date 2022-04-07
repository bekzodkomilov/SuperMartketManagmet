using System.ComponentModel.DataAnnotations;

namespace CaseBusiness
{
    public class Category
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Discription { get; set; }
    }
}