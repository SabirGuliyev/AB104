using System.ComponentModel.DataAnnotations;

namespace ProniaAB104.Areas.ProniaAdmin.ViewModels
{
    public class CreateProductVM
    {

       
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string Description { get; set; }

        public string SKU { get; set; }
        [Required]
        public int? CategoryId { get; set; }

        public List<int> TagIds { get; set; }


    }
}
