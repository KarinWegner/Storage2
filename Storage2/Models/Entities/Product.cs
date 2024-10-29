using System.ComponentModel.DataAnnotations;

namespace Storage2.Models.Entities
{
    public class Product
    {
        public int Id {  get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        public Category Category { get; set; }
        [MaxLength(100000)]
        public int Count { get; set; }
        [StringLength(200)]
        public string? Description { get; set; }
    }
}
