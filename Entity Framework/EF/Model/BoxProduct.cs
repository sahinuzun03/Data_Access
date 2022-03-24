using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_RoniHoca_01102021.Model
{
    public class BoxProduct : Product
    {
        public int? UnıtsInBox { get; set; } //nullable integer anlamına gelir burası boş olarakta nesne oluşturulabilir.
    }
}
