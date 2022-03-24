
namespace Ornek3CozumKartalHoca
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tsmSil = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtKisiTelefonu = new System.Windows.Forms.TextBox();
            this.txtKisiSoyadi = new System.Windows.Forms.TextBox();
            this.txtKisiAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpKisiListesi = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKisiGuncelle = new System.Windows.Forms.Button();
            this.btnKisiAra = new System.Windows.Forms.Button();
            this.grpKisiEkle = new System.Windows.Forms.GroupBox();
            this.txtAranacak = new System.Windows.Forms.TextBox();
            this.grpKisiAra = new System.Windows.Forms.GroupBox();
            this.lstKisiListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.grpKisiListesi.SuspendLayout();
            this.grpKisiEkle.SuspendLayout();
            this.grpKisiAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmSil
            // 
            this.tsmSil.Name = "tsmSil";
            this.tsmSil.Size = new System.Drawing.Size(148, 24);
            this.tsmSil.Text = "SİL";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGuncelle,
            this.tsmSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 52);
            // 
            // tsmGuncelle
            // 
            this.tsmGuncelle.Name = "tsmGuncelle";
            this.tsmGuncelle.Size = new System.Drawing.Size(148, 24);
            this.tsmGuncelle.Text = "GUNCELLE";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 209);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(280, 41);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "REHBERE EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // txtKisiTelefonu
            // 
            this.txtKisiTelefonu.Location = new System.Drawing.Point(111, 123);
            this.txtKisiTelefonu.Name = "txtKisiTelefonu";
            this.txtKisiTelefonu.Size = new System.Drawing.Size(175, 22);
            this.txtKisiTelefonu.TabIndex = 5;
            // 
            // txtKisiSoyadi
            // 
            this.txtKisiSoyadi.Location = new System.Drawing.Point(111, 81);
            this.txtKisiSoyadi.Name = "txtKisiSoyadi";
            this.txtKisiSoyadi.Size = new System.Drawing.Size(175, 22);
            this.txtKisiSoyadi.TabIndex = 4;
            // 
            // txtKisiAdi
            // 
            this.txtKisiAdi.Location = new System.Drawing.Point(111, 39);
            this.txtKisiAdi.Name = "txtKisiAdi";
            this.txtKisiAdi.Size = new System.Drawing.Size(175, 22);
            this.txtKisiAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı :";
            // 
            // grpKisiListesi
            // 
            this.grpKisiListesi.Controls.Add(this.lstKisiListesi);
            this.grpKisiListesi.Location = new System.Drawing.Point(15, 274);
            this.grpKisiListesi.Name = "grpKisiListesi";
            this.grpKisiListesi.Size = new System.Drawing.Size(592, 296);
            this.grpKisiListesi.TabIndex = 5;
            this.grpKisiListesi.TabStop = false;
            this.grpKisiListesi.Text = "Rehber";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aranacak Ad Veya Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.Location = new System.Drawing.Point(18, 191);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(247, 47);
            this.btnKisiGuncelle.TabIndex = 8;
            this.btnKisiGuncelle.Text = "GÜNCELLEME YAP";
            this.btnKisiGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKisiAra
            // 
            this.btnKisiAra.Location = new System.Drawing.Point(18, 130);
            this.btnKisiAra.Name = "btnKisiAra";
            this.btnKisiAra.Size = new System.Drawing.Size(247, 47);
            this.btnKisiAra.TabIndex = 7;
            this.btnKisiAra.Text = "KİŞİ ARA";
            this.btnKisiAra.UseVisualStyleBackColor = true;
            // 
            // grpKisiEkle
            // 
            this.grpKisiEkle.Controls.Add(this.btnEkle);
            this.grpKisiEkle.Controls.Add(this.txtKisiTelefonu);
            this.grpKisiEkle.Controls.Add(this.txtKisiSoyadi);
            this.grpKisiEkle.Controls.Add(this.txtKisiAdi);
            this.grpKisiEkle.Controls.Add(this.label3);
            this.grpKisiEkle.Controls.Add(this.label2);
            this.grpKisiEkle.Controls.Add(this.label1);
            this.grpKisiEkle.Location = new System.Drawing.Point(15, 12);
            this.grpKisiEkle.Name = "grpKisiEkle";
            this.grpKisiEkle.Size = new System.Drawing.Size(292, 256);
            this.grpKisiEkle.TabIndex = 3;
            this.grpKisiEkle.TabStop = false;
            this.grpKisiEkle.Text = "Kişi Ekleme Paneli";
            // 
            // txtAranacak
            // 
            this.txtAranacak.Location = new System.Drawing.Point(9, 70);
            this.txtAranacak.Name = "txtAranacak";
            this.txtAranacak.Size = new System.Drawing.Size(277, 22);
            this.txtAranacak.TabIndex = 5;
            // 
            // grpKisiAra
            // 
            this.grpKisiAra.Controls.Add(this.btnKisiGuncelle);
            this.grpKisiAra.Controls.Add(this.btnKisiAra);
            this.grpKisiAra.Controls.Add(this.txtAranacak);
            this.grpKisiAra.Controls.Add(this.label4);
            this.grpKisiAra.Location = new System.Drawing.Point(313, 12);
            this.grpKisiAra.Name = "grpKisiAra";
            this.grpKisiAra.Size = new System.Drawing.Size(294, 256);
            this.grpKisiAra.TabIndex = 4;
            this.grpKisiAra.TabStop = false;
            this.grpKisiAra.Text = "Kişi Arama";
            // 
            // lstKisiListesi
            // 
            this.lstKisiListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstKisiListesi.GridLines = true;
            this.lstKisiListesi.HideSelection = false;
            this.lstKisiListesi.Location = new System.Drawing.Point(6, 21);
            this.lstKisiListesi.Name = "lstKisiListesi";
            this.lstKisiListesi.Size = new System.Drawing.Size(578, 269);
            this.lstKisiListesi.TabIndex = 0;
            this.lstKisiListesi.UseCompatibleStateImageBehavior = false;
            this.lstKisiListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AD";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 171;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon Numarası ";
            this.columnHeader4.Width = 135;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 589);
            this.Controls.Add(this.grpKisiListesi);
            this.Controls.Add(this.grpKisiEkle);
            this.Controls.Add(this.grpKisiAra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpKisiListesi.ResumeLayout(false);
            this.grpKisiEkle.ResumeLayout(false);
            this.grpKisiEkle.PerformLayout();
            this.grpKisiAra.ResumeLayout(false);
            this.grpKisiAra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmSil;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtKisiTelefonu;
        private System.Windows.Forms.TextBox txtKisiSoyadi;
        private System.Windows.Forms.TextBox txtKisiAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpKisiListesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKisiGuncelle;
        private System.Windows.Forms.Button btnKisiAra;
        private System.Windows.Forms.GroupBox grpKisiEkle;
        private System.Windows.Forms.TextBox txtAranacak;
        private System.Windows.Forms.GroupBox grpKisiAra;
        private System.Windows.Forms.ListView lstKisiListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

