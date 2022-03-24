using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_RoniHoca_01102021.Model
{
    [Table("Ürün",Schema = "Grup")]
    public class Product
    {
        //ID yazan sütunları prımary key olarak görür.
        [Column("ÜrünID")]
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10,MinimumLength =6,ErrorMessage = "Kardeşim en az 6 en çok 10 satır girebilirsin!!!")]
        public string BarCode { get; set; }

        [Column(TypeName = "float")]
        public double Price { get; set; }

        [ForeignKey("Standart")]
        public int KategoriKodu { get; set; }


        [Required]
        public Category Category { get; set; }
    }
}
