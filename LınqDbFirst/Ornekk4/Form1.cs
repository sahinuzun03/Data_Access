using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekk4
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
            ///1 Ocak 1998 tarihinden sonra sipariş veren müşterilerimin isimlerini sıralayınız
            //CompanyName,OrderID,OrderDate
            DateTime dateTime = new DateTime(1998, 1, 1);
            dataGridView1.DataSource = db.Orders.Where(x => x.OrderDate > dateTime).OrderByDescending(x => x.Customer.CompanyName).Select(x => new
            {
                x.Customer.CompanyName,
                x.OrderID,
                x.OrderDate,
            }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Şişede satılan üünlerimi sipariş ile gönderdiğim ülkeler hangileridir ?
            //(Product name ,ShipCountry) , QuantityPerUnit alanında şişe geçen

            dataGridView1.DataSource = db.Order_Details.Where(x => x.Product.QuantityPerUnit.Contains("bottles")).Select(x => new
            {
                x.Product.ProductName,
                x.Order.ShipCountry,
            }
            ).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Kadın çalışanlarımın ilgilendiği siparişlerin , gönderilidği müşterilerimden iletişime geçtiğim kişilerin isimleri ve şehirleri nelerdir ?
            //(Employee (FirstName + LastName)) , CompanyName , Contact Name , City)
            dataGridView1.DataSource = db.Orders.Where(x => x.Employee.TitleOfCourtesy.Contains("Ms.") || x.Employee.TitleOfCourtesy.Contains("Mrs.")).Select(x => new
            {
                CalisanBilgileri = x.Employee.FirstName + " " + x.Employee.LastName,
                x.Customer.CompanyName,
                x.Customer.ContactName,
                x.Customer.City,
            }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Federal Shipping ile taşınmış ve Nancy'nin almış olduğu siparişleri listeleyiniz.(Order ID , Employee(FirstName + LastName)) , Shipper(CompanyName) kolonları
            dataGridView1.DataSource = db.Orders.Where(x => x.Employee.FirstName.Contains("Nancy")).Select(x => new
            {
                x.OrderID,
                CalisanBilgileri = x.Employee.FirstName + " " + x.Employee.LastName,
                x.Shipper.CompanyName,
            }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Stoğu 20 den fazla olan siparişlerimin hangi kargo şirketleriyle teslim edildiğini listeleyiniz 
            //Shipper Company Name , OrderID , UnıtInStock kolonları
            dataGridView1.DataSource = db.Order_Details.Where(x => x.Product.UnitsInStock > 20).Select(x => new
            {
                x.Order.Shipper.CompanyName,
                x.OrderID,
                x.Product.UnitsInStock,
            }
            ).ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //250 ' den fazla sipariş taşımış olan kargo firmalarını listeleyiniz (Shipper(CompanyName) , Shipper(Phone),Sipariş sayısı
            dataGridView1.DataSource = db.Orders.GroupBy(x => new { x.Shipper.CompanyName, x.Shipper.Phone }).Select(x => new
            {
                FirmaAdi = x.Key.CompanyName,
                FirmaTelefon = x.Key.Phone,
                ToplamSiparis = x.Count()
            }).Where(x => x.ToplamSiparis > 250).ToList();
        }
    }
}
