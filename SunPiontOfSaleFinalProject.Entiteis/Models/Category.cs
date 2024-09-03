using System.ComponentModel.DataAnnotations;

namespace SunPiontOfSaleFinalProject.Entiteis.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [MaxLength(150)]
        public string? CategoryDescription { get; set; }
    }
}
