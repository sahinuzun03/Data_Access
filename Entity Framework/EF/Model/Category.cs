using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_RoniHoca_01102021.Model
{
    [Table("Kategori",Schema ="Grup")]//Grup.Kategori diye bir tablo oluştur dedik.
    public class Category
    {
        [Key] //categoryCode'u primary key olduğunu söyledik
        [Column("KategoriID")]
        public int CategoryCode { get; set; }
        [Column("Kategori Adı",TypeName = "varchar")]
        [Index(IsClustered = false,IsUnique = true)] // sıralı olması kapalı ve tek olma özelliği açık
        [Required] //Name sütununun boş geçilemez girilmek kesinlikle zorunludur.
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
