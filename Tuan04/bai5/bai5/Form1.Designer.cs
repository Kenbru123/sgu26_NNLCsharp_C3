namespace bai5
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
            Tnhap = new Label();
            Inputnhap = new TextBox();
            button_thuchien = new Button();
            button_xoa = new Button();
            button_thoat = new Button();
            Outputketqua = new TextBox();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.Red;
            lbltitle.Location = new Point(39, 9);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(247, 38);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Đọc Số Thành Chữ";
            // 
            // Tnhap
            // 
            Tnhap.AutoSize = true;
            Tnhap.Location = new Point(12, 68);
            Tnhap.Name = "Tnhap";
            Tnhap.Size = new Size(196, 20);
            Tnhap.TabIndex = 1;
            Tnhap.Text = "Nhập dãy số : (từ 1 đến 999)";
            // 
            // Inputnhap
            // 
            Inputnhap.Location = new Point(214, 65);
            Inputnhap.Name = "Inputnhap";
            Inputnhap.Size = new Size(91, 27);
            Inputnhap.TabIndex = 2;
            Inputnhap.KeyPress += Inputnhap_KeyPress;
            // 
            // button_thuchien
            // 
            button_thuchien.Location = new Point(12, 117);
            button_thuchien.Name = "button_thuchien";
            button_thuchien.Size = new Size(94, 29);
            button_thuchien.TabIndex = 3;
            button_thuchien.Text = "Thực hiện";
            button_thuchien.UseVisualStyleBackColor = true;
            button_thuchien.Click += button_thuchien_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(112, 117);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 29);
            button_xoa.TabIndex = 4;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(211, 117);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(94, 29);
            button_thoat.TabIndex = 5;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // Outputketqua
            // 
            Outputketqua.Location = new Point(12, 170);
            Outputketqua.Name = "Outputketqua";
            Outputketqua.ReadOnly = true;
            Outputketqua.Size = new Size(293, 27);
            Outputketqua.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 220);
            Controls.Add(Outputketqua);
            Controls.Add(button_thoat);
            Controls.Add(button_xoa);
            Controls.Add(button_thuchien);
            Controls.Add(Inputnhap);
            Controls.Add(Tnhap);
            Controls.Add(lbltitle);
            Name = "Form1";
            Text = "Form1";
            FormClosing += bai5_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label Tnhap;
        private TextBox Inputnhap;
        private Button button_thuchien;
        private Button button_xoa;
        private Button button_thoat;
        private TextBox Outputketqua;
    }
}
