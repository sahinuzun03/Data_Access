using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek3
{
    public partial class Form1 : Form
    {
        KisiRehberDBEntities db;
        public Form1()
        {
            InitializeComponent();
            
        }

        //Silme metodunu listviewüzerinde seçilen selectedıtem uzerinden gerçekleştireceğizz!!!Burayı düzenle
        private void Listele()
        {
            lstKisiListesi.Clear();
            lstKisiListesi.View = View.Details;
            lstKisiListesi.GridLines = true;
            lstKisiListesi.Columns.Add("ID", 100);
            lstKisiListesi.Columns.Add("FirstName", 160);
            lstKisiListesi.Columns.Add("Lastname", 160);
            lstKisiListesi.Columns.Add("PhoneNumber", 170);
            ListViewItem yeniItem;

            foreach (var item in db.Contacts.ToList())
            {
                yeniItem = new ListViewItem();
                yeniItem.Text = item.ID.ToString();
                yeniItem.SubItems.Add(item.FirstName.ToString());
                yeniItem.SubItems.Add(item.LastName.ToString());
                yeniItem.SubItems.Add(item.PhoneNumber.ToString());
                //yeniItem.Tag = item;
                lstKisiListesi.Items.Add(yeniItem);

                
            }
        } //Burası çalışıyor
        private void btnEkle_Click(object sender, EventArgs e) // Burasıda çalışıyor..
        {
            foreach (Control item in grpKisiEkle.Controls)
            {
                if(item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Boş bilgi geçilemez!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }      
                }      
            }
            db.Contacts.Add(new Contact() { FirstName = txtKisiAdi.Text, LastName = txtKisiSoyadi.Text, PhoneNumber = txtKisiTelefonu.Text });
            db.SaveChanges();
            Listele();
            Temizle();
        }

        private void btnKisiAra_Click(object sender, EventArgs e)//Burasıda çalışıyor.
        {
            var sonuc = db.Contacts.Where(x => x.FirstName.Contains(txtAranacak.Text) || x.LastName.Contains(txtAranacak.Text)).Select(x => new
            {
                x.FirstName,
                x.LastName,
                x.PhoneNumber
            }).ToList();
            foreach (var item in sonuc)
            {
                txtKisiAdi.Text = item.FirstName.ToString();
                txtKisiSoyadi.Text = item.LastName.ToString();
                txtKisiTelefonu.Text = item.PhoneNumber.ToString();
            }
            //Listele(db.Contacts.Where(x=> x.FirstName.ToLower().StartsWith(txtAranacak.Text.ToLower()) || x.LastName.ToLower().StartsWith(txtAranacak.Text.ToLower())).ToList();
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e) //Yapıyorum bu sporu buda çalışıyor
        {
            
            Contact contact = db.Contacts.Find(IDver());
            contact.FirstName = txtKisiAdi.Text;
            contact.LastName = txtKisiSoyadi.Text;
            contact.PhoneNumber = txtKisiTelefonu.Text;

            db.SaveChanges();
            Listele();
            Temizle();
 
        }
        private void tsmGuncelle_Click(object sender, EventArgs e)//tsm sağ tık güncelle basınca burası butonu devreye aldık neden böyle sağ tık olayı yaptık anlamadım..
        {
            btnKisiGuncelle.Enabled = true;
        }

        private void tsmSil_Click(object sender, EventArgs e)//Sağ tık seçili gelen ID ' yi siliyor koçum benim.
        {
            Contact contact = db.Contacts.Find(IDver());
            db.Contacts.Remove(contact);
            db.SaveChanges();
            Listele();
            Temizle();
           
        }
        private void Temizle() //Bunu daha öncede yazmıştık
        {
            foreach (Control item in this.Controls)
            {
                if(item == grpKisiAra)
                {
                    foreach (Control x in grpKisiAra.Controls)
                    {
                        if (x is TextBox)
                            x.Text = "";
                        if (x == btnKisiGuncelle)
                            x.Enabled = false;
                    }
                }
                if(item == grpKisiEkle)
                {
                    foreach (Control y in grpKisiEkle.Controls)
                    {
                        if (y is TextBox)
                            y.Text = "";
                    }
                }
            }
        }
        private int IDver() // Bu aslan parçası da 2 defa aynı kodu yazmışız Roni Hoca kızıyor diye yazdık koda.
        {
            var kisiID = 0;
            var sonuc = db.Contacts.Where(x => x.FirstName.Contains(txtAranacak.Text) || x.LastName.Contains(txtAranacak.Text)).Select(x => new
            {
                x.ID
            }).ToList();

            foreach (var item in sonuc)
            {
                kisiID = item.ID;
            }
            return kisiID;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new KisiRehberDBEntities();
            Listele();
            btnKisiGuncelle.Enabled = false;
        }
        //1.ADIM : SSMS'e giderek bir DB oluşturmalıyız.DB Adı : KisiRehberiDB
        //2.ADIM : Oluşturulan bu DB'de bir tane Contacts isimli tablo oluşturmalıyız.
        //2.1 ADIM : Contacts tablosunda yer alan kolonlar:
        //          -ID(int)
        //          -FirstName(string)--NVARCHAR(50)
        //          -LastName(string) --NVARCHAR(50)
        //          -PhoneNumber (string) --NVARCHAR(24)
        // 3.ADIM . Projeye Entity Framework eklemeliyiz :(NuGet'ten)
        // 4.ADIM db.First yaklaşımı ile oluşturulan db'nin bir modelini uygulamamıza eklemeliyiz.
        // 5.ADIM : Uygulamada , kişi ekleme , kişi arama , kişi listeleme , kişi güncelleme , kişi silme işlemleri için gerekli kodlamayı yapmalıyız. 
    }
}
