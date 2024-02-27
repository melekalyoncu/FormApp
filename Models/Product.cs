using System.ComponentModel.DataAnnotations;

namespace FormApp.Models
{
    
    public class Product
    {
        [Display(Name="Urun Id")]
       
        public int ProductId { get; set; }

         [Required]
         [StringLength(100)]
        [Display(Name="Urun Ad")]

        public string Name { get; set; } = null!;

        [Required]
        [Range(0,100000)]
        [Display(Name="Fiyat")]

        
        public decimal Price { get; set; }
        [Display(Name="Resim")]

        public String Image { get; set; } = string.Empty;


        public bool IsActive { get; set; }

        [Required]
        public int? CategoryId { get; set; }

    }
}