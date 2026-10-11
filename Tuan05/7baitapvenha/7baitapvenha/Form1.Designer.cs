namespace _7baitapvenha
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
            Tmakhoa = new Label();
            Tmalop = new Label();
            Ttenlop = new Label();
            Inputmakhoa = new TextBox();
            Inputmalop = new TextBox();
            Inputtenlop = new TextBox();
            button_them = new Button();
            button_xoa = new Button();
            button_sua = new Button();
            SuspendLayout();
            // 
            // Tmakhoa
            // 
            Tmakhoa.AutoSize = true;
            Tmakhoa.Location = new Point(40, 47);
            Tmakhoa.Name = "Tmakhoa";
            Tmakhoa.Size = new Size(66, 20);
            Tmakhoa.TabIndex = 0;
            Tmakhoa.Text = "Mã khoa";
            // 
            // Tmalop
            // 
            Tmalop.AutoSize = true;
            Tmalop.Location = new Point(40, 89);
            Tmalop.Name = "Tmalop";
            Tmalop.Size = new Size(56, 20);
            Tmalop.TabIndex = 1;
            Tmalop.Text = "Mã lớp";
            // 
            // Ttenlop
            // 
            Ttenlop.AutoSize = true;
            Ttenlop.Location = new Point(40, 127);
            Ttenlop.Name = "Ttenlop";
            Ttenlop.Size = new Size(58, 20);
            Ttenlop.TabIndex = 2;
            Ttenlop.Text = "Tên lớp";
            // 
            // Inputmakhoa
            // 
            Inputmakhoa.Location = new Point(113, 40);
            Inputmakhoa.Name = "Inputmakhoa";
            Inputmakhoa.Size = new Size(233, 27);
            Inputmakhoa.TabIndex = 3;
            // 
            // Inputmalop
            // 
            Inputmalop.Location = new Point(113, 82);
            Inputmalop.Name = "Inputmalop";
            Inputmalop.Size = new Size(233, 27);
            Inputmalop.TabIndex = 4;
            // 
            // Inputtenlop
            // 
            Inputtenlop.Location = new Point(113, 120);
            Inputtenlop.Name = "Inputtenlop";
            Inputtenlop.Size = new Size(233, 27);
            Inputtenlop.TabIndex = 5;
            // 
            // button_them
            // 
            button_them.Location = new Point(52, 173);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 29);
            button_them.TabIndex = 6;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(152, 173);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 29);
            button_xoa.TabIndex = 7;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_sua
            // 
            button_sua.Location = new Point(252, 173);
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
            ClientSize = new Size(398, 221);
            Controls.Add(button_sua);
            Controls.Add(button_xoa);
            Controls.Add(button_them);
            Controls.Add(Inputtenlop);
            Controls.Add(Inputmalop);
            Controls.Add(Inputmakhoa);
            Controls.Add(Ttenlop);
            Controls.Add(Tmalop);
            Controls.Add(Tmakhoa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tmakhoa;
        private Label Tmalop;
        private Label Ttenlop;
        private TextBox Inputmakhoa;
        private TextBox Inputmalop;
        private TextBox Inputtenlop;
        private Button button_them;
        private Button button_xoa;
        private Button button_sua;
    }
}
