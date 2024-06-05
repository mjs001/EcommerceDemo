using ecommerceWithAngular.Services.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace ecommerceWithAngular.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        [Display(Name = "SubCategory Name")]
        public string SubCategoryName {  get; set; }
        public virtual Category Category { get; set; }
    }
}