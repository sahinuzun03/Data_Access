using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EF_RoniHoca_01102021.Model;

namespace EF_RoniHoca_01102021.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public enum VeriTabaniYaratmaModelleri { VeriTabaniYokIseYarat,ModelDegisirIseYarat,HerZamanYeniVeriTabaniYarat}
        public ApplicationDbContext(VeriTabaniYaratmaModelleri VeriTabaniModeli) : base("name=EF_RoniHoca_01102021.Properties.Settings.DataBaseConnectionString")
        {
            switch (VeriTabaniModeli)
            {
                case VeriTabaniYaratmaModelleri.VeriTabaniYokIseYarat:
                    Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>()); //Veritabanı yok ise yarat
                    break;
                case VeriTabaniYaratmaModelleri.ModelDegisirIseYarat:
                    Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
                    break;
                case VeriTabaniYaratmaModelleri.HerZamanYeniVeriTabaniYarat:
                    Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseAlways<ApplicationDbContext>());
                    break;
                default:
                    break;
            }
            

        }
        public DbSet<EF_RoniHoca_01102021.Model.Category> Categories { get; set; }
        public DbSet<EF_RoniHoca_01102021.Model.Product> Products { get; set; }

        public DbSet<EF_RoniHoca_01102021.Model.BoxProduct> BoxProducts { get; set; }
    }
}
 