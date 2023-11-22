using System.ComponentModel.DataAnnotations;

namespace ProniaAB104.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad mutleq daxil edilmeldir")]
        [MaxLength(25,ErrorMessage ="Uznlugu 25 xarakterden cox olmamalidir")]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
