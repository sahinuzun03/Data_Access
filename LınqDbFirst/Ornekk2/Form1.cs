using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new NorthwindEntities();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //SELECT ProductID,ProductName,UnitPrice,UnitsInStock,CategoryName FROM Products INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID  WHERE UnitPrice > 20 AND UnitPrice< 50


            //dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice >= 20 && x.UnitPrice <= 50).OrderByDescending(x => x.UnitPrice).Select(x => new
            //{
            //    x.ProductID,
            //    x.ProductName,
            //    x.UnitPrice,
            //    x.UnitsInStock,
            //    x.Category.CategoryName
            //}).ToList();

            //LINQ TO SQL
            var resutl = from p in db.Products
                         where p.UnitPrice >= 20 && p.UnitPrice <= 50
                         orderby p.UnitPrice descending
                         select new
                         {
                             UrunID = p.ProductID,
                             UrunAdi = p.ProductName,
                             Fiyat = p.UnitPrice,
                             Stok = p.UnitsInStock,
                             KategoriAdi = p.Category.CategoryName
                         };
            dataGridView1.DataSource = resutl.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //SELECT Customers.CompanyName,Employees.FirstName + ' ' + Employees.LastName as CalisanAdSoyad,Orders.OrderID,Orders.OrderDate,Shippers.CompanyName FROM Orders INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID
            //dataGridView1.DataSource = db.Orders.Select(x => new
            //{
            //    ShipperCompanyName = x.Shipper.CompanyName,
            //    CustomerCompanyName = x.Customer.CompanyName,
            //    EmployeID = x.EmployeeID,
            //    EmployeeFirstName = x.Employee.FirstName,
            //    EmployeeLastName = x.Employee.LastName,
            //    OrderID = x.OrderID,
            //    OrderDate = x.OrderDate,
            //}).ToList();

            var result2 = from o in db.Orders
                          select new
                          {
                              ShipperName = o.Shipper.CompanyName,
                              CustomerName = o.Customer.CompanyName,
                              CalisanID = o.CustomerID,
                              CalisanAdSoyad = o.Employee.FirstName + " " + o.Employee.LastName,
                              SiparisID = o.OrderID,
                              SiparisTarihi = o.OrderDate,
                          };
            dataGridView1.DataSource = result2.ToList();

            //TODO : LINQ to SQL ' de yazılacak
        }




        private void button3_Click(object sender, EventArgs e)
        {
            //Şirket adında restaurant geçen müşterileri listeleyiniz..
            //SELECT * FROM Customers WHERE CompanyName LIKE '%restaurant%'

            //contains içerisinde //statswith -> başlayan //endwith -> biten
            dataGridView1.DataSource = db.Customers.Where(x => x.CompanyName.EndsWith("and")).Select(x => new
            {
                x.CompanyName
            }).ToList();
            //var result3 = from c in db.Customers
            //              where c.CompanyName.Contains("restaurant")
            //              select new
            //              {
            //                  c.CompanyName
            //              };
            //dataGridView1.DataSource = result3.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Beverages kategorisine sahip olan ve ürün adı Kola, fiyatı 5 , stok miktarı 500 olan bir ürün ekleyiniz
            //INSERT INTO Products (CategoryID,ProductName,UnitPrice,UnitsInStock) VALUES (1,'Kola',5,500)

            var id = (from c in db.Categories
                      where c.CategoryName == "Beverages"
                      select new { c.CategoryID }).FirstOrDefault();
            db.Products.Add(new Product() { ProductName = "süüüüttt", UnitPrice = 5, UnitsInStock = 500, CategoryID = Convert.ToInt32(id) });

            db.SaveChanges();
            dataGridView1.DataSource = db.Products.ToList();



            //    int categoryID = (int)((dataGridView1.Rows[0].Cells[0].Value));

            //    Product yeniUrun = new Product();
            //    yeniUrun.CategoryID = categoryID;
            //    yeniUrun.ProductName = "Kola";
            //    yeniUrun.UnitPrice = 5;
            //    yeniUrun.UnitsInStock = 500;
            //    db.Products.Add(yeniUrun);
            //    db.SaveChanges();
            //    dataGridView1.DataSource = db.Products.ToList();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //Select FirstName,LastName,Datediff(YEAR,BirthDate,GETDATE()) AS Yas FROM Employees

            DateTime today = DateTime.Today;
            //Çalışanların adını , soyadını , doğumtarhini ve yıl bazında yaşını listeleyiniz
            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                x.FirstName,
                x.LastName,
                Yas = today.Year - x.BirthDate.Value.Year,
            }).ToList();

            //var result4 = from z in db.Employees
            //              select new
            //              {
            //                  z.FirstName,
            //                  z.LastName,
            //                  Yas = today.Year - z.BirthDate.Value.Year,
            //              };
            //dataGridView1.DataSource = result4.ToList();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            //Her bir kategorinin stoktaki toplam ürün miktarını listeleyiniz.

            var result1 = (from p in db.Products
                           join c in db.Categories on p.CategoryID equals c.CategoryID
                           group new { c, p } by c.CategoryName into sonuc
                           select new
                           {
                               key = sonuc.Key,
                               value = sonuc.Sum(x => x.p.UnitsInStock)
                           }).ToDictionary(g => g.key, g => g.value);
            dataGridView1.DataSource = result1.ToList();

            dataGridView1.DataSource = db.Products.GroupBy(x => x.Category.CategoryName).Select(g => new
            {
                Kategori_Adi = g.Key,
                Toplam_Urun_Sayisi = g.Sum(p => p.UnitsInStock)
            }).ToList();
        }
    }
}

