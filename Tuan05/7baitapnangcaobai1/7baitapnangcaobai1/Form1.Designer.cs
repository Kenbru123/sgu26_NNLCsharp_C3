namespace _7baitapnangcaobai1
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
            Tmalop = new Label();
            Tmasv = new Label();
            Thoten = new Label();
            Tngaysinh = new Label();
            Inputmalop = new TextBox();
            Inputmasv = new TextBox();
            Inputhoten = new TextBox();
            Inputngaysinh = new TextBox();
            button_them = new Button();
            button_xoa = new Button();
            button_sua = new Button();
            SuspendLayout();
            // 
            // Tmalop
            // 
            Tmalop.AutoSize = true;
            Tmalop.Location = new Point(64, 54);
            Tmalop.Name = "Tmalop";
            Tmalop.Size = new Size(56, 20);
            Tmalop.TabIndex = 0;
            Tmalop.Text = "Mã lớp";
            // 
            // Tmasv
            // 
            Tmasv.AutoSize = true;
            Tmasv.Location = new Point(64, 98);
            Tmasv.Name = "Tmasv";
            Tmasv.Size = new Size(47, 20);
            Tmasv.TabIndex = 1;
            Tmasv.Text = "Mã sv";
            // 
            // Thoten
            // 
            Thoten.AutoSize = true;
            Thoten.Location = new Point(64, 141);
            Thoten.Name = "Thoten";
            Thoten.Size = new Size(54, 20);
            Thoten.TabIndex = 2;
            Thoten.Text = "Họ tên";
            // 
            // Tngaysinh
            // 
            Tngaysinh.AutoSize = true;
            Tngaysinh.Location = new Point(64, 183);
            Tngaysinh.Name = "Tngaysinh";
            Tngaysinh.Size = new Size(74, 20);
            Tngaysinh.TabIndex = 3;
            Tngaysinh.Text = "Ngày sinh";
            // 
            // Inputmalop
            // 
            Inputmalop.Location = new Point(142, 47);
            Inputmalop.Name = "Inputmalop";
            Inputmalop.Size = new Size(250, 27);
            Inputmalop.TabIndex = 4;
            // 
            // Inputmasv
            // 
            Inputmasv.Location = new Point(142, 91);
            Inputmasv.Name = "Inputmasv";
            Inputmasv.Size = new Size(250, 27);
            Inputmasv.TabIndex = 5;
            // 
            // Inputhoten
            // 
            Inputhoten.Location = new Point(142, 134);
            Inputhoten.Name = "Inputhoten";
            Inputhoten.Size = new Size(250, 27);
            Inputhoten.TabIndex = 6;
            // 
            // Inputngaysinh
            // 
            Inputngaysinh.Location = new Point(142, 176);
            Inputngaysinh.Name = "Inputngaysinh";
            Inputngaysinh.Size = new Size(250, 27);
            Inputngaysinh.TabIndex = 7;
            // 
            // button_them
            // 
            button_them.Location = new Point(77, 245);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 29);
            button_them.TabIndex = 8;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(186, 245);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 29);
            button_xoa.TabIndex = 9;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_sua
            // 
            button_sua.Location = new Point(298, 245);
            button_sua.Name = "button_sua";
            button_sua.Size = new Size(94, 29);
            button_sua.TabIndex = 10;
            button_sua.Text = "Sửa";
            button_sua.UseVisualStyleBackColor = true;
            button_sua.Click += button_sua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 302);
            Controls.Add(button_sua);
            Controls.Add(button_xoa);
            Controls.Add(button_them);
            Controls.Add(Inputngaysinh);
            Controls.Add(Inputhoten);
            Controls.Add(Inputmasv);
            Controls.Add(Inputmalop);
            Controls.Add(Tngaysinh);
            Controls.Add(Thoten);
            Controls.Add(Tmasv);
            Controls.Add(Tmalop);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tmalop;
        private Label Tmasv;
        private Label Thoten;
        private Label Tngaysinh;
        private TextBox Inputmalop;
        private TextBox Inputmasv;
        private TextBox Inputhoten;
        private TextBox Inputngaysinh;
        private Button button_them;
        private Button button_xoa;
        private Button button_sua;
    }
}
