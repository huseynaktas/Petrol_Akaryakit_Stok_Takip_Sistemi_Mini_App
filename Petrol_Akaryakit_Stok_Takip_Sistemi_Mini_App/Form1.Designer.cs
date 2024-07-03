namespace Petrol_Akaryakit_Stok_Takip_Sistemi_Mini_App
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKur95 = new System.Windows.Forms.Label();
            this.lblKur97 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDieMax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiePro = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOtogaz = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTutOtogaz = new System.Windows.Forms.TextBox();
            this.txtTutDieP = new System.Windows.Forms.TextBox();
            this.txtTutDieM = new System.Windows.Forms.TextBox();
            this.txtTutK97 = new System.Windows.Forms.TextBox();
            this.txtTutK95 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDepoDoldur = new System.Windows.Forms.Button();
            this.pgbK95 = new System.Windows.Forms.ProgressBar();
            this.pgbK97 = new System.Windows.Forms.ProgressBar();
            this.pgbDieM = new System.Windows.Forms.ProgressBar();
            this.pgbDieP = new System.Windows.Forms.ProgressBar();
            this.pgbOtogaz = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.lblStokK95 = new System.Windows.Forms.Label();
            this.lblStokK97 = new System.Windows.Forms.Label();
            this.lblStokDieM = new System.Windows.Forms.Label();
            this.lblStokDieP = new System.Windows.Forms.Label();
            this.lblStokOtogaz = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.numKur95 = new System.Windows.Forms.NumericUpDown();
            this.numKur97 = new System.Windows.Forms.NumericUpDown();
            this.numDieM = new System.Windows.Forms.NumericUpDown();
            this.numDieP = new System.Windows.Forms.NumericUpDown();
            this.numOtogaz = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKur95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKur97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDieM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDieP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOtogaz)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOtogaz);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblDiePro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblDieMax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblKur97);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblKur95);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(262, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurşunsuz 95:";
            // 
            // lblKur95
            // 
            this.lblKur95.AutoSize = true;
            this.lblKur95.ForeColor = System.Drawing.Color.White;
            this.lblKur95.Location = new System.Drawing.Point(165, 65);
            this.lblKur95.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKur95.Name = "lblKur95";
            this.lblKur95.Size = new System.Drawing.Size(61, 18);
            this.lblKur95.TabIndex = 1;
            this.lblKur95.Text = "label2";
            // 
            // lblKur97
            // 
            this.lblKur97.AutoSize = true;
            this.lblKur97.ForeColor = System.Drawing.Color.White;
            this.lblKur97.Location = new System.Drawing.Point(166, 103);
            this.lblKur97.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKur97.Name = "lblKur97";
            this.lblKur97.Size = new System.Drawing.Size(61, 18);
            this.lblKur97.TabIndex = 3;
            this.lblKur97.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kurşunsuz 97:";
            // 
            // lblDieMax
            // 
            this.lblDieMax.AutoSize = true;
            this.lblDieMax.ForeColor = System.Drawing.Color.White;
            this.lblDieMax.Location = new System.Drawing.Point(166, 144);
            this.lblDieMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDieMax.Name = "lblDieMax";
            this.lblDieMax.Size = new System.Drawing.Size(61, 18);
            this.lblDieMax.TabIndex = 5;
            this.lblDieMax.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Diesel Max:";
            // 
            // lblDiePro
            // 
            this.lblDiePro.AutoSize = true;
            this.lblDiePro.ForeColor = System.Drawing.Color.White;
            this.lblDiePro.Location = new System.Drawing.Point(166, 189);
            this.lblDiePro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiePro.Name = "lblDiePro";
            this.lblDiePro.Size = new System.Drawing.Size(60, 18);
            this.lblDiePro.TabIndex = 7;
            this.lblDiePro.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(53, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Diesel Pro:";
            // 
            // lblOtogaz
            // 
            this.lblOtogaz.AutoSize = true;
            this.lblOtogaz.ForeColor = System.Drawing.Color.White;
            this.lblOtogaz.Location = new System.Drawing.Point(165, 233);
            this.lblOtogaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtogaz.Name = "lblOtogaz";
            this.lblOtogaz.Size = new System.Drawing.Size(61, 18);
            this.lblOtogaz.TabIndex = 9;
            this.lblOtogaz.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(76, 233);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Otogaz:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numOtogaz);
            this.groupBox2.Controls.Add(this.numDieP);
            this.groupBox2.Controls.Add(this.numDieM);
            this.groupBox2.Controls.Add(this.numKur97);
            this.groupBox2.Controls.Add(this.numKur95);
            this.groupBox2.Controls.Add(this.txtPlaka);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.btnDepoDoldur);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTutOtogaz);
            this.groupBox2.Controls.Add(this.txtTutDieP);
            this.groupBox2.Controls.Add(this.txtTutDieM);
            this.groupBox2.Controls.Add(this.txtTutK97);
            this.groupBox2.Controls.Add(this.txtTutK95);
            this.groupBox2.Location = new System.Drawing.Point(285, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 387);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStokOtogaz);
            this.groupBox3.Controls.Add(this.lblStokDieP);
            this.groupBox3.Controls.Add(this.lblStokDieM);
            this.groupBox3.Controls.Add(this.lblStokK97);
            this.groupBox3.Controls.Add(this.lblStokK95);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.pgbOtogaz);
            this.groupBox3.Controls.Add(this.pgbDieP);
            this.groupBox3.Controls.Add(this.pgbDieM);
            this.groupBox3.Controls.Add(this.pgbK97);
            this.groupBox3.Controls.Add(this.pgbK95);
            this.groupBox3.Location = new System.Drawing.Point(656, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 278);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txtTutOtogaz
            // 
            this.txtTutOtogaz.Enabled = false;
            this.txtTutOtogaz.Location = new System.Drawing.Point(192, 229);
            this.txtTutOtogaz.Name = "txtTutOtogaz";
            this.txtTutOtogaz.Size = new System.Drawing.Size(134, 26);
            this.txtTutOtogaz.TabIndex = 9;
            // 
            // txtTutDieP
            // 
            this.txtTutDieP.Enabled = false;
            this.txtTutDieP.Location = new System.Drawing.Point(192, 185);
            this.txtTutDieP.Name = "txtTutDieP";
            this.txtTutDieP.Size = new System.Drawing.Size(134, 26);
            this.txtTutDieP.TabIndex = 8;
            // 
            // txtTutDieM
            // 
            this.txtTutDieM.Enabled = false;
            this.txtTutDieM.Location = new System.Drawing.Point(192, 140);
            this.txtTutDieM.Name = "txtTutDieM";
            this.txtTutDieM.Size = new System.Drawing.Size(134, 26);
            this.txtTutDieM.TabIndex = 7;
            // 
            // txtTutK97
            // 
            this.txtTutK97.Enabled = false;
            this.txtTutK97.Location = new System.Drawing.Point(192, 99);
            this.txtTutK97.Name = "txtTutK97";
            this.txtTutK97.Size = new System.Drawing.Size(134, 26);
            this.txtTutK97.TabIndex = 6;
            // 
            // txtTutK95
            // 
            this.txtTutK95.Enabled = false;
            this.txtTutK95.Location = new System.Drawing.Point(192, 61);
            this.txtTutK95.Name = "txtTutK95";
            this.txtTutK95.Size = new System.Drawing.Size(134, 26);
            this.txtTutK95.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(53, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Litre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(223, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tutar";
            // 
            // btnDepoDoldur
            // 
            this.btnDepoDoldur.Location = new System.Drawing.Point(26, 316);
            this.btnDepoDoldur.Name = "btnDepoDoldur";
            this.btnDepoDoldur.Size = new System.Drawing.Size(300, 34);
            this.btnDepoDoldur.TabIndex = 12;
            this.btnDepoDoldur.Text = "Depo Doldur";
            this.btnDepoDoldur.UseVisualStyleBackColor = true;
            this.btnDepoDoldur.Click += new System.EventHandler(this.btnDepoDoldur_Click);
            // 
            // pgbK95
            // 
            this.pgbK95.Location = new System.Drawing.Point(37, 63);
            this.pgbK95.Maximum = 10001;
            this.pgbK95.Name = "pgbK95";
            this.pgbK95.Size = new System.Drawing.Size(285, 23);
            this.pgbK95.TabIndex = 0;
            // 
            // pgbK97
            // 
            this.pgbK97.Location = new System.Drawing.Point(37, 102);
            this.pgbK97.Maximum = 10001;
            this.pgbK97.Name = "pgbK97";
            this.pgbK97.Size = new System.Drawing.Size(285, 23);
            this.pgbK97.TabIndex = 1;
            // 
            // pgbDieM
            // 
            this.pgbDieM.Location = new System.Drawing.Point(37, 143);
            this.pgbDieM.Maximum = 10001;
            this.pgbDieM.Name = "pgbDieM";
            this.pgbDieM.Size = new System.Drawing.Size(285, 23);
            this.pgbDieM.TabIndex = 2;
            // 
            // pgbDieP
            // 
            this.pgbDieP.Location = new System.Drawing.Point(37, 188);
            this.pgbDieP.Maximum = 10001;
            this.pgbDieP.Name = "pgbDieP";
            this.pgbDieP.Size = new System.Drawing.Size(285, 23);
            this.pgbDieP.TabIndex = 3;
            // 
            // pgbOtogaz
            // 
            this.pgbOtogaz.Location = new System.Drawing.Point(37, 232);
            this.pgbOtogaz.Maximum = 10001;
            this.pgbOtogaz.Name = "pgbOtogaz";
            this.pgbOtogaz.Size = new System.Drawing.Size(285, 23);
            this.pgbOtogaz.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(165, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "Depo Stok Miktarı (L)";
            // 
            // lblStokK95
            // 
            this.lblStokK95.AutoSize = true;
            this.lblStokK95.ForeColor = System.Drawing.Color.White;
            this.lblStokK95.Location = new System.Drawing.Point(355, 64);
            this.lblStokK95.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStokK95.Name = "lblStokK95";
            this.lblStokK95.Size = new System.Drawing.Size(46, 18);
            this.lblStokK95.TabIndex = 14;
            this.lblStokK95.Text = "0,00";
            // 
            // lblStokK97
            // 
            this.lblStokK97.AutoSize = true;
            this.lblStokK97.ForeColor = System.Drawing.Color.White;
            this.lblStokK97.Location = new System.Drawing.Point(355, 102);
            this.lblStokK97.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStokK97.Name = "lblStokK97";
            this.lblStokK97.Size = new System.Drawing.Size(46, 18);
            this.lblStokK97.TabIndex = 15;
            this.lblStokK97.Text = "0,00";
            // 
            // lblStokDieM
            // 
            this.lblStokDieM.AutoSize = true;
            this.lblStokDieM.ForeColor = System.Drawing.Color.White;
            this.lblStokDieM.Location = new System.Drawing.Point(355, 143);
            this.lblStokDieM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStokDieM.Name = "lblStokDieM";
            this.lblStokDieM.Size = new System.Drawing.Size(46, 18);
            this.lblStokDieM.TabIndex = 16;
            this.lblStokDieM.Text = "0,00";
            // 
            // lblStokDieP
            // 
            this.lblStokDieP.AutoSize = true;
            this.lblStokDieP.ForeColor = System.Drawing.Color.White;
            this.lblStokDieP.Location = new System.Drawing.Point(355, 188);
            this.lblStokDieP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStokDieP.Name = "lblStokDieP";
            this.lblStokDieP.Size = new System.Drawing.Size(46, 18);
            this.lblStokDieP.TabIndex = 17;
            this.lblStokDieP.Text = "0,00";
            // 
            // lblStokOtogaz
            // 
            this.lblStokOtogaz.AutoSize = true;
            this.lblStokOtogaz.ForeColor = System.Drawing.Color.White;
            this.lblStokOtogaz.Location = new System.Drawing.Point(355, 232);
            this.lblStokOtogaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStokOtogaz.Name = "lblStokOtogaz";
            this.lblStokOtogaz.Size = new System.Drawing.Size(46, 18);
            this.lblStokOtogaz.TabIndex = 18;
            this.lblStokOtogaz.Text = "0,00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblKasa);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(657, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(441, 102);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(53, 274);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 18);
            this.label19.TabIndex = 13;
            this.label19.Text = "Plaka:";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(148, 271);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(134, 26);
            this.txtPlaka.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(133, 47);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 18);
            this.label20.TabIndex = 14;
            this.label20.Text = "Kasa:";
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.ForeColor = System.Drawing.Color.White;
            this.lblKasa.Location = new System.Drawing.Point(197, 47);
            this.lblKasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(46, 18);
            this.lblKasa.TabIndex = 15;
            this.lblKasa.Text = "0,00";
            // 
            // numKur95
            // 
            this.numKur95.Location = new System.Drawing.Point(26, 61);
            this.numKur95.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKur95.Name = "numKur95";
            this.numKur95.Size = new System.Drawing.Size(140, 26);
            this.numKur95.TabIndex = 15;
            this.numKur95.ValueChanged += new System.EventHandler(this.numKur95_ValueChanged);
            // 
            // numKur97
            // 
            this.numKur97.Location = new System.Drawing.Point(26, 99);
            this.numKur97.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKur97.Name = "numKur97";
            this.numKur97.Size = new System.Drawing.Size(140, 26);
            this.numKur97.TabIndex = 16;
            this.numKur97.ValueChanged += new System.EventHandler(this.numKur97_ValueChanged);
            // 
            // numDieM
            // 
            this.numDieM.Location = new System.Drawing.Point(26, 140);
            this.numDieM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDieM.Name = "numDieM";
            this.numDieM.Size = new System.Drawing.Size(140, 26);
            this.numDieM.TabIndex = 17;
            this.numDieM.ValueChanged += new System.EventHandler(this.numDieM_ValueChanged);
            // 
            // numDieP
            // 
            this.numDieP.Location = new System.Drawing.Point(26, 185);
            this.numDieP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDieP.Name = "numDieP";
            this.numDieP.Size = new System.Drawing.Size(140, 26);
            this.numDieP.TabIndex = 18;
            this.numDieP.ValueChanged += new System.EventHandler(this.numDieP_ValueChanged);
            // 
            // numOtogaz
            // 
            this.numOtogaz.Location = new System.Drawing.Point(26, 229);
            this.numOtogaz.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numOtogaz.Name = "numOtogaz";
            this.numOtogaz.Size = new System.Drawing.Size(140, 26);
            this.numOtogaz.TabIndex = 19;
            this.numOtogaz.ValueChanged += new System.EventHandler(this.numOtogaz_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1116, 422);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Petrol Vadisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKur95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKur97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDieM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDieP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOtogaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDieMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKur97;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKur95;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOtogaz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDiePro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDepoDoldur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTutOtogaz;
        private System.Windows.Forms.TextBox txtTutDieP;
        private System.Windows.Forms.TextBox txtTutDieM;
        private System.Windows.Forms.TextBox txtTutK97;
        private System.Windows.Forms.TextBox txtTutK95;
        private System.Windows.Forms.ProgressBar pgbK95;
        private System.Windows.Forms.Label lblStokOtogaz;
        private System.Windows.Forms.Label lblStokDieP;
        private System.Windows.Forms.Label lblStokDieM;
        private System.Windows.Forms.Label lblStokK97;
        private System.Windows.Forms.Label lblStokK95;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar pgbOtogaz;
        private System.Windows.Forms.ProgressBar pgbDieP;
        private System.Windows.Forms.ProgressBar pgbDieM;
        private System.Windows.Forms.ProgressBar pgbK97;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numOtogaz;
        private System.Windows.Forms.NumericUpDown numDieP;
        private System.Windows.Forms.NumericUpDown numDieM;
        private System.Windows.Forms.NumericUpDown numKur97;
        private System.Windows.Forms.NumericUpDown numKur95;
    }
}

