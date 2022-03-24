using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_RoniHoca_01102021.Data;
using EF_RoniHoca_01102021.Model;
using System.Data.Entity;


namespace EF_RoniHoca_01102021
{
    class Program
    {
        static void Main(string[] args)
        {
            //dbContext select update insert işlemlerini bizim için yapan sınıf
            using (ApplicationDbContext app = new ApplicationDbContext(ApplicationDbContext.VeriTabaniYaratmaModelleri.ModelDegisirIseYarat))
            {
                Category Kirtasiye = new Category()
                { CategoryCode = 1, Name = "Kırtasiye" };
                Category Tuafiye = new Category()
                { CategoryCode = 2, Name = "Tuafiye" };
                Product Defter = new Product();
                Defter.ProductID = 1;
                Defter.Name = "Defter";
                Defter.Category = Kirtasiye;
                Defter.Price = 12.20;

                BoxProduct KalemKutusu = new BoxProduct();
                KalemKutusu.Name = "Kalem";
                KalemKutusu.Category = Kirtasiye;
                KalemKutusu.Price = 25;
                KalemKutusu.UnıtsInBox = 12;

                app.Categories.Add(Kirtasiye);
                app.Categories.Add(Tuafiye);
                app.Products.Add(Defter);
                app.BoxProducts.Add(KalemKutusu);
                app.SaveChanges();


            }
        }
    }
}
