namespace _4dbtnc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbltitle = new Label();
            Ttenkhachhang = new Label();
            Tsokhachhang = new Label();
            Inputten = new TextBox();
            Inputso = new TextBox();
            chkSinhVien = new CheckBox();
            Tnuocuong = new Label();
            Tthucan = new Label();
            Ttongkhachhang = new Label();
            Ttongtien = new Label();
            Outputkhachhang = new TextBox();
            Outputthanhtoan = new TextBox();
            button_tinhtien = new Button();
            button_nhaplai = new Button();
            button_thanhtoan = new Button();
            button_thoat = new Button();
            radioButton_cfden = new RadioButton();
            radioButton_cfsua = new RadioButton();
            radioButton_cfsuada = new RadioButton();
            radioButton_cfda = new RadioButton();
            radioButton_cfkem = new RadioButton();
            chkBanhMiTrung = new CheckBox();
            chkMyXaoBo = new CheckBox();
            chkBanhMiCa = new CheckBox();
            chkMyCay = new CheckBox();
            chkMiTomTrung = new CheckBox();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.FromArgb(255, 128, 0);
            lbltitle.Location = new Point(146, 6);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(218, 38);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "CAFE SINH VIÊN";
            // 
            // Ttenkhachhang
            // 
            Ttenkhachhang.AutoSize = true;
            Ttenkhachhang.Location = new Point(18, 50);
            Ttenkhachhang.Name = "Ttenkhachhang";
            Ttenkhachhang.Size = new Size(111, 20);
            Ttenkhachhang.TabIndex = 1;
            Ttenkhachhang.Text = "Tên khách hàng";
            // 
            // Tsokhachhang
            // 
            Tsokhachhang.AutoSize = true;
            Tsokhachhang.Location = new Point(18, 93);
            Tsokhachhang.Name = "Tsokhachhang";
            Tsokhachhang.Size = new Size(105, 20);
            Tsokhachhang.TabIndex = 2;
            Tsokhachhang.Text = "Số khách hàng";
            // 
            // Inputten
            // 
            Inputten.Location = new Point(146, 47);
            Inputten.Name = "Inputten";
            Inputten.Size = new Size(355, 27);
            Inputten.TabIndex = 3;
            Inputten.TextChanged += txtDuLieu_TextChanged;
            // 
            // Inputso
            // 
            Inputso.Location = new Point(146, 86);
            Inputso.Name = "Inputso";
            Inputso.Size = new Size(355, 27);
            Inputso.TabIndex = 4;
            Inputso.TextChanged += txtDuLieu_TextChanged;
            Inputso.KeyPress += Inputso_KeyPress;
            // 
            // chkSinhVien
            // 
            chkSinhVien.AutoSize = true;
            chkSinhVien.Location = new Point(146, 119);
            chkSinhVien.Name = "chkSinhVien";
            chkSinhVien.Size = new Size(101, 24);
            chkSinhVien.TabIndex = 5;
            chkSinhVien.Text = "Sinh viên ?";
            chkSinhVien.UseVisualStyleBackColor = true;
            // 
            // Tnuocuong
            // 
            Tnuocuong.AutoSize = true;
            Tnuocuong.Location = new Point(12, 160);
            Tnuocuong.Name = "Tnuocuong";
            Tnuocuong.Size = new Size(83, 20);
            Tnuocuong.TabIndex = 6;
            Tnuocuong.Text = "Nước uống";
            // 
            // Tthucan
            // 
            Tthucan.AutoSize = true;
            Tthucan.Location = new Point(293, 160);
            Tthucan.Name = "Tthucan";
            Tthucan.Size = new Size(61, 20);
            Tthucan.TabIndex = 7;
            Tthucan.Text = "Thức ăn";
            // 
            // Ttongkhachhang
            // 
            Ttongkhachhang.AutoSize = true;
            Ttongkhachhang.Location = new Point(18, 357);
            Ttongkhachhang.Name = "Ttongkhachhang";
            Ttongkhachhang.Size = new Size(122, 20);
            Ttongkhachhang.TabIndex = 8;
            Ttongkhachhang.Text = "Tổng khách hàng";
            // 
            // Ttongtien
            // 
            Ttongtien.AutoSize = true;
            Ttongtien.Location = new Point(18, 390);
            Ttongtien.Name = "Ttongtien";
            Ttongtien.Size = new Size(147, 20);
            Ttongtien.TabIndex = 9;
            Ttongtien.Text = "Tổng tiền thanh toán";
            // 
            // Outputkhachhang
            // 
            Outputkhachhang.Location = new Point(183, 354);
            Outputkhachhang.Name = "Outputkhachhang";
            Outputkhachhang.Size = new Size(318, 27);
            Outputkhachhang.TabIndex = 10;
            // 
            // Outputthanhtoan
            // 
            Outputthanhtoan.Location = new Point(183, 387);
            Outputthanhtoan.Name = "Outputthanhtoan";
            Outputthanhtoan.Size = new Size(318, 27);
            Outputthanhtoan.TabIndex = 11;
            // 
            // button_tinhtien
            // 
            button_tinhtien.Location = new Point(12, 302);
            button_tinhtien.Name = "button_tinhtien";
            button_tinhtien.Size = new Size(94, 43);
            button_tinhtien.TabIndex = 12;
            button_tinhtien.Text = "Tính tiền";
            button_tinhtien.UseVisualStyleBackColor = true;
            button_tinhtien.Click += button_tinhtien_Click;
            // 
            // button_nhaplai
            // 
            button_nhaplai.Location = new Point(135, 302);
            button_nhaplai.Name = "button_nhaplai";
            button_nhaplai.Size = new Size(94, 43);
            button_nhaplai.TabIndex = 13;
            button_nhaplai.Text = "Nhập lại";
            button_nhaplai.UseVisualStyleBackColor = true;
            button_nhaplai.Click += button_nhaplai_Click;
            // 
            // button_thanhtoan
            // 
            button_thanhtoan.Location = new Point(270, 302);
            button_thanhtoan.Name = "button_thanhtoan";
            button_thanhtoan.Size = new Size(94, 43);
            button_thanhtoan.TabIndex = 14;
            button_thanhtoan.Text = "Thanh toán";
            button_thanhtoan.UseVisualStyleBackColor = true;
            button_thanhtoan.Click += button_thanhtoan_Click;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(407, 302);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(94, 43);
            button_thoat.TabIndex = 15;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // radioButton_cfden
            // 
            radioButton_cfden.AutoSize = true;
            radioButton_cfden.Location = new Point(12, 183);
            radioButton_cfden.Name = "radioButton_cfden";
            radioButton_cfden.Size = new Size(89, 24);
            radioButton_cfden.TabIndex = 16;
            radioButton_cfden.TabStop = true;
            radioButton_cfden.Text = "Cafe đen";
            radioButton_cfden.UseVisualStyleBackColor = true;
            radioButton_cfden.CheckedChanged += LuaChon_CheckedChanged;
            // 
            // radioButton_cfsua
            // 
            radioButton_cfsua.AutoSize = true;
            radioButton_cfsua.Location = new Point(12, 213);
            radioButton_cfsua.Name = "radioButton_cfsua";
            radioButton_cfsua.Size = new Size(87, 24);
            radioButton_cfsua.TabIndex = 17;
            radioButton_cfsua.TabStop = true;
            radioButton_cfsua.Text = "Cafe sữa";
            radioButton_cfsua.UseVisualStyleBackColor = true;
            radioButton_cfsua.CheckedChanged += LuaChon_CheckedChanged;
            // 
            // radioButton_cfsuada
            // 
            radioButton_cfsuada.AutoSize = true;
            radioButton_cfsuada.Location = new Point(12, 243);
            radioButton_cfsuada.Name = "radioButton_cfsuada";
            radioButton_cfsuada.Size = new Size(108, 24);
            radioButton_cfsuada.TabIndex = 18;
            radioButton_cfsuada.TabStop = true;
            radioButton_cfsuada.Text = "Cafe sữa đá";
            radioButton_cfsuada.UseVisualStyleBackColor = true;
            radioButton_cfsuada.CheckedChanged += LuaChon_CheckedChanged;
            // 
            // radioButton_cfda
            // 
            radioButton_cfda.AutoSize = true;
            radioButton_cfda.Location = new Point(132, 183);
            radioButton_cfda.Name = "radioButton_cfda";
            radioButton_cfda.Size = new Size(81, 24);
            radioButton_cfda.TabIndex = 19;
            radioButton_cfda.TabStop = true;
            radioButton_cfda.Text = "Cafe đá";
            radioButton_cfda.UseVisualStyleBackColor = true;
            radioButton_cfda.CheckedChanged += LuaChon_CheckedChanged;
            // 
            // radioButton_cfkem
            // 
            radioButton_cfkem.AutoSize = true;
            radioButton_cfkem.Location = new Point(135, 213);
            radioButton_cfkem.Name = "radioButton_cfkem";
            radioButton_cfkem.Size = new Size(92, 24);
            radioButton_cfkem.TabIndex = 20;
            radioButton_cfkem.TabStop = true;
            radioButton_cfkem.Text = "Cafe kem";
            radioButton_cfkem.UseVisualStyleBackColor = true;
            radioButton_cfkem.CheckedChanged += LuaChon_CheckedChanged;
            // 
            // chkBanhMiTrung
            // 
            chkBanhMiTrung.AutoSize = true;
            chkBanhMiTrung.Location = new Point(293, 184);
            chkBanhMiTrung.Name = "chkBanhMiTrung";
            chkBanhMiTrung.Size = new Size(128, 24);
            chkBanhMiTrung.TabIndex = 21;
            chkBanhMiTrung.Text = "Bánh mỳ trứng";
            chkBanhMiTrung.UseVisualStyleBackColor = true;
            // 
            // chkMyXaoBo
            // 
            chkMyXaoBo.AutoSize = true;
            chkMyXaoBo.Location = new Point(402, 184);
            chkMyXaoBo.Name = "chkMyXaoBo";
            chkMyXaoBo.Size = new Size(101, 24);
            chkMyXaoBo.TabIndex = 22;
            chkMyXaoBo.Text = "Mỳ xào bò";
            chkMyXaoBo.UseVisualStyleBackColor = true;
            // 
            // chkBanhMiCa
            // 
            chkBanhMiCa.AutoSize = true;
            chkBanhMiCa.Location = new Point(293, 213);
            chkBanhMiCa.Name = "chkBanhMiCa";
            chkBanhMiCa.Size = new Size(107, 24);
            chkBanhMiCa.TabIndex = 23;
            chkBanhMiCa.Text = "bánh mỳ cá";
            chkBanhMiCa.UseVisualStyleBackColor = true;
            // 
            // chkMyCay
            // 
            chkMyCay.AutoSize = true;
            chkMyCay.Location = new Point(400, 214);
            chkMyCay.Name = "chkMyCay";
            chkMyCay.Size = new Size(77, 24);
            chkMyCay.TabIndex = 24;
            chkMyCay.Text = "Mỳ cay";
            chkMyCay.UseVisualStyleBackColor = true;
            // 
            // chkMiTomTrung
            // 
            chkMiTomTrung.AutoSize = true;
            chkMiTomTrung.Location = new Point(293, 243);
            chkMiTomTrung.Name = "chkMiTomTrung";
            chkMiTomTrung.Size = new Size(122, 24);
            chkMiTomTrung.TabIndex = 25;
            chkMiTomTrung.Text = "Mỳ tôm trứng";
            chkMiTomTrung.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 429);
            Controls.Add(chkMiTomTrung);
            Controls.Add(chkMyCay);
            Controls.Add(chkBanhMiCa);
            Controls.Add(chkMyXaoBo);
            Controls.Add(chkBanhMiTrung);
            Controls.Add(radioButton_cfkem);
            Controls.Add(radioButton_cfda);
            Controls.Add(radioButton_cfsuada);
            Controls.Add(radioButton_cfsua);
            Controls.Add(radioButton_cfden);
            Controls.Add(button_thoat);
            Controls.Add(button_thanhtoan);
            Controls.Add(button_nhaplai);
            Controls.Add(button_tinhtien);
            Controls.Add(Outputthanhtoan);
            Controls.Add(Outputkhachhang);
            Controls.Add(Ttongtien);
            Controls.Add(Ttongkhachhang);
            Controls.Add(Tthucan);
            Controls.Add(Tnuocuong);
            Controls.Add(chkSinhVien);
            Controls.Add(Inputso);
            Controls.Add(Inputten);
            Controls.Add(Tsokhachhang);
            Controls.Add(Ttenkhachhang);
            Controls.Add(lbltitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label Ttenkhachhang;
        private Label Tsokhachhang;
        private TextBox Inputten;
        private TextBox Inputso;
        private CheckBox chkSinhVien;
        private Label Tnuocuong;
        private Label Tthucan;
        private Label Ttongkhachhang;
        private Label Ttongtien;
        private TextBox Outputkhachhang;
        private TextBox Outputthanhtoan;
        private Button button_tinhtien;
        private Button button_nhaplai;
        private Button button_thanhtoan;
        private Button button_thoat;
        private RadioButton radioButton_cfden;
        private RadioButton radioButton_cfsua;
        private RadioButton radioButton_cfsuada;
        private RadioButton radioButton_cfda;
        private RadioButton radioButton_cfkem;
        private CheckBox chkBanhMiTrung;
        private CheckBox chkMyXaoBo;
        private CheckBox chkBanhMiCa;
        private CheckBox chkMyCay;
        private CheckBox chkMiTomTrung;
    }
}
