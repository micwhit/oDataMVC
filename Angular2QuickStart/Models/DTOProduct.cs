using System.ComponentModel.DataAnnotations;

namespace Angular2QuickStart.Models
{
    public class DTOProduct
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
    }
}