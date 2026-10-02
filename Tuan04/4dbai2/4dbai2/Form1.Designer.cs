namespace _4dbai2
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
            Tketqua = new Label();
            button_nhapmang = new Button();
            button_reset = new Button();
            button_thoat = new Button();
            Inputmang = new TextBox();
            Outputmang = new TextBox();
            button_thuchien = new Button();
            button_tong = new Button();
            Tsapxep = new Label();
            radioButton_tang = new RadioButton();
            radioButton_giam = new RadioButton();
            Ttimkiem = new Label();
            radioButton_giatritim = new RadioButton();
            radioButton_vitritim = new RadioButton();
            Inputgiatritim = new TextBox();
            Inputvitritim = new TextBox();
            Tsotimduoc = new Label();
            Outputtim = new TextBox();
            Txoa = new Label();
            radioButton_giatrixoa = new RadioButton();
            radioButton_vitrixoa = new RadioButton();
            Inputgiatrixoa = new TextBox();
            Inputvitrixoa = new TextBox();
            Tsapxeptang = new Label();
            Tthem = new Label();
            radioButton_giatrithem = new RadioButton();
            Inputgiatrithem = new TextBox();
            Tcanthem = new Label();
            Inputvitrithem = new TextBox();
            Tsapxepthemtang = new Label();
            Ttong = new Label();
            Ttongmang = new Label();
            Ttongchan = new Label();
            Ttongle = new Label();
            Outputtongmang = new TextBox();
            Outputtongchan = new TextBox();
            Outputtongle = new TextBox();
            Tmaxmin = new Label();
            Tgtln = new Label();
            Tgtnn = new Label();
            Outputmax = new TextBox();
            Outputmin = new TextBox();
            button_tim = new Button();
            Tthaythe = new Label();
            radioButton_giatricanthay = new RadioButton();
            radioButton_vitrithaythe = new RadioButton();
            Tsothaythe = new Label();
            Inputgiatrithay = new TextBox();
            Inputvitrithay = new TextBox();
            Inputsothaythe = new TextBox();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.Red;
            lbltitle.Location = new Point(63, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(250, 41);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Mảng Số Nguyên";
            // 
            // Tketqua
            // 
            Tketqua.AutoSize = true;
            Tketqua.Location = new Point(12, 113);
            Tketqua.Name = "Tketqua";
            Tketqua.Size = new Size(109, 20);
            Tketqua.TabIndex = 1;
            Tketqua.Text = "Kết quả mảng :";
            // 
            // button_nhapmang
            // 
            button_nhapmang.Location = new Point(12, 54);
            button_nhapmang.Name = "button_nhapmang";
            button_nhapmang.Size = new Size(126, 29);
            button_nhapmang.TabIndex = 2;
            button_nhapmang.Text = "Nhập mảng :";
            button_nhapmang.UseVisualStyleBackColor = true;
            button_nhapmang.Click += button_nhapmang_Click;
            // 
            // button_reset
            // 
            button_reset.Location = new Point(445, 54);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(94, 29);
            button_reset.TabIndex = 3;
            button_reset.Text = "Reset";
            button_reset.UseVisualStyleBackColor = true;
            button_reset.Click += button_reset_Click;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(445, 106);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(94, 29);
            button_thoat.TabIndex = 4;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += btnThoat_Click;
            // 
            // Inputmang
            // 
            Inputmang.Location = new Point(167, 56);
            Inputmang.Name = "Inputmang";
            Inputmang.Size = new Size(270, 27);
            Inputmang.TabIndex = 5;
            // 
            // Outputmang
            // 
            Outputmang.Location = new Point(167, 106);
            Outputmang.Name = "Outputmang";
            Outputmang.ReadOnly = true;
            Outputmang.Size = new Size(270, 27);
            Outputmang.TabIndex = 6;
            // 
            // button_thuchien
            // 
            button_thuchien.Location = new Point(21, 141);
            button_thuchien.Name = "button_thuchien";
            button_thuchien.Size = new Size(117, 59);
            button_thuchien.TabIndex = 7;
            button_thuchien.Text = "Thực Hiện";
            button_thuchien.UseVisualStyleBackColor = true;
            button_thuchien.Click += button_thuchien_Click;
            // 
            // button_tong
            // 
            button_tong.Location = new Point(481, 369);
            button_tong.Name = "button_tong";
            button_tong.Size = new Size(58, 110);
            button_tong.TabIndex = 8;
            button_tong.Text = "Tổng";
            button_tong.UseVisualStyleBackColor = true;
            button_tong.Click += button_tong_Click;
            // 
            // Tsapxep
            // 
            Tsapxep.AutoSize = true;
            Tsapxep.Location = new Point(175, 141);
            Tsapxep.Name = "Tsapxep";
            Tsapxep.Size = new Size(62, 20);
            Tsapxep.TabIndex = 9;
            Tsapxep.Text = "Sắp xếp";
            // 
            // radioButton_tang
            // 
            radioButton_tang.AutoSize = true;
            radioButton_tang.Location = new Point(196, 176);
            radioButton_tang.Name = "radioButton_tang";
            radioButton_tang.Size = new Size(119, 24);
            radioButton_tang.TabIndex = 10;
            radioButton_tang.TabStop = true;
            radioButton_tang.Text = "Sắp xếp Tăng";
            radioButton_tang.UseVisualStyleBackColor = true;
            // 
            // radioButton_giam
            // 
            radioButton_giam.AutoSize = true;
            radioButton_giam.Location = new Point(367, 176);
            radioButton_giam.Name = "radioButton_giam";
            radioButton_giam.Size = new Size(122, 24);
            radioButton_giam.TabIndex = 11;
            radioButton_giam.TabStop = true;
            radioButton_giam.Text = "Sắp xếp Giảm";
            radioButton_giam.UseVisualStyleBackColor = true;
            // 
            // Ttimkiem
            // 
            Ttimkiem.AutoSize = true;
            Ttimkiem.Location = new Point(21, 213);
            Ttimkiem.Name = "Ttimkiem";
            Ttimkiem.Size = new Size(72, 20);
            Ttimkiem.TabIndex = 12;
            Ttimkiem.Text = "Tìm Kiếm";
            // 
            // radioButton_giatritim
            // 
            radioButton_giatritim.AutoSize = true;
            radioButton_giatritim.Location = new Point(21, 236);
            radioButton_giatritim.Name = "radioButton_giatritim";
            radioButton_giatritim.Size = new Size(151, 24);
            radioButton_giatritim.TabIndex = 13;
            radioButton_giatritim.TabStop = true;
            radioButton_giatritim.Text = "Tìm giá trị cần tìm";
            radioButton_giatritim.UseVisualStyleBackColor = true;
            // 
            // radioButton_vitritim
            // 
            radioButton_vitritim.AutoSize = true;
            radioButton_vitritim.Location = new Point(21, 266);
            radioButton_vitritim.Name = "radioButton_vitritim";
            radioButton_vitritim.Size = new Size(141, 24);
            radioButton_vitritim.TabIndex = 14;
            radioButton_vitritim.TabStop = true;
            radioButton_vitritim.Text = "Tìm vị trí cần tìm";
            radioButton_vitritim.UseVisualStyleBackColor = true;
            // 
            // Inputgiatritim
            // 
            Inputgiatritim.Location = new Point(198, 233);
            Inputgiatritim.Name = "Inputgiatritim";
            Inputgiatritim.Size = new Size(35, 27);
            Inputgiatritim.TabIndex = 15;
            // 
            // Inputvitritim
            // 
            Inputvitritim.Location = new Point(198, 263);
            Inputvitritim.Name = "Inputvitritim";
            Inputvitritim.Size = new Size(35, 27);
            Inputvitritim.TabIndex = 16;
            // 
            // Tsotimduoc
            // 
            Tsotimduoc.AutoSize = true;
            Tsotimduoc.Location = new Point(44, 306);
            Tsotimduoc.Name = "Tsotimduoc";
            Tsotimduoc.Size = new Size(113, 20);
            Tsotimduoc.TabIndex = 17;
            Tsotimduoc.Text = "Số tìm được là :";
            // 
            // Outputtim
            // 
            Outputtim.Location = new Point(198, 299);
            Outputtim.Name = "Outputtim";
            Outputtim.ReadOnly = true;
            Outputtim.Size = new Size(35, 27);
            Outputtim.TabIndex = 18;
            // 
            // Txoa
            // 
            Txoa.AutoSize = true;
            Txoa.Location = new Point(306, 213);
            Txoa.Name = "Txoa";
            Txoa.Size = new Size(35, 20);
            Txoa.TabIndex = 19;
            Txoa.Text = "Xóa";
            // 
            // radioButton_giatrixoa
            // 
            radioButton_giatrixoa.AutoSize = true;
            radioButton_giatrixoa.Location = new Point(306, 236);
            radioButton_giatrixoa.Name = "radioButton_giatrixoa";
            radioButton_giatrixoa.Size = new Size(153, 24);
            radioButton_giatrixoa.TabIndex = 20;
            radioButton_giatrixoa.TabStop = true;
            radioButton_giatrixoa.Text = "Tìm giá trị cần xóa";
            radioButton_giatrixoa.UseVisualStyleBackColor = true;
            radioButton_giatrixoa.Click += radioButton_giatrixoa_Click;
            // 
            // radioButton_vitrixoa
            // 
            radioButton_vitrixoa.AutoSize = true;
            radioButton_vitrixoa.Location = new Point(306, 266);
            radioButton_vitrixoa.Name = "radioButton_vitrixoa";
            radioButton_vitrixoa.Size = new Size(143, 24);
            radioButton_vitrixoa.TabIndex = 21;
            radioButton_vitrixoa.TabStop = true;
            radioButton_vitrixoa.Text = "Tìm vị trí cần xóa";
            radioButton_vitrixoa.UseVisualStyleBackColor = true;
            // 
            // Inputgiatrixoa
            // 
            Inputgiatrixoa.Location = new Point(504, 233);
            Inputgiatrixoa.Name = "Inputgiatrixoa";
            Inputgiatrixoa.Size = new Size(35, 27);
            Inputgiatrixoa.TabIndex = 22;
            // 
            // Inputvitrixoa
            // 
            Inputvitrixoa.Location = new Point(504, 263);
            Inputvitrixoa.Name = "Inputvitrixoa";
            Inputvitrixoa.Size = new Size(35, 27);
            Inputvitrixoa.TabIndex = 23;
            // 
            // Tsapxeptang
            // 
            Tsapxeptang.AutoSize = true;
            Tsapxeptang.ForeColor = Color.Red;
            Tsapxeptang.Location = new Point(343, 299);
            Tsapxeptang.Name = "Tsapxeptang";
            Tsapxeptang.Size = new Size(123, 20);
            Tsapxeptang.TabIndex = 24;
            Tsapxeptang.Text = "Cần sắp xếp tăng";
            // 
            // Tthem
            // 
            Tthem.AutoSize = true;
            Tthem.Location = new Point(21, 355);
            Tthem.Name = "Tthem";
            Tthem.Size = new Size(46, 20);
            Tthem.TabIndex = 25;
            Tthem.Text = "Thêm";
            // 
            // radioButton_giatrithem
            // 
            radioButton_giatrithem.AutoSize = true;
            radioButton_giatrithem.Location = new Point(21, 382);
            radioButton_giatrithem.Name = "radioButton_giatrithem";
            radioButton_giatrithem.Size = new Size(163, 24);
            radioButton_giatrithem.TabIndex = 26;
            radioButton_giatrithem.TabStop = true;
            radioButton_giatrithem.Text = "Tìm giá trị cần thêm";
            radioButton_giatrithem.UseVisualStyleBackColor = true;
            radioButton_giatrithem.Click += radioButton_giatrithem_Click;
            // 
            // Inputgiatrithem
            // 
            Inputgiatrithem.Location = new Point(196, 379);
            Inputgiatrithem.Name = "Inputgiatrithem";
            Inputgiatrithem.Size = new Size(35, 27);
            Inputgiatrithem.TabIndex = 27;
            // 
            // Tcanthem
            // 
            Tcanthem.AutoSize = true;
            Tcanthem.Location = new Point(44, 426);
            Tcanthem.Name = "Tcanthem";
            Tcanthem.Size = new Size(134, 20);
            Tcanthem.TabIndex = 28;
            Tcanthem.Text = "Tại vị trí cần thêm :";
            // 
            // Inputvitrithem
            // 
            Inputvitrithem.Location = new Point(196, 419);
            Inputvitrithem.Name = "Inputvitrithem";
            Inputvitrithem.Size = new Size(35, 27);
            Inputvitrithem.TabIndex = 29;
            // 
            // Tsapxepthemtang
            // 
            Tsapxepthemtang.AutoSize = true;
            Tsapxepthemtang.ForeColor = Color.Red;
            Tsapxepthemtang.Location = new Point(53, 459);
            Tsapxepthemtang.Name = "Tsapxepthemtang";
            Tsapxepthemtang.Size = new Size(123, 20);
            Tsapxepthemtang.TabIndex = 30;
            Tsapxepthemtang.Text = "Cần sắp xếp tăng";
            // 
            // Ttong
            // 
            Ttong.AutoSize = true;
            Ttong.Location = new Point(306, 355);
            Ttong.Name = "Ttong";
            Ttong.Size = new Size(43, 20);
            Ttong.TabIndex = 31;
            Ttong.Text = "Tổng";
            // 
            // Ttongmang
            // 
            Ttongmang.AutoSize = true;
            Ttongmang.Location = new Point(306, 384);
            Ttongmang.Name = "Ttongmang";
            Ttongmang.Size = new Size(85, 20);
            Ttongmang.TabIndex = 32;
            Ttongmang.Text = "Tổng mảng";
            // 
            // Ttongchan
            // 
            Ttongchan.AutoSize = true;
            Ttongchan.Location = new Point(306, 426);
            Ttongchan.Name = "Ttongchan";
            Ttongchan.Size = new Size(78, 20);
            Ttongchan.TabIndex = 33;
            Ttongchan.Text = "Tổng chẵn";
            // 
            // Ttongle
            // 
            Ttongle.AutoSize = true;
            Ttongle.Location = new Point(306, 459);
            Ttongle.Name = "Ttongle";
            Ttongle.Size = new Size(59, 20);
            Ttongle.TabIndex = 34;
            Ttongle.Text = "Tổng lẻ";
            // 
            // Outputtongmang
            // 
            Outputtongmang.Location = new Point(425, 377);
            Outputtongmang.Name = "Outputtongmang";
            Outputtongmang.ReadOnly = true;
            Outputtongmang.Size = new Size(35, 27);
            Outputtongmang.TabIndex = 35;
            // 
            // Outputtongchan
            // 
            Outputtongchan.Location = new Point(425, 419);
            Outputtongchan.Name = "Outputtongchan";
            Outputtongchan.ReadOnly = true;
            Outputtongchan.Size = new Size(35, 27);
            Outputtongchan.TabIndex = 36;
            // 
            // Outputtongle
            // 
            Outputtongle.Location = new Point(425, 452);
            Outputtongle.Name = "Outputtongle";
            Outputtongle.ReadOnly = true;
            Outputtongle.Size = new Size(35, 27);
            Outputtongle.TabIndex = 37;
            // 
            // Tmaxmin
            // 
            Tmaxmin.AutoSize = true;
            Tmaxmin.Location = new Point(21, 507);
            Tmaxmin.Name = "Tmaxmin";
            Tmaxmin.Size = new Size(76, 20);
            Tmaxmin.TabIndex = 38;
            Tmaxmin.Text = "Max - Min";
            // 
            // Tgtln
            // 
            Tgtln.AutoSize = true;
            Tgtln.Location = new Point(21, 541);
            Tgtln.Name = "Tgtln";
            Tgtln.Size = new Size(107, 20);
            Tgtln.TabIndex = 39;
            Tgtln.Text = "Giá trị lớn nhất";
            // 
            // Tgtnn
            // 
            Tgtnn.AutoSize = true;
            Tgtnn.Location = new Point(21, 574);
            Tgtnn.Name = "Tgtnn";
            Tgtnn.Size = new Size(111, 20);
            Tgtnn.TabIndex = 40;
            Tgtnn.Text = "Giá trị nhỏ nhất";
            // 
            // Outputmax
            // 
            Outputmax.Location = new Point(134, 530);
            Outputmax.Name = "Outputmax";
            Outputmax.ReadOnly = true;
            Outputmax.Size = new Size(35, 27);
            Outputmax.TabIndex = 41;
            // 
            // Outputmin
            // 
            Outputmin.Location = new Point(134, 567);
            Outputmin.Name = "Outputmin";
            Outputmin.ReadOnly = true;
            Outputmin.Size = new Size(35, 27);
            Outputmin.TabIndex = 42;
            // 
            // button_tim
            // 
            button_tim.Location = new Point(175, 520);
            button_tim.Name = "button_tim";
            button_tim.Size = new Size(58, 88);
            button_tim.TabIndex = 43;
            button_tim.Text = "Tìm";
            button_tim.UseVisualStyleBackColor = true;
            button_tim.Click += button_tim_Click;
            // 
            // Tthaythe
            // 
            Tthaythe.AutoSize = true;
            Tthaythe.Location = new Point(306, 507);
            Tthaythe.Name = "Tthaythe";
            Tthaythe.Size = new Size(68, 20);
            Tthaythe.TabIndex = 44;
            Tthaythe.Text = "Thay Thế";
            // 
            // radioButton_giatricanthay
            // 
            radioButton_giatricanthay.AutoSize = true;
            radioButton_giatricanthay.Location = new Point(306, 533);
            radioButton_giatricanthay.Name = "radioButton_giatricanthay";
            radioButton_giatricanthay.Size = new Size(154, 24);
            radioButton_giatricanthay.TabIndex = 45;
            radioButton_giatricanthay.TabStop = true;
            radioButton_giatricanthay.Text = "Giá trị cần thay thế";
            radioButton_giatricanthay.UseVisualStyleBackColor = true;
            radioButton_giatricanthay.Click += radioButton_giatrithay_Click;
            // 
            // radioButton_vitrithaythe
            // 
            radioButton_vitrithaythe.AutoSize = true;
            radioButton_vitrithaythe.Location = new Point(306, 560);
            radioButton_vitrithaythe.Name = "radioButton_vitrithaythe";
            radioButton_vitrithaythe.Size = new Size(145, 24);
            radioButton_vitrithaythe.TabIndex = 46;
            radioButton_vitrithaythe.TabStop = true;
            radioButton_vitrithaythe.Text = "Vị trí cần thay thế";
            radioButton_vitrithaythe.UseVisualStyleBackColor = true;
            // 
            // Tsothaythe
            // 
            Tsothaythe.AutoSize = true;
            Tsothaythe.Location = new Point(343, 588);
            Tsothaythe.Name = "Tsothaythe";
            Tsothaythe.Size = new Size(106, 20);
            Tsothaythe.TabIndex = 47;
            Tsothaythe.Text = "Số thay thế là :";
            // 
            // Inputgiatrithay
            // 
            Inputgiatrithay.Location = new Point(504, 522);
            Inputgiatrithay.Name = "Inputgiatrithay";
            Inputgiatrithay.Size = new Size(35, 27);
            Inputgiatrithay.TabIndex = 48;
            // 
            // Inputvitrithay
            // 
            Inputvitrithay.Location = new Point(504, 555);
            Inputvitrithay.Name = "Inputvitrithay";
            Inputvitrithay.Size = new Size(35, 27);
            Inputvitrithay.TabIndex = 49;
            // 
            // Inputsothaythe
            // 
            Inputsothaythe.Location = new Point(504, 585);
            Inputsothaythe.Name = "Inputsothaythe";
            Inputsothaythe.Size = new Size(35, 27);
            Inputsothaythe.TabIndex = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 620);
            Controls.Add(Inputsothaythe);
            Controls.Add(Inputvitrithay);
            Controls.Add(Inputgiatrithay);
            Controls.Add(Tsothaythe);
            Controls.Add(radioButton_vitrithaythe);
            Controls.Add(radioButton_giatricanthay);
            Controls.Add(Tthaythe);
            Controls.Add(button_tim);
            Controls.Add(Outputmin);
            Controls.Add(Outputmax);
            Controls.Add(Tgtnn);
            Controls.Add(Tgtln);
            Controls.Add(Tmaxmin);
            Controls.Add(Outputtongle);
            Controls.Add(Outputtongchan);
            Controls.Add(Outputtongmang);
            Controls.Add(Ttongle);
            Controls.Add(Ttongchan);
            Controls.Add(Ttongmang);
            Controls.Add(Ttong);
            Controls.Add(Tsapxepthemtang);
            Controls.Add(Inputvitrithem);
            Controls.Add(Tcanthem);
            Controls.Add(Inputgiatrithem);
            Controls.Add(radioButton_giatrithem);
            Controls.Add(Tthem);
            Controls.Add(Tsapxeptang);
            Controls.Add(Inputvitrixoa);
            Controls.Add(Inputgiatrixoa);
            Controls.Add(radioButton_vitrixoa);
            Controls.Add(radioButton_giatrixoa);
            Controls.Add(Txoa);
            Controls.Add(Outputtim);
            Controls.Add(Tsotimduoc);
            Controls.Add(Inputvitritim);
            Controls.Add(Inputgiatritim);
            Controls.Add(radioButton_vitritim);
            Controls.Add(radioButton_giatritim);
            Controls.Add(Ttimkiem);
            Controls.Add(radioButton_giam);
            Controls.Add(radioButton_tang);
            Controls.Add(Tsapxep);
            Controls.Add(button_tong);
            Controls.Add(button_thuchien);
            Controls.Add(Outputmang);
            Controls.Add(Inputmang);
            Controls.Add(button_thoat);
            Controls.Add(button_reset);
            Controls.Add(button_nhapmang);
            Controls.Add(Tketqua);
            Controls.Add(lbltitle);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label Tketqua;
        private Button button_nhapmang;
        private Button button_reset;
        private Button button_thoat;
        private TextBox Inputmang;
        private TextBox Outputmang;
        private Button button_thuchien;
        private Button button_tong;
        private Label Tsapxep;
        private RadioButton radioButton_tang;
        private RadioButton radioButton_giam;
        private Label Ttimkiem;
        private RadioButton radioButton_giatritim;
        private RadioButton radioButton_vitritim;
        private TextBox Inputgiatritim;
        private TextBox Inputvitritim;
        private Label Tsotimduoc;
        private TextBox Outputtim;
        private Label Txoa;
        private RadioButton radioButton_giatrixoa;
        private RadioButton radioButton_vitrixoa;
        private TextBox Inputgiatrixoa;
        private TextBox Inputvitrixoa;
        private Label Tsapxeptang;
        private Label Tthem;
        private RadioButton radioButton_giatrithem;
        private TextBox Inputgiatrithem;
        private Label Tcanthem;
        private TextBox Inputvitrithem;
        private Label Tsapxepthemtang;
        private Label Ttong;
        private Label Ttongmang;
        private Label Ttongchan;
        private Label Ttongle;
        private TextBox Outputtongmang;
        private TextBox Outputtongchan;
        private TextBox Outputtongle;
        private Label Tmaxmin;
        private Label Tgtln;
        private Label Tgtnn;
        private TextBox Outputmax;
        private TextBox Outputmin;
        private Button button_tim;
        private Label Tthaythe;
        private RadioButton radioButton_giatricanthay;
        private RadioButton radioButton_vitrithaythe;
        private Label Tsothaythe;
        private TextBox Inputgiatrithay;
        private TextBox Inputvitrithay;
        private TextBox Inputsothaythe;
    }
}
