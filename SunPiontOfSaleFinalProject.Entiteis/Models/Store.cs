using System.ComponentModel.DataAnnotations;

namespace SunPiontOfSaleFinalProject.Entiteis.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string StoreName { get; set; }
        public string? Address { get; set; }
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }
    }
}
