namespace _5dbaitapvenhabai2
{
    public partial class FormBai2TaiLop : Form
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
            Ttitle = new Label();
            Ttaikhoan = new Label();
            Tkhachhang = new Label();
            Tdiachi = new Label();
            Tsotien = new Label();
            Inputtaikhoan = new TextBox();
            Inputten = new TextBox();
            Inputdiachi = new TextBox();
            Inputsotk = new TextBox();
            button_them = new Button();
            button_luu = new Button();
            button_xoa = new Button();
            button_thoat = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            Ttongtien = new Label();
            Outputtongtien = new TextBox();
            SuspendLayout();
            // 
            // Ttitle
            // 
            Ttitle.AutoSize = true;
            Ttitle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ttitle.ForeColor = Color.Blue;
            Ttitle.Location = new Point(50, 9);
            Ttitle.Name = "Ttitle";
            Ttitle.Size = new Size(474, 32);
            Ttitle.TabIndex = 0;
            Ttitle.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // Ttaikhoan
            // 
            Ttaikhoan.AutoSize = true;
            Ttaikhoan.Location = new Point(145, 69);
            Ttaikhoan.Name = "Ttaikhoan";
            Ttaikhoan.Size = new Size(91, 20);
            Ttaikhoan.TabIndex = 1;
            Ttaikhoan.Text = "Số tài khoản";
            // 
            // Tkhachhang
            // 
            Tkhachhang.AutoSize = true;
            Tkhachhang.Location = new Point(125, 109);
            Tkhachhang.Name = "Tkhachhang";
            Tkhachhang.Size = new Size(111, 20);
            Tkhachhang.TabIndex = 2;
            Tkhachhang.Text = "Tên khách hàng";
            // 
            // Tdiachi
            // 
            Tdiachi.AutoSize = true;
            Tdiachi.Location = new Point(102, 149);
            Tdiachi.Name = "Tdiachi";
            Tdiachi.Size = new Size(134, 20);
            Tdiachi.TabIndex = 3;
            Tdiachi.Text = "Địa chỉ khách hàng";
            // 
            // Tsotien
            // 
            Tsotien.AutoSize = true;
            Tsotien.Location = new Point(76, 198);
            Tsotien.Name = "Tsotien";
            Tsotien.Size = new Size(160, 20);
            Tsotien.TabIndex = 4;
            Tsotien.Text = "Số tiền trong tài khoản";
            // 
            // Inputtaikhoan
            // 
            Inputtaikhoan.Location = new Point(255, 62);
            Inputtaikhoan.Name = "Inputtaikhoan";
            Inputtaikhoan.Size = new Size(331, 27);
            Inputtaikhoan.TabIndex = 5;
            // 
            // Inputten
            // 
            Inputten.Location = new Point(255, 102);
            Inputten.Name = "Inputten";
            Inputten.Size = new Size(331, 27);
            Inputten.TabIndex = 6;
            // 
            // Inputdiachi
            // 
            Inputdiachi.Location = new Point(255, 142);
            Inputdiachi.Name = "Inputdiachi";
            Inputdiachi.Size = new Size(331, 27);
            Inputdiachi.TabIndex = 7;
            // 
            // Inputsotk
            // 
            Inputsotk.Location = new Point(255, 191);
            Inputsotk.Name = "Inputsotk";
            Inputsotk.Size = new Size(331, 27);
            Inputsotk.TabIndex = 8;
            // 
            // button_them
            // 
            button_them.Location = new Point(255, 245);
            button_them.Name = "button_them";
            button_them.Size = new Size(66, 29);
            button_them.TabIndex = 9;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_luu
            // 
            button_luu.Location = new Point(337, 245);
            button_luu.Name = "button_luu";
            button_luu.Size = new Size(70, 29);
            button_luu.TabIndex = 10;
            button_luu.Text = "Lưu";
            button_luu.UseVisualStyleBackColor = true;
            button_luu.Click += button_luu_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(426, 245);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(74, 29);
            button_xoa.TabIndex = 11;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(516, 245);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(70, 29);
            button_thoat.TabIndex = 12;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 280);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(574, 135);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số tài khoản";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên khách hàng";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Địa chỉ";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số tiền";
            columnHeader5.Width = 120;
            // 
            // Ttongtien
            // 
            Ttongtien.AutoSize = true;
            Ttongtien.Location = new Point(337, 425);
            Ttongtien.Name = "Ttongtien";
            Ttongtien.Size = new Size(72, 20);
            Ttongtien.TabIndex = 14;
            Ttongtien.Text = "Tổng tiền";
            // 
            // Outputtongtien
            // 
            Outputtongtien.Location = new Point(439, 418);
            Outputtongtien.Name = "Outputtongtien";
            Outputtongtien.ReadOnly = true;
            Outputtongtien.Size = new Size(147, 27);
            Outputtongtien.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 455);
            Controls.Add(Outputtongtien);
            Controls.Add(Ttongtien);
            Controls.Add(listView1);
            Controls.Add(button_thoat);
            Controls.Add(button_xoa);
            Controls.Add(button_luu);
            Controls.Add(button_them);
            Controls.Add(Inputsotk);
            Controls.Add(Inputdiachi);
            Controls.Add(Inputten);
            Controls.Add(Inputtaikhoan);
            Controls.Add(Tsotien);
            Controls.Add(Tdiachi);
            Controls.Add(Tkhachhang);
            Controls.Add(Ttaikhoan);
            Controls.Add(Ttitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Ttitle;
        private Label Ttaikhoan;
        private Label Tkhachhang;
        private Label Tdiachi;
        private Label Tsotien;
        private TextBox Inputtaikhoan;
        private TextBox Inputten;
        private TextBox Inputdiachi;
        private TextBox Inputsotk;
        private Button button_them;
        private Button button_luu;
        private Button button_xoa;
        private Button button_thoat;
        private ListView listView1;
        private Label Ttongtien;
        private TextBox Outputtongtien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
