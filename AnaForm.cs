using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TelefonRehberi.Properties;

//  metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string="data source=KOD;initial catalog=TelefonRehberi;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"

namespace TelefonRehberi
{
    public partial class AnaForm : MetroFramework.Forms.MetroForm
    {
        TelefonRehberiEntities db = new TelefonRehberiEntities();
        private SlidingPanel SlidingPanel;
        public AnaForm()
        {
            InitializeComponent();
            SlidingPanel = new SlidingPanel(ref pnlSlidAyarlar, ref btnSet, 240);
            SlidingPanel = new SlidingPanel(ref pnlSlidKisiEkle, ref btnAdd1, 240);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetupSettings();
            DataGridView_Guncelle();
        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
        

        #region Kişi Ekle

        //
        //  Ad, Soyad ve Telefon numarası girilmeden ekleme butonu aktif edilmiyor.
        //
        private void Txt_KisiEkle_TabStopChanged(object sender, EventArgs e)
        {
            KisiEkleKontrol();
            if (LblAdKntrl.Text == "" && LblSoyadKntrl.Text == "" && LblTelKntrl.Text == "")
            {
                btnSaveKisiEkle.BackColor = Color.PaleVioletRed;
                btnSaveKisiEkle.Enabled = true;
            }
            else
            {
                btnSaveKisiEkle.Enabled = false;
                btnSaveKisiEkle.BackColor = Color.DarkGray;
            }
        }
        private void KisiEkleKontrol()
        {
            if (TxtBxAd.Text != "") LblAdKntrl.Text = "";
            else LblAdKntrl.Text = "*";

            if (TxtBxSoyad.Text != "") LblSoyadKntrl.Text = "";
            else LblSoyadKntrl.Text = "*";

            if (TxtBxTelNo.Text != "") LblTelKntrl.Text = "";
            else LblTelKntrl.Text = "*";
        }
        //
        //   Buton aktif olduktan sonra "Kişi Ekle" menusunden kayıtlar SQL server'a işleniyor.
        //
        private void BtnSaveKisiEkle_Click(object sender, EventArgs e)
        {
            Kisiler kisiler = new Kisiler
            {
                KisiAdi = TxtBxAd.Text,
                Email   = TxtBxEmail.Text,
                Sirket  = TxtBxSirket.Text,
                TelNo   = TxtBxTelNo.Text,
                KisiSoyadi = TxtBxSoyad.Text
            };

            db.Kisiler.Add(kisiler);
            db.SaveChanges();
            DataGridView_Guncelle();
        }
        #endregion

        #region DATAGRID VERİ SİLME EKLEME GÜNCELLEME
        
        ////////////////////////////////////////////////////////////////////////
        // list türünden datatable türüne dönüşüm
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

       
        ////////////////////////////////////////////////////////////////////////
        private Kisiler kisi;

        // datagridview1 üzerinde değişimleri algılayıp update insert işlemlerini gerçekleştiriyor
        private void GrdDataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                
                DataGridViewRow dvgRow  = dataGridView1.CurrentRow;
                if (dvgRow.Cells["KisilerID"].Value == DBNull.Value) kisi = new Kisiler(); // Insert

                else kisi = db.Kisiler.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["KisilerID"].Value)); // Update

                kisi.KisiAdi    = dvgRow.Cells["KisiAdi"].Value.ToString();
                kisi.KisiSoyadi = dvgRow.Cells["KisiSoyadi"].Value.ToString();
                kisi.Email      = dvgRow.Cells["Email"].Value.ToString();
                kisi.TelNo      = dvgRow.Cells["TelNo"].Value.ToString();
                kisi.Sirket     = dvgRow.Cells["Sirket"].Value.ToString();
                
                if(dvgRow.Cells["KisiAdi"].Value != DBNull.Value &&
                   dvgRow.Cells["KisiSoyadi"].Value != DBNull.Value &&
                   dvgRow.Cells["TelNo"].Value != DBNull.Value )
                {
                    if (dvgRow.Cells["KisilerID"].Value == DBNull.Value)
                        db.Kisiler.Add(kisi);

                    db.SaveChanges();
                    DataGridView_Guncelle();
                    kisi = null;
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if(dataGridView1.CurrentRow.Cells["KisilerID"].Value != DBNull.Value && dataGridView1.CurrentRow.Index != -1)
            {
                int temp = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KisilerID"].Value);
                if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Kisiler kisilerx = db.Kisiler.Find(temp);
                    db.Kisiler.Remove(kisilerx);
                    db.SaveChanges();
                    DataGridView_Guncelle();
                    e.Cancel = true;
                }
                else
                    e.Cancel = true;
            }
            else
                 e.Cancel = true;
        }
        ////////////////////////////////////////////////////////////////////////
        
        // Telefon Numarası hücresine karakter girişini engelliyor
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            if(dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["TelNo"].Index)
            {
                e.Control.KeyPress -= AllowNumbersOnly;
                e.Control.KeyPress += AllowNumbersOnly;
            }
            else
             e.Control.KeyPress -= AllowNumbersOnly;
        }
        ////////////////////////////////////////////////////////////////////////
        ///
        #endregion

        private void DataGridView_Guncelle()
        {
            DataTable dtbl = new DataTable();
            dtbl = ToDataTable(db.Kisiler.ToList());
            dataGridView1.DataSource = dtbl;
        }

        
        private void AllowNumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        //Tabloda seçili satırı tespit edip siliyor
        private void btnDel1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Cells["KisilerID"].Value != DBNull.Value && dataGridView1.CurrentRow.Index != -1)
            {
                int temp = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KisilerID"].Value);
                if(temp > 0)
                {

                    if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                   
                        Kisiler kisilerx = db.Kisiler.Find(temp);
                        db.Kisiler.Remove(kisilerx);
                        db.SaveChanges();
                        DataGridView_Guncelle();
                    }

                }

            }
        }
        // Tablodan seçime göre silme butonu aktif - pasif
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {

                if (dataGridView1.CurrentRow.Cells["KisilerID"].Value == DBNull.Value)
                {
                    btnDel1.Enabled = false;
                    btnDel1.BackColor = Color.FromKnownColor(KnownColor.ButtonShadow);
                }
                else
                {
                    btnDel1.Enabled = true;
                    btnDel1.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                }
            }
        }

        // Ad, Soyad ve Numaradan işlemi arama yapılıyor
        private void TxtBxAra_Click(object sender, EventArgs e)
        {
                var sorgu = (from ks in db.Kisiler
                             where 
                                ks.KisiAdi.Contains(TxtBxAra.Text)    ||
                                ks.KisiSoyadi.Contains(TxtBxAra.Text) ||
                                ks.TelNo.Contains(TxtBxAra.Text)
                             select new
                             {
                                 ks.KisilerID,
                                 ks.KisiAdi,
                                 ks.KisiSoyadi,
                                 ks.Sirket,
                                 ks.TelNo,
                                 ks.Email
                             }
                          ).ToList();

            DataTable dtbl = new DataTable();
            dtbl = ToDataTable(sorgu.ToList());
            dataGridView1.DataSource = dtbl;
        }
        // Arama TextBox'ında entera basılınca direk arasın
        private void TxtBxAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TxtBxAra_Click(this, new EventArgs());
        }



        //  Ayar Menusu açıkken ekleme menüsü açılmasın.
        //  Ekleme Menusu açıkken ayar menüsü açılmasın.
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            btnSet.Enabled = btnSet.Enabled ? false : true;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            btnAdd1.Enabled = btnAdd1.Enabled ? false : true;
        }


        #region AYARLAR

        // Kayıtlı ayarlar program ilk çalıştığında yükleniyor
        private void SetupSettings()
        {
            this.metroStyleManager1.Theme = Settings.Default.CmbBoxTema;
            this.metroStyleManager1.Style = Settings.Default.StyleManegerSet;
            this.StyleManager           = metroStyleManager1;
            this.dataGridView1.Style    = Style;
            this.cmbBoxRenk.Style       = Style;

            this.cmbBoxTema.SelectedIndex       = (int)Settings.Default.CmbBoxTema;
            this.cmbBoxRenk.SelectedIndex       = Settings.Default.CmbBoxRenk;
            this.chckBxTabloDuzenleme.Checked   = Settings.Default.T_DuzenEtkinlestir;
            this.chckBxTabloEkleme.Checked      = Settings.Default.T_EkleEtkinlestir;
            this.chckBxTabloSilme.Checked       = Settings.Default.T_SilEtkinlestir;
            this.chckBxTabloSiralama.Checked    = Settings.Default.T_SiralamaEtkinlestir;
        }

        // Gerçek zamanlı ayarlar kayıt altına alınıyor program kapanıp açıldığında aynı (tema-renk-vs) ayarlardan başlaması sağlanıyor.
        private void SaveSettings()
        {
            Settings.Default.CmbBoxTema         = (MetroFramework.MetroThemeStyle)cmbBoxTema.SelectedIndex;
            Settings.Default.StyleManegerSet    = (MetroFramework.MetroColorStyle)cmbBoxRenk.SelectedIndex;

            Settings.Default.CmbBoxRenk             = this.cmbBoxRenk.SelectedIndex;
            Settings.Default.T_DuzenEtkinlestir     = this.chckBxTabloDuzenleme.Checked;
            Settings.Default.T_EkleEtkinlestir      = this.chckBxTabloEkleme.Checked;
            Settings.Default.T_SilEtkinlestir       = this.chckBxTabloSilme.Checked;
            Settings.Default.T_SiralamaEtkinlestir  = this.chckBxTabloSiralama.Checked;

            Settings.Default.Save();
        }

        //
        // Ayarlar menusundeki butonların seçilip onaylanmasıyla ilgili metotlar
        //

        private void chckBxTabloDuzenleme_CheckedChanged(object sender, EventArgs e)
        {
            if(!chckBxTabloDuzenleme.Checked)
            {
                this.dataGridView1.ReadOnly = true;
                this.KisilerID.ReadOnly     = true;
                this.KisiAdi.ReadOnly       = true;
                this.KisiSoyadi.ReadOnly    = true;
                this.TelNo.ReadOnly         = true;
                this.Email.ReadOnly         = true;
                this.Sirket.ReadOnly        = true;
            }
            else
            {
                this.dataGridView1.ReadOnly = false;
                this.KisilerID.ReadOnly     = false;
                this.KisiAdi.ReadOnly       = false;
                this.KisiSoyadi.ReadOnly    = false;
                this.TelNo.ReadOnly         = false;
                this.Email.ReadOnly         = false;
                this.Sirket.ReadOnly        = false;
            }
        }

        private void chckBxTabloEkleme_CheckedChanged(object sender, EventArgs e)
        {
            if(chckBxTabloEkleme.Checked)
                this.dataGridView1.AllowUserToAddRows = true;
            else
                this.dataGridView1.AllowUserToAddRows = false;
        }

        private void chckBxTabloSilme_CheckedChanged(object sender, EventArgs e)
        {
            if(chckBxTabloSilme.Checked)
                this.dataGridView1.AllowUserToDeleteRows = true;
            else
                this.dataGridView1.AllowUserToDeleteRows = false;
        }

        private void chckBxTabloSiralama_CheckedChanged(object sender, EventArgs e)
        {
            if(chckBxTabloSiralama.Checked)
                this.dataGridView1.AllowUserToOrderColumns = false;
            else
                this.dataGridView1.AllowUserToOrderColumns = false;
        }

        private void cmbBoxRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = dataGridView1.Style =(MetroFramework.MetroColorStyle)cmbBoxRenk.SelectedIndex;
        }

        private void cmbBoxTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = (MetroFramework.MetroThemeStyle)cmbBoxTema.SelectedIndex;
        }

        #endregion
        
    }

}