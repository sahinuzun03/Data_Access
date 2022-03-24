using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartalHocaDBFirst30092021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db;//Northwind'in nesnesini ürettim.
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new NorthwindEntities();
            dgvMusteriListesi.DataSource = db.Customers.ToList();//SELECT * FROM Customer sorgusunun sonucunu getiriyor!!!
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //INSERT INTO Customer (CustomerID,CompanyName) VALUES ('UZNCO','UZN Holding')

            //Customer customer = new Customer();
            //customer.CustomerID = "UZNCO";
            //customer.CompanyName = "UZN Holding";
            //db.Customers.Add(customer);

            db.Customers.Add(new Customer() { CustomerID = "SSHCO", CompanyName = "SSH Holding" });

            db.SaveChanges();//Projede yapılan değişiklikleri DB'ye gönder ve işle

            dgvMusteriListesi.DataSource = db.Customers.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //UPDATE Customers SET ContactName = 'Şahin Uzun' WHERE CustomeID = 'UZNCO'

            Customer customer = db.Customers.Find();
            customer.ContactName = "Şahin Uzun";

            db.SaveChanges();
            dgvMusteriListesi.DataSource = db.Customers.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //DELETE FROM CUSTOMERS WHERE CUSTOMERID = 'SSHCO'
            Customer customer = db.Customers.Find("SSHCO");
            db.Customers.Remove(customer);

            db.SaveChanges();
            dgvMusteriListesi.DataSource = db.Customers.ToList();
        }
    }
}
