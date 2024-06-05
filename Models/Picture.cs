using System.ComponentModel.DataAnnotations;

namespace ecommerceWithAngular.Models
{
    public class Picture
    {
        public int Id { get; set; }
        [StringLength(100)]
        public int ProductId { get; set; }
        public string PictureFileName { get; set; }
        public Product Product { get; set; }
        //public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}