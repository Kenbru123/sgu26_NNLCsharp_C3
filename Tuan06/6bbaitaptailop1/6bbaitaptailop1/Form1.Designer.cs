namespace _6bbaitaptailop1
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
            Tlop = new Label();
            Tmasv = new Label();
            Thoten = new Label();
            Tngaysinh = new Label();
            Inputmasv = new TextBox();
            Inputhoten = new TextBox();
            button_them = new Button();
            button_xoa = new Button();
            button_sua = new Button();
            comboBox_Lop = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            SuspendLayout();
            // 
            // Tlop
            // 
            Tlop.AutoSize = true;
            Tlop.Location = new Point(12, 42);
            Tlop.Name = "Tlop";
            Tlop.Size = new Size(34, 20);
            Tlop.TabIndex = 0;
            Tlop.Text = "Lớp";
            // 
            // Tmasv
            // 
            Tmasv.AutoSize = true;
            Tmasv.Location = new Point(12, 78);
            Tmasv.Name = "Tmasv";
            Tmasv.Size = new Size(47, 20);
            Tmasv.TabIndex = 1;
            Tmasv.Text = "Mã sv";
            // 
            // Thoten
            // 
            Thoten.AutoSize = true;
            Thoten.Location = new Point(12, 118);
            Thoten.Name = "Thoten";
            Thoten.Size = new Size(54, 20);
            Thoten.TabIndex = 2;
            Thoten.Text = "Họ tên";
            // 
            // Tngaysinh
            // 
            Tngaysinh.AutoSize = true;
            Tngaysinh.Location = new Point(12, 152);
            Tngaysinh.Name = "Tngaysinh";
            Tngaysinh.Size = new Size(74, 20);
            Tngaysinh.TabIndex = 3;
            Tngaysinh.Text = "Ngày sinh";
            // 
            // Inputmasv
            // 
            Inputmasv.Location = new Point(92, 71);
            Inputmasv.Name = "Inputmasv";
            Inputmasv.Size = new Size(247, 27);
            Inputmasv.TabIndex = 4;
            // 
            // Inputhoten
            // 
            Inputhoten.Location = new Point(92, 111);
            Inputhoten.Name = "Inputhoten";
            Inputhoten.Size = new Size(247, 27);
            Inputhoten.TabIndex = 5;
            // 
            // button_them
            // 
            button_them.Location = new Point(12, 218);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 29);
            button_them.TabIndex = 8;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(129, 218);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 29);
            button_xoa.TabIndex = 9;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_sua
            // 
            button_sua.Location = new Point(245, 218);
            button_sua.Name = "button_sua";
            button_sua.Size = new Size(94, 29);
            button_sua.TabIndex = 10;
            button_sua.Text = "Sửa";
            button_sua.UseVisualStyleBackColor = true;
            button_sua.Click += button_sua_Click;
            // 
            // comboBox_Lop
            // 
            comboBox_Lop.FormattingEnabled = true;
            comboBox_Lop.Location = new Point(92, 34);
            comboBox_Lop.Name = "comboBox_Lop";
            comboBox_Lop.Size = new Size(247, 28);
            comboBox_Lop.TabIndex = 11;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(92, 147);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(247, 27);
            dtpNgaySinh.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 272);
            Controls.Add(dtpNgaySinh);
            Controls.Add(comboBox_Lop);
            Controls.Add(button_sua);
            Controls.Add(button_xoa);
            Controls.Add(button_them);
            Controls.Add(Inputhoten);
            Controls.Add(Inputmasv);
            Controls.Add(Tngaysinh);
            Controls.Add(Thoten);
            Controls.Add(Tmasv);
            Controls.Add(Tlop);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tlop;
        private Label Tmasv;
        private Label Thoten;
        private Label Tngaysinh;
        private TextBox Inputmasv;
        private TextBox Inputhoten;
        private Button button_them;
        private Button button_xoa;
        private Button button_sua;
        private ComboBox comboBox_Lop;
        private DateTimePicker dtpNgaySinh;
    }
}
