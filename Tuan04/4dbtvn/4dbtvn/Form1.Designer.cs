namespace _4dbtvn
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
            Thoten = new Label();
            Tdiachi = new Label();
            Tsongay = new Label();
            Tloaiphong = new Label();
            Ttiennghi = new Label();
            Tdichvu = new Label();
            Tthanhtien = new Label();
            Tthongtin = new Label();
            Tsoluot = new Label();
            Ttongtien = new Label();
            Inputhoten = new TextBox();
            Inputdiachi = new TextBox();
            Inputsongay = new TextBox();
            Outputthanhtien = new TextBox();
            Outputsoluot = new TextBox();
            Outputtongtien = new TextBox();
            button_thanhtoan = new Button();
            button_nhapmoi = new Button();
            button_tongket = new Button();
            button_thoat = new Button();
            radioButton_phongdon = new RadioButton();
            radioButton_phongdoi = new RadioButton();
            radioButton_phongba = new RadioButton();
            chkTivi = new CheckBox();
            chkInternet = new CheckBox();
            chkMaynuocnong = new CheckBox();
            chkAnsang = new CheckBox();
            chkKaraoke = new CheckBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.Orange;
            lbltitle.Location = new Point(88, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(586, 38);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
            // 
            // Thoten
            // 
            Thoten.AutoSize = true;
            Thoten.Location = new Point(12, 92);
            Thoten.Name = "Thoten";
            Thoten.Size = new Size(76, 20);
            Thoten.TabIndex = 1;
            Thoten.Text = "Họ và tên:";
            // 
            // Tdiachi
            // 
            Tdiachi.AutoSize = true;
            Tdiachi.Location = new Point(30, 138);
            Tdiachi.Name = "Tdiachi";
            Tdiachi.Size = new Size(58, 20);
            Tdiachi.TabIndex = 2;
            Tdiachi.Text = "Địa chỉ:";
            // 
            // Tsongay
            // 
            Tsongay.AutoSize = true;
            Tsongay.Location = new Point(12, 182);
            Tsongay.Name = "Tsongay";
            Tsongay.Size = new Size(78, 20);
            Tsongay.TabIndex = 3;
            Tsongay.Text = "Số ngày ở:";
            // 
            // Tloaiphong
            // 
            Tloaiphong.AutoSize = true;
            Tloaiphong.Location = new Point(12, 227);
            Tloaiphong.Name = "Tloaiphong";
            Tloaiphong.Size = new Size(84, 20);
            Tloaiphong.TabIndex = 4;
            Tloaiphong.Text = "Loại phòng";
            // 
            // Ttiennghi
            // 
            Ttiennghi.AutoSize = true;
            Ttiennghi.Location = new Point(135, 227);
            Ttiennghi.Name = "Ttiennghi";
            Ttiennghi.Size = new Size(70, 20);
            Ttiennghi.TabIndex = 5;
            Ttiennghi.Text = "Tiện nghi";
            // 
            // Tdichvu
            // 
            Tdichvu.AutoSize = true;
            Tdichvu.Location = new Point(269, 227);
            Tdichvu.Name = "Tdichvu";
            Tdichvu.Size = new Size(58, 20);
            Tdichvu.TabIndex = 6;
            Tdichvu.Text = "Dịch vụ";
            // 
            // Tthanhtien
            // 
            Tthanhtien.AutoSize = true;
            Tthanhtien.Location = new Point(456, 109);
            Tthanhtien.Name = "Tthanhtien";
            Tthanhtien.Size = new Size(81, 20);
            Tthanhtien.TabIndex = 7;
            Tthanhtien.Text = "Thành tiền:";
            // 
            // Tthongtin
            // 
            Tthongtin.AutoSize = true;
            Tthongtin.Location = new Point(456, 227);
            Tthongtin.Name = "Tthongtin";
            Tthongtin.Size = new Size(131, 20);
            Tthongtin.TabIndex = 8;
            Tthongtin.Text = "Thông tin tổng kết";
            // 
            // Tsoluot
            // 
            Tsoluot.AutoSize = true;
            Tsoluot.Location = new Point(456, 255);
            Tsoluot.Name = "Tsoluot";
            Tsoluot.Size = new Size(103, 20);
            Tsoluot.TabIndex = 9;
            Tsoluot.Text = "Số lượt người:";
            // 
            // Ttongtien
            // 
            Ttongtien.AutoSize = true;
            Ttongtien.Location = new Point(456, 286);
            Ttongtien.Name = "Ttongtien";
            Ttongtien.Size = new Size(94, 20);
            Ttongtien.TabIndex = 10;
            Ttongtien.Text = "Tổng số tiền:";
            // 
            // Inputhoten
            // 
            Inputhoten.Location = new Point(113, 85);
            Inputhoten.Name = "Inputhoten";
            Inputhoten.Size = new Size(288, 27);
            Inputhoten.TabIndex = 11;
            Inputhoten.TextChanged += txtDuLieu_TextChanged;
            // 
            // Inputdiachi
            // 
            Inputdiachi.Location = new Point(113, 131);
            Inputdiachi.Name = "Inputdiachi";
            Inputdiachi.Size = new Size(288, 27);
            Inputdiachi.TabIndex = 12;
            Inputdiachi.TextChanged += txtDuLieu_TextChanged;
            // 
            // Inputsongay
            // 
            Inputsongay.Location = new Point(113, 175);
            Inputsongay.Name = "Inputsongay";
            Inputsongay.Size = new Size(123, 27);
            Inputsongay.TabIndex = 13;
            Inputsongay.TextChanged += txtDuLieu_TextChanged;
            Inputsongay.KeyPress += Inputsongay_KeyPress;
            // 
            // Outputthanhtien
            // 
            Outputthanhtien.Location = new Point(549, 102);
            Outputthanhtien.Name = "Outputthanhtien";
            Outputthanhtien.ReadOnly = true;
            Outputthanhtien.Size = new Size(192, 27);
            Outputthanhtien.TabIndex = 14;
            // 
            // Outputsoluot
            // 
            Outputsoluot.Location = new Point(565, 246);
            Outputsoluot.Name = "Outputsoluot";
            Outputsoluot.ReadOnly = true;
            Outputsoluot.Size = new Size(176, 27);
            Outputsoluot.TabIndex = 15;
            // 
            // Outputtongtien
            // 
            Outputtongtien.Location = new Point(565, 279);
            Outputtongtien.Name = "Outputtongtien";
            Outputtongtien.ReadOnly = true;
            Outputtongtien.Size = new Size(176, 27);
            Outputtongtien.TabIndex = 16;
            // 
            // button_thanhtoan
            // 
            button_thanhtoan.Location = new Point(456, 67);
            button_thanhtoan.Name = "button_thanhtoan";
            button_thanhtoan.Size = new Size(94, 29);
            button_thanhtoan.TabIndex = 17;
            button_thanhtoan.Text = "Thanh toán";
            button_thanhtoan.UseVisualStyleBackColor = true;
            button_thanhtoan.Click += button_thanhtoan_Click;
            // 
            // button_nhapmoi
            // 
            button_nhapmoi.Location = new Point(556, 67);
            button_nhapmoi.Name = "button_nhapmoi";
            button_nhapmoi.Size = new Size(94, 29);
            button_nhapmoi.TabIndex = 18;
            button_nhapmoi.Text = "Nhập mới";
            button_nhapmoi.UseVisualStyleBackColor = true;
            button_nhapmoi.Click += btnNhapMoi_Click;
            // 
            // button_tongket
            // 
            button_tongket.Location = new Point(456, 182);
            button_tongket.Name = "button_tongket";
            button_tongket.Size = new Size(94, 36);
            button_tongket.TabIndex = 19;
            button_tongket.Text = "Tổng Kết\r\n\r\n";
            button_tongket.UseVisualStyleBackColor = true;
            button_tongket.Click += button_tong_Click;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(456, 342);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(94, 29);
            button_thoat.TabIndex = 20;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // radioButton_phongdon
            // 
            radioButton_phongdon.AutoSize = true;
            radioButton_phongdon.Location = new Point(27, 250);
            radioButton_phongdon.Name = "radioButton_phongdon";
            radioButton_phongdon.Size = new Size(102, 24);
            radioButton_phongdon.TabIndex = 21;
            radioButton_phongdon.TabStop = true;
            radioButton_phongdon.Text = "Phòng đơn";
            radioButton_phongdon.UseVisualStyleBackColor = true;
            radioButton_phongdon.CheckedChanged += radioPhong_CheckedChanged;
            // 
            // radioButton_phongdoi
            // 
            radioButton_phongdoi.AutoSize = true;
            radioButton_phongdoi.Location = new Point(27, 280);
            radioButton_phongdoi.Name = "radioButton_phongdoi";
            radioButton_phongdoi.Size = new Size(98, 24);
            radioButton_phongdoi.TabIndex = 22;
            radioButton_phongdoi.TabStop = true;
            radioButton_phongdoi.Text = "Phòng đôi";
            radioButton_phongdoi.UseVisualStyleBackColor = true;
            radioButton_phongdoi.CheckedChanged += radioPhong_CheckedChanged;
            // 
            // radioButton_phongba
            // 
            radioButton_phongba.AutoSize = true;
            radioButton_phongba.Location = new Point(27, 310);
            radioButton_phongba.Name = "radioButton_phongba";
            radioButton_phongba.Size = new Size(93, 24);
            radioButton_phongba.TabIndex = 23;
            radioButton_phongba.TabStop = true;
            radioButton_phongba.Text = "Phòng ba";
            radioButton_phongba.UseVisualStyleBackColor = true;
            radioButton_phongba.CheckedChanged += radioPhong_CheckedChanged;
            // 
            // chkTivi
            // 
            chkTivi.AutoSize = true;
            chkTivi.Location = new Point(151, 251);
            chkTivi.Name = "chkTivi";
            chkTivi.Size = new Size(54, 24);
            chkTivi.TabIndex = 24;
            chkTivi.Text = "Tivi";
            chkTivi.UseVisualStyleBackColor = true;
            // 
            // chkInternet
            // 
            chkInternet.AutoSize = true;
            chkInternet.Location = new Point(151, 279);
            chkInternet.Name = "chkInternet";
            chkInternet.Size = new Size(82, 24);
            chkInternet.TabIndex = 25;
            chkInternet.Text = "Internet";
            chkInternet.UseVisualStyleBackColor = true;
            // 
            // chkMaynuocnong
            // 
            chkMaynuocnong.AutoSize = true;
            chkMaynuocnong.Location = new Point(151, 309);
            chkMaynuocnong.Name = "chkMaynuocnong";
            chkMaynuocnong.Size = new Size(134, 24);
            chkMaynuocnong.TabIndex = 26;
            chkMaynuocnong.Text = "Máy nước nóng";
            chkMaynuocnong.UseVisualStyleBackColor = true;
            // 
            // chkAnsang
            // 
            chkAnsang.AutoSize = true;
            chkAnsang.Location = new Point(293, 274);
            chkAnsang.Name = "chkAnsang";
            chkAnsang.Size = new Size(84, 24);
            chkAnsang.TabIndex = 27;
            chkAnsang.Text = "Ăn sáng";
            chkAnsang.UseVisualStyleBackColor = true;
            // 
            // chkKaraoke
            // 
            chkKaraoke.AutoSize = true;
            chkKaraoke.Location = new Point(293, 249);
            chkKaraoke.Name = "chkKaraoke";
            chkKaraoke.Size = new Size(85, 24);
            chkKaraoke.TabIndex = 28;
            chkKaraoke.Text = "Karaoke";
            chkKaraoke.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(422, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 371);
            panel1.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 425);
            Controls.Add(panel1);
            Controls.Add(chkKaraoke);
            Controls.Add(chkAnsang);
            Controls.Add(chkMaynuocnong);
            Controls.Add(chkInternet);
            Controls.Add(chkTivi);
            Controls.Add(radioButton_phongba);
            Controls.Add(radioButton_phongdoi);
            Controls.Add(radioButton_phongdon);
            Controls.Add(button_thoat);
            Controls.Add(button_tongket);
            Controls.Add(button_nhapmoi);
            Controls.Add(button_thanhtoan);
            Controls.Add(Outputtongtien);
            Controls.Add(Outputsoluot);
            Controls.Add(Outputthanhtien);
            Controls.Add(Inputsongay);
            Controls.Add(Inputdiachi);
            Controls.Add(Inputhoten);
            Controls.Add(Ttongtien);
            Controls.Add(Tsoluot);
            Controls.Add(Tthongtin);
            Controls.Add(Tthanhtien);
            Controls.Add(Tdichvu);
            Controls.Add(Ttiennghi);
            Controls.Add(Tloaiphong);
            Controls.Add(Tsongay);
            Controls.Add(Tdiachi);
            Controls.Add(Thoten);
            Controls.Add(lbltitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label Thoten;
        private Label Tdiachi;
        private Label Tsongay;
        private Label Tloaiphong;
        private Label Ttiennghi;
        private Label Tdichvu;
        private Label Tthanhtien;
        private Label Tthongtin;
        private Label Tsoluot;
        private Label Ttongtien;
        private TextBox Inputhoten;
        private TextBox Inputdiachi;
        private TextBox Inputsongay;
        private TextBox Outputthanhtien;
        private TextBox Outputsoluot;
        private TextBox Outputtongtien;
        private Button button_thanhtoan;
        private Button button_nhapmoi;
        private Button button_tongket;
        private Button button_thoat;
        private RadioButton radioButton_phongdon;
        private RadioButton radioButton_phongdoi;
        private RadioButton radioButton_phongba;
        private CheckBox chkTivi;
        private CheckBox chkInternet;
        private CheckBox chkMaynuocnong;
        private CheckBox chkAnsang;
        private CheckBox chkKaraoke;
        private Panel panel1;
    }
}
