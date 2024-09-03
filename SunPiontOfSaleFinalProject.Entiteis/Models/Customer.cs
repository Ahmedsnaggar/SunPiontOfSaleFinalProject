
using System.ComponentModel.DataAnnotations;

namespace SunPiontOfSaleFinalProject.Entiteis.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [MaxLength(70)]
        public string CustomerName { get; set; }
        public string? Address { get; set; }
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
        [MaxLength(70)]
        public string? WebSite { get; set; }
    }
}
