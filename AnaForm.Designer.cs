namespace TelefonRehberi
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.TxtBxAra = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSliding = new System.Windows.Forms.Button();
            this.btnDel1 = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.pnlSlidAyarlar = new System.Windows.Forms.Panel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSliderTitle = new System.Windows.Forms.Panel();
            this.lblAyarlar = new System.Windows.Forms.Label();
            this.pnlSlidKisiEkle = new System.Windows.Forms.Panel();
            this.LblTelKntrl = new System.Windows.Forms.Label();
            this.LblSoyadKntrl = new System.Windows.Forms.Label();
            this.LblAdKntrl = new System.Windows.Forms.Label();
            this.btnSaveKisiEkle = new System.Windows.Forms.Button();
            this.TxtBxTelNo = new MetroFramework.Controls.MetroTextBox();
            this.TxtBxSirket = new MetroFramework.Controls.MetroTextBox();
            this.TxtBxEmail = new MetroFramework.Controls.MetroTextBox();
            this.TxtBxSoyad = new MetroFramework.Controls.MetroTextBox();
            this.TxtBxAd = new MetroFramework.Controls.MetroTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblEkleTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.KisilerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KisiAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KisiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sirket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlSlidAyarlar.SuspendLayout();
            this.pnlSliderTitle.SuspendLayout();
            this.pnlSlidKisiEkle.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
            // 
            // TxtBxAra
            // 
            this.TxtBxAra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            // 
            // 
            // 
            this.TxtBxAra.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TxtBxAra.CustomButton.Image = global::TelefonRehberi.Properties.Resources.icons8_search_208;
            this.TxtBxAra.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.TxtBxAra.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBxAra.CustomButton.Name = "";
            this.TxtBxAra.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtBxAra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxAra.CustomButton.TabIndex = 1;
            this.TxtBxAra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxAra.CustomButton.UseSelectable = true;
            this.TxtBxAra.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBxAra.Lines = new string[0];
            this.TxtBxAra.Location = new System.Drawing.Point(176, 3);
            this.TxtBxAra.MaxLength = 140;
            this.TxtBxAra.Name = "TxtBxAra";
            this.TxtBxAra.PasswordChar = '\0';
            this.TxtBxAra.PromptText = "Ara..";
            this.TxtBxAra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxAra.SelectedText = "";
            this.TxtBxAra.SelectionLength = 0;
            this.TxtBxAra.SelectionStart = 0;
            this.TxtBxAra.ShortcutsEnabled = true;
            this.TxtBxAra.ShowButton = true;
            this.TxtBxAra.ShowClearButton = true;
            this.TxtBxAra.Size = new System.Drawing.Size(233, 30);
            this.TxtBxAra.Style = MetroFramework.MetroColorStyle.Silver;
            this.TxtBxAra.TabIndex = 5;
            this.TxtBxAra.UseSelectable = true;
            this.TxtBxAra.WaterMark = "Ara..";
            this.TxtBxAra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxAra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBxAra.Click += new System.EventHandler(this.TxtBxAra_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSliding);
            this.panel2.Controls.Add(this.TxtBxAra);
            this.panel2.Controls.Add(this.btnDel1);
            this.panel2.Controls.Add(this.btnSave1);
            this.panel2.Controls.Add(this.btnAdd1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 49);
            this.panel2.TabIndex = 10;
            // 
            // btnSliding
            // 
            this.btnSliding.BackColor = System.Drawing.Color.Black;
            this.btnSliding.BackgroundImage = global::TelefonRehberi.Properties.Resources.appbar_settings;
            this.btnSliding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSliding.FlatAppearance.BorderSize = 0;
            this.btnSliding.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSliding.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSliding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSliding.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSliding.Location = new System.Drawing.Point(0, 0);
            this.btnSliding.Margin = new System.Windows.Forms.Padding(0);
            this.btnSliding.Name = "btnSliding";
            this.btnSliding.Size = new System.Drawing.Size(36, 36);
            this.btnSliding.TabIndex = 1;
            this.btnSliding.TabStop = false;
            this.btnSliding.UseVisualStyleBackColor = false;
            // 
            // btnDel1
            // 
            this.btnDel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel1.BackgroundImage")));
            this.btnDel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel1.FlatAppearance.BorderSize = 0;
            this.btnDel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel1.ForeColor = System.Drawing.Color.White;
            this.btnDel1.Location = new System.Drawing.Point(127, 0);
            this.btnDel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnDel1.Name = "btnDel1";
            this.btnDel1.Size = new System.Drawing.Size(36, 36);
            this.btnDel1.TabIndex = 4;
            this.btnDel1.TabStop = false;
            this.btnDel1.UseVisualStyleBackColor = false;
            this.btnDel1.Click += new System.EventHandler(this.btnDel1_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave1.BackgroundImage")));
            this.btnSave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave1.FlatAppearance.BorderSize = 0;
            this.btnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave1.ForeColor = System.Drawing.Color.White;
            this.btnSave1.Location = new System.Drawing.Point(85, 0);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(36, 36);
            this.btnSave1.TabIndex = 3;
            this.btnSave1.TabStop = false;
            this.btnSave1.UseVisualStyleBackColor = false;
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.Color.Teal;
            this.btnAdd1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd1.BackgroundImage")));
            this.btnAdd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd1.FlatAppearance.BorderSize = 0;
            this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd1.ForeColor = System.Drawing.Color.White;
            this.btnAdd1.Location = new System.Drawing.Point(43, 0);
            this.btnAdd1.Margin = new System.Windows.Forms.Padding(6, 0, 3, 3);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(36, 36);
            this.btnAdd1.TabIndex = 2;
            this.btnAdd1.TabStop = false;
            this.btnAdd1.UseVisualStyleBackColor = false;
            // 
            // pnlSlidAyarlar
            // 
            this.pnlSlidAyarlar.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnlSlidAyarlar.Controls.Add(this.metroComboBox1);
            this.pnlSlidAyarlar.Controls.Add(this.button1);
            this.pnlSlidAyarlar.Controls.Add(this.pnlSliderTitle);
            this.pnlSlidAyarlar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlidAyarlar.Location = new System.Drawing.Point(20, 60);
            this.pnlSlidAyarlar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSlidAyarlar.Name = "pnlSlidAyarlar";
            this.pnlSlidAyarlar.Size = new System.Drawing.Size(40, 685);
            this.pnlSlidAyarlar.TabIndex = 11;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.metroComboBox1.Location = new System.Drawing.Point(-168, 68);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-26, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pnlSliderTitle
            // 
            this.pnlSliderTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSliderTitle.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnlSliderTitle.Controls.Add(this.lblAyarlar);
            this.pnlSliderTitle.Location = new System.Drawing.Point(-200, 0);
            this.pnlSliderTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSliderTitle.Name = "pnlSliderTitle";
            this.pnlSliderTitle.Size = new System.Drawing.Size(240, 36);
            this.pnlSliderTitle.TabIndex = 1;
            // 
            // lblAyarlar
            // 
            this.lblAyarlar.AutoSize = true;
            this.lblAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.lblAyarlar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAyarlar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAyarlar.Location = new System.Drawing.Point(87, 9);
            this.lblAyarlar.Name = "lblAyarlar";
            this.lblAyarlar.Size = new System.Drawing.Size(66, 19);
            this.lblAyarlar.TabIndex = 0;
            this.lblAyarlar.Text = "Ayarlar";
            // 
            // pnlSlidKisiEkle
            // 
            this.pnlSlidKisiEkle.BackColor = System.Drawing.Color.Teal;
            this.pnlSlidKisiEkle.Controls.Add(this.LblTelKntrl);
            this.pnlSlidKisiEkle.Controls.Add(this.LblSoyadKntrl);
            this.pnlSlidKisiEkle.Controls.Add(this.LblAdKntrl);
            this.pnlSlidKisiEkle.Controls.Add(this.btnSaveKisiEkle);
            this.pnlSlidKisiEkle.Controls.Add(this.TxtBxTelNo);
            this.pnlSlidKisiEkle.Controls.Add(this.TxtBxSirket);
            this.pnlSlidKisiEkle.Controls.Add(this.TxtBxEmail);
            this.pnlSlidKisiEkle.Controls.Add(this.TxtBxSoyad);
            this.pnlSlidKisiEkle.Controls.Add(this.TxtBxAd);
            this.pnlSlidKisiEkle.Controls.Add(this.panel6);
            this.pnlSlidKisiEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlidKisiEkle.Location = new System.Drawing.Point(60, 60);
            this.pnlSlidKisiEkle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSlidKisiEkle.Name = "pnlSlidKisiEkle";
            this.pnlSlidKisiEkle.Size = new System.Drawing.Size(40, 685);
            this.pnlSlidKisiEkle.TabIndex = 12;
            // 
            // LblTelKntrl
            // 
            this.LblTelKntrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTelKntrl.AutoSize = true;
            this.LblTelKntrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTelKntrl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTelKntrl.Location = new System.Drawing.Point(-175, 237);
            this.LblTelKntrl.Name = "LblTelKntrl";
            this.LblTelKntrl.Size = new System.Drawing.Size(15, 20);
            this.LblTelKntrl.TabIndex = 14;
            this.LblTelKntrl.Text = "*";
            // 
            // LblSoyadKntrl
            // 
            this.LblSoyadKntrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSoyadKntrl.AutoSize = true;
            this.LblSoyadKntrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyadKntrl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblSoyadKntrl.Location = new System.Drawing.Point(-177, 117);
            this.LblSoyadKntrl.Name = "LblSoyadKntrl";
            this.LblSoyadKntrl.Size = new System.Drawing.Size(15, 20);
            this.LblSoyadKntrl.TabIndex = 14;
            this.LblSoyadKntrl.Text = "*";
            // 
            // LblAdKntrl
            // 
            this.LblAdKntrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAdKntrl.AutoSize = true;
            this.LblAdKntrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdKntrl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblAdKntrl.Location = new System.Drawing.Point(-177, 77);
            this.LblAdKntrl.Name = "LblAdKntrl";
            this.LblAdKntrl.Size = new System.Drawing.Size(15, 20);
            this.LblAdKntrl.TabIndex = 14;
            this.LblAdKntrl.Text = "*";
            // 
            // btnSaveKisiEkle
            // 
            this.btnSaveKisiEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveKisiEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnSaveKisiEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveKisiEkle.BackgroundImage")));
            this.btnSaveKisiEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveKisiEkle.Enabled = false;
            this.btnSaveKisiEkle.FlatAppearance.BorderSize = 0;
            this.btnSaveKisiEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveKisiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveKisiEkle.ForeColor = System.Drawing.Color.White;
            this.btnSaveKisiEkle.Location = new System.Drawing.Point(-27, 280);
            this.btnSaveKisiEkle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnSaveKisiEkle.Name = "btnSaveKisiEkle";
            this.btnSaveKisiEkle.Size = new System.Drawing.Size(36, 36);
            this.btnSaveKisiEkle.TabIndex = 1;
            this.btnSaveKisiEkle.TabStop = false;
            this.btnSaveKisiEkle.UseMnemonic = false;
            this.btnSaveKisiEkle.UseVisualStyleBackColor = false;
            this.btnSaveKisiEkle.Click += new System.EventHandler(this.BtnSaveKisiEkle_Click);
            // 
            // TxtBxTelNo
            // 
            this.TxtBxTelNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtBxTelNo.CustomButton.Image = null;
            this.TxtBxTelNo.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.TxtBxTelNo.CustomButton.Name = "";
            this.TxtBxTelNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxTelNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxTelNo.CustomButton.TabIndex = 1;
            this.TxtBxTelNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxTelNo.CustomButton.UseSelectable = true;
            this.TxtBxTelNo.Lines = new string[0];
            this.TxtBxTelNo.Location = new System.Drawing.Point(-160, 234);
            this.TxtBxTelNo.MaxLength = 11;
            this.TxtBxTelNo.Name = "TxtBxTelNo";
            this.TxtBxTelNo.PasswordChar = '\0';
            this.TxtBxTelNo.PromptText = "555 555 55 55";
            this.TxtBxTelNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxTelNo.SelectedText = "";
            this.TxtBxTelNo.SelectionLength = 0;
            this.TxtBxTelNo.SelectionStart = 0;
            this.TxtBxTelNo.ShortcutsEnabled = true;
            this.TxtBxTelNo.ShowButton = true;
            this.TxtBxTelNo.ShowClearButton = true;
            this.TxtBxTelNo.Size = new System.Drawing.Size(169, 23);
            this.TxtBxTelNo.TabIndex = 12;
            this.TxtBxTelNo.UseSelectable = true;
            this.TxtBxTelNo.WaterMark = "555 555 55 55";
            this.TxtBxTelNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxTelNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBxTelNo.EnabledChanged += new System.EventHandler(this.TxtBxTelNo_EnabledChanged);
            this.TxtBxTelNo.TextChanged += new System.EventHandler(this.Txt_KisiEkle_TabStopChanged);
            // 
            // TxtBxSirket
            // 
            this.TxtBxSirket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtBxSirket.CustomButton.Image = null;
            this.TxtBxSirket.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.TxtBxSirket.CustomButton.Name = "";
            this.TxtBxSirket.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxSirket.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxSirket.CustomButton.TabIndex = 1;
            this.TxtBxSirket.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxSirket.CustomButton.UseSelectable = true;
            this.TxtBxSirket.CustomButton.Visible = false;
            this.TxtBxSirket.Lines = new string[0];
            this.TxtBxSirket.Location = new System.Drawing.Point(-160, 194);
            this.TxtBxSirket.MaxLength = 32767;
            this.TxtBxSirket.Name = "TxtBxSirket";
            this.TxtBxSirket.PasswordChar = '\0';
            this.TxtBxSirket.PromptText = "Şirket";
            this.TxtBxSirket.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxSirket.SelectedText = "";
            this.TxtBxSirket.SelectionLength = 0;
            this.TxtBxSirket.SelectionStart = 0;
            this.TxtBxSirket.ShortcutsEnabled = true;
            this.TxtBxSirket.ShowClearButton = true;
            this.TxtBxSirket.Size = new System.Drawing.Size(169, 23);
            this.TxtBxSirket.TabIndex = 11;
            this.TxtBxSirket.UseSelectable = true;
            this.TxtBxSirket.WaterMark = "Şirket";
            this.TxtBxSirket.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxSirket.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBxSirket.TextChanged += new System.EventHandler(this.Txt_KisiEkle_TabStopChanged);
            // 
            // TxtBxEmail
            // 
            this.TxtBxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtBxEmail.CustomButton.Image = null;
            this.TxtBxEmail.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.TxtBxEmail.CustomButton.Name = "";
            this.TxtBxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxEmail.CustomButton.TabIndex = 1;
            this.TxtBxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxEmail.CustomButton.UseSelectable = true;
            this.TxtBxEmail.CustomButton.Visible = false;
            this.TxtBxEmail.Lines = new string[0];
            this.TxtBxEmail.Location = new System.Drawing.Point(-160, 154);
            this.TxtBxEmail.MaxLength = 32767;
            this.TxtBxEmail.Name = "TxtBxEmail";
            this.TxtBxEmail.PasswordChar = '\0';
            this.TxtBxEmail.PromptText = "Email";
            this.TxtBxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxEmail.SelectedText = "";
            this.TxtBxEmail.SelectionLength = 0;
            this.TxtBxEmail.SelectionStart = 0;
            this.TxtBxEmail.ShortcutsEnabled = true;
            this.TxtBxEmail.ShowClearButton = true;
            this.TxtBxEmail.Size = new System.Drawing.Size(169, 23);
            this.TxtBxEmail.TabIndex = 11;
            this.TxtBxEmail.UseSelectable = true;
            this.TxtBxEmail.WaterMark = "Email";
            this.TxtBxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBxEmail.TextChanged += new System.EventHandler(this.Txt_KisiEkle_TabStopChanged);
            // 
            // TxtBxSoyad
            // 
            this.TxtBxSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtBxSoyad.CustomButton.Image = null;
            this.TxtBxSoyad.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.TxtBxSoyad.CustomButton.Name = "";
            this.TxtBxSoyad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxSoyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxSoyad.CustomButton.TabIndex = 1;
            this.TxtBxSoyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxSoyad.CustomButton.UseSelectable = true;
            this.TxtBxSoyad.CustomButton.Visible = false;
            this.TxtBxSoyad.Lines = new string[0];
            this.TxtBxSoyad.Location = new System.Drawing.Point(-160, 114);
            this.TxtBxSoyad.MaxLength = 32767;
            this.TxtBxSoyad.Name = "TxtBxSoyad";
            this.TxtBxSoyad.PasswordChar = '\0';
            this.TxtBxSoyad.PromptText = "Soyad";
            this.TxtBxSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxSoyad.SelectedText = "";
            this.TxtBxSoyad.SelectionLength = 0;
            this.TxtBxSoyad.SelectionStart = 0;
            this.TxtBxSoyad.ShortcutsEnabled = true;
            this.TxtBxSoyad.ShowClearButton = true;
            this.TxtBxSoyad.Size = new System.Drawing.Size(169, 23);
            this.TxtBxSoyad.TabIndex = 11;
            this.TxtBxSoyad.UseSelectable = true;
            this.TxtBxSoyad.WaterMark = "Soyad";
            this.TxtBxSoyad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxSoyad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBxSoyad.TextChanged += new System.EventHandler(this.Txt_KisiEkle_TabStopChanged);
            // 
            // TxtBxAd
            // 
            this.TxtBxAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtBxAd.CustomButton.Image = null;
            this.TxtBxAd.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.TxtBxAd.CustomButton.Name = "";
            this.TxtBxAd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxAd.CustomButton.TabIndex = 1;
            this.TxtBxAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxAd.CustomButton.UseSelectable = true;
            this.TxtBxAd.CustomButton.Visible = false;
            this.TxtBxAd.Lines = new string[0];
            this.TxtBxAd.Location = new System.Drawing.Point(-160, 74);
            this.TxtBxAd.MaxLength = 32767;
            this.TxtBxAd.Name = "TxtBxAd";
            this.TxtBxAd.PasswordChar = '\0';
            this.TxtBxAd.PromptText = "Ad";
            this.TxtBxAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxAd.SelectedText = "";
            this.TxtBxAd.SelectionLength = 0;
            this.TxtBxAd.SelectionStart = 0;
            this.TxtBxAd.ShortcutsEnabled = true;
            this.TxtBxAd.ShowClearButton = true;
            this.TxtBxAd.Size = new System.Drawing.Size(169, 23);
            this.TxtBxAd.TabIndex = 10;
            this.TxtBxAd.UseSelectable = true;
            this.TxtBxAd.WaterMark = "Ad";
            this.TxtBxAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBxAd.TextChanged += new System.EventHandler(this.Txt_KisiEkle_TabStopChanged);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.lblEkleTitle);
            this.panel6.Location = new System.Drawing.Point(-200, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 36);
            this.panel6.TabIndex = 1;
            // 
            // lblEkleTitle
            // 
            this.lblEkleTitle.AutoSize = true;
            this.lblEkleTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblEkleTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkleTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEkleTitle.Location = new System.Drawing.Point(71, 9);
            this.lblEkleTitle.Name = "lblEkleTitle";
            this.lblEkleTitle.Size = new System.Drawing.Size(77, 19);
            this.lblEkleTitle.TabIndex = 0;
            this.lblEkleTitle.Text = "Kişi Ekle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KisilerID,
            this.KisiAdi,
            this.KisiSoyadi,
            this.TelNo,
            this.Email,
            this.Sirket});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(564, 573);
            this.dataGridView1.Style = MetroFramework.MetroColorStyle.Teal;
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDataView_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // KisilerID
            // 
            this.KisilerID.DataPropertyName = "KisilerID";
            this.KisilerID.HeaderText = "Kisi ID";
            this.KisilerID.Name = "KisilerID";
            this.KisilerID.Visible = false;
            // 
            // KisiAdi
            // 
            this.KisiAdi.DataPropertyName = "KisiAdi";
            this.KisiAdi.HeaderText = "Kişi Adı";
            this.KisiAdi.MaxInputLength = 15;
            this.KisiAdi.Name = "KisiAdi";
            // 
            // KisiSoyadi
            // 
            this.KisiSoyadi.DataPropertyName = "KisiSoyadi";
            this.KisiSoyadi.HeaderText = "Kişi Soyadı";
            this.KisiSoyadi.MaxInputLength = 20;
            this.KisiSoyadi.Name = "KisiSoyadi";
            // 
            // TelNo
            // 
            this.TelNo.DataPropertyName = "TelNo";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TelNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.TelNo.HeaderText = "Tel No";
            this.TelNo.MaxInputLength = 11;
            this.TelNo.Name = "TelNo";
            this.TelNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MaxInputLength = 50;
            this.Email.Name = "Email";
            // 
            // Sirket
            // 
            this.Sirket.DataPropertyName = "Sirket";
            this.Sirket.HeaderText = "Şirket";
            this.Sirket.MaxInputLength = 50;
            this.Sirket.Name = "Sirket";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(100, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Size = new System.Drawing.Size(584, 685);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 14;
            this.metroTabControl1.UseSelectable = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.metroTile2);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(100, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(584, 685);
            this.panel5.TabIndex = 15;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Enabled = false;
            this.metroTile2.Location = new System.Drawing.Point(0, 55);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(1224, 6);
            this.metroTile2.TabIndex = 11;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(704, 745);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.pnlSlidKisiEkle);
            this.Controls.Add(this.pnlSlidAyarlar);
            this.Name = "AnaForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Telefon Rehberi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlSlidAyarlar.ResumeLayout(false);
            this.pnlSliderTitle.ResumeLayout(false);
            this.pnlSliderTitle.PerformLayout();
            this.pnlSlidKisiEkle.ResumeLayout(false);
            this.pnlSlidKisiEkle.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnDel1;
        private MetroFramework.Controls.MetroTextBox TxtBxAra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSlidAyarlar;
        private System.Windows.Forms.Button btnSliding;
        private System.Windows.Forms.Panel pnlSliderTitle;
        private System.Windows.Forms.Label lblAyarlar;
        private System.Windows.Forms.Panel pnlSlidKisiEkle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblEkleTitle;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox TxtBxAd;
        private MetroFramework.Controls.MetroTextBox TxtBxTelNo;
        private MetroFramework.Controls.MetroTextBox TxtBxSoyad;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Label LblTelKntrl;
        private System.Windows.Forms.Label LblSoyadKntrl;
        private System.Windows.Forms.Label LblAdKntrl;
        private System.Windows.Forms.Button btnSaveKisiEkle;
        private MetroFramework.Controls.MetroTextBox TxtBxSirket;
        private MetroFramework.Controls.MetroTextBox TxtBxEmail;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KisilerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KisiAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KisiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sirket;
    }
}

