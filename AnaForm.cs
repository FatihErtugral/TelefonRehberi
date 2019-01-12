using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

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
            this.StyleManager = metroStyleManager1;
            DataGridView_Guncelle();
            //dataGridView1.CellBeginEdit += new DataGridViewCellCancelEventHandler(DataGridView1_CellBeginEdit);
            //dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(DataGridView1_CellEndEdit);
        }
        #region Ayarlar
        private void Button1_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)cbmoBxRenk.SelectedIndex;
            dataGridView1.Style = Style;
            cbmoBxRenk.Style = Style;
            //metroTile1.Style = Style;
            pnlSlidAyarlar.BackColor = this.ForeColor;
        }
        #endregion

        #region Kişi Ekle
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

        #region DataGridEkleSilGüncelle
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

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    e.Cancel = true;
                }
                else
                    e.Cancel = true;

                }

            }
            else
                 e.Cancel = true;
        }
        #endregion

        private void DataGridView_Guncelle()
        {
            DataTable dtbl = new DataTable();
            dtbl = ToDataTable(db.Kisiler.ToList());
            dataGridView1.DataSource = dtbl;
        }



        #region MyRegion

        #endregion

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
        private void AllowNumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TxtBxTelNo_EnabledChanged(object sender, EventArgs e)
        {
            MessageBox.Show("asda");
        }

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

        private void TxtBxAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TxtBxAra_Click(this, new EventArgs());
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            btnSet.Enabled = btnSet.Enabled ? false : true;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            btnAdd1.Enabled = btnAdd1.Enabled ? false : true;
        }
    }

}