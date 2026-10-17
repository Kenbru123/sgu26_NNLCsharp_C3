namespace _6bbaitaptailop2
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
            Tsinhvien = new Label();
            Tmonhoc = new Label();
            Tdiem = new Label();
            comboBox_sv = new ComboBox();
            comboBox_mh = new ComboBox();
            Inputdiem = new TextBox();
            button_them = new Button();
            button_xoa = new Button();
            button_sua = new Button();
            SuspendLayout();
            // 
            // Tsinhvien
            // 
            Tsinhvien.AutoSize = true;
            Tsinhvien.Location = new Point(12, 37);
            Tsinhvien.Name = "Tsinhvien";
            Tsinhvien.Size = new Size(68, 20);
            Tsinhvien.TabIndex = 0;
            Tsinhvien.Text = "Sinh viên";
            // 
            // Tmonhoc
            // 
            Tmonhoc.AutoSize = true;
            Tmonhoc.Location = new Point(12, 70);
            Tmonhoc.Name = "Tmonhoc";
            Tmonhoc.Size = new Size(67, 20);
            Tmonhoc.TabIndex = 1;
            Tmonhoc.Text = "Môn học";
            // 
            // Tdiem
            // 
            Tdiem.AutoSize = true;
            Tdiem.Location = new Point(12, 105);
            Tdiem.Name = "Tdiem";
            Tdiem.Size = new Size(45, 20);
            Tdiem.TabIndex = 2;
            Tdiem.Text = "Điểm";
            // 
            // comboBox_sv
            // 
            comboBox_sv.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_sv.FormattingEnabled = true;
            comboBox_sv.Location = new Point(92, 29);
            comboBox_sv.Name = "comboBox_sv";
            comboBox_sv.Size = new Size(245, 28);
            comboBox_sv.TabIndex = 3;
            // 
            // comboBox_mh
            // 
            comboBox_mh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_mh.FormattingEnabled = true;
            comboBox_mh.Location = new Point(92, 62);
            comboBox_mh.Name = "comboBox_mh";
            comboBox_mh.Size = new Size(245, 28);
            comboBox_mh.TabIndex = 4;
            // 
            // Inputdiem
            // 
            Inputdiem.Location = new Point(92, 96);
            Inputdiem.Name = "Inputdiem";
            Inputdiem.Size = new Size(245, 27);
            Inputdiem.TabIndex = 5;
            // 
            // button_them
            // 
            button_them.Location = new Point(27, 155);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 29);
            button_them.TabIndex = 6;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(127, 155);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 29);
            button_xoa.TabIndex = 7;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_sua
            // 
            button_sua.Location = new Point(227, 155);
            button_sua.Name = "button_sua";
            button_sua.Size = new Size(94, 29);
            button_sua.TabIndex = 8;
            button_sua.Text = "Sửa";
            button_sua.UseVisualStyleBackColor = true;
            button_sua.Click += button_sua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 211);
            Controls.Add(button_sua);
            Controls.Add(button_xoa);
            Controls.Add(button_them);
            Controls.Add(Inputdiem);
            Controls.Add(comboBox_mh);
            Controls.Add(comboBox_sv);
            Controls.Add(Tdiem);
            Controls.Add(Tmonhoc);
            Controls.Add(Tsinhvien);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tsinhvien;
        private Label Tmonhoc;
        private Label Tdiem;
        private ComboBox comboBox_sv;
        private ComboBox comboBox_mh;
        private TextBox Inputdiem;
        private Button button_them;
        private Button button_xoa;
        private Button button_sua;
    }
}
