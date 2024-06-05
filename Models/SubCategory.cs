namespace ecommerceWithAngular.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string SubCategory {  get; set; }
        public virtual Category Category { get; set; }
    }
}