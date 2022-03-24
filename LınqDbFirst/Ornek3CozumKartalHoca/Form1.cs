using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek3CozumKartalHoca
{
    public partial class Form1 : Form
    {
        KisiRehberDBEntities1 db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new KisiRehberDBEntities1();
            KisileriDoldur(db.Contacts.ToList());
        }
        private void KisileriDoldur(List<Contact> liste)
        {
            lstKisiListesi.Items.Clear();
            foreach (Contact item in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.FirstName);
                lvi.SubItems.Add(item.LastName);
                lvi.SubItems.Add(item.PhoneNumber);

                lvi.Tag = item;
                lstKisiListesi.Items.Add(lvi);
            }

        }
    }
}
