namespace bai2
{
    partial class form1
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            Ttendangnhap = new Label();
            Tdiachiemail = new Label();
            Tmatkhau = new Label();
            Txacnhan = new Label();
            Inputdangnhap = new TextBox();
            Inputdiachiaemail = new TextBox();
            Inputmatkhau = new TextBox();
            Inputxacnhan = new TextBox();
            button_register = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(222, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(234, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng kí tài khoản";
            // 
            // Ttendangnhap
            // 
            Ttendangnhap.AutoSize = true;
            Ttendangnhap.Location = new Point(39, 89);
            Ttendangnhap.Name = "Ttendangnhap";
            Ttendangnhap.Size = new Size(107, 20);
            Ttendangnhap.TabIndex = 1;
            Ttendangnhap.Text = "Tên đăng nhập";
            // 
            // Tdiachiemail
            // 
            Tdiachiemail.AutoSize = true;
            Tdiachiemail.Location = new Point(39, 129);
            Tdiachiemail.Name = "Tdiachiemail";
            Tdiachiemail.Size = new Size(96, 20);
            Tdiachiemail.TabIndex = 2;
            Tdiachiemail.Text = "Địa chỉ email";
            // 
            // Tmatkhau
            // 
            Tmatkhau.AutoSize = true;
            Tmatkhau.Location = new Point(39, 169);
            Tmatkhau.Name = "Tmatkhau";
            Tmatkhau.Size = new Size(70, 20);
            Tmatkhau.TabIndex = 3;
            Tmatkhau.Text = "Mật khẩu";
            // 
            // Txacnhan
            // 
            Txacnhan.AutoSize = true;
            Txacnhan.Location = new Point(39, 210);
            Txacnhan.Name = "Txacnhan";
            Txacnhan.Size = new Size(134, 20);
            Txacnhan.TabIndex = 4;
            Txacnhan.Text = "Xác nhận mật khẩu";
            // 
            // Inputdangnhap
            // 
            Inputdangnhap.Location = new Point(222, 89);
            Inputdangnhap.Name = "Inputdangnhap";
            Inputdangnhap.Size = new Size(218, 27);
            Inputdangnhap.TabIndex = 5;
            // 
            // Inputdiachiaemail
            // 
            Inputdiachiaemail.Location = new Point(222, 129);
            Inputdiachiaemail.Name = "Inputdiachiaemail";
            Inputdiachiaemail.Size = new Size(218, 27);
            Inputdiachiaemail.TabIndex = 6;
            Inputdiachiaemail.Leave += Inputdiachiemail_Leave;
            // 
            // Inputmatkhau
            // 
            Inputmatkhau.Location = new Point(222, 166);
            Inputmatkhau.Name = "Inputmatkhau";
            Inputmatkhau.Size = new Size(218, 27);
            Inputmatkhau.TabIndex = 7;
            // 
            // Inputxacnhan
            // 
            Inputxacnhan.Location = new Point(222, 207);
            Inputxacnhan.Name = "Inputxacnhan";
            Inputxacnhan.Size = new Size(218, 27);
            Inputxacnhan.TabIndex = 8;
            Inputxacnhan.KeyDown += Inputxacnhan_KeyDown;
            // 
            // button_register
            // 
            button_register.BackColor = SystemColors.ControlLightLight;
            button_register.ForeColor = SystemColors.Highlight;
            button_register.Location = new Point(222, 276);
            button_register.Name = "button_register";
            button_register.Size = new Size(218, 60);
            button_register.TabIndex = 9;
            button_register.Text = "Đăng ký";
            button_register.UseVisualStyleBackColor = false;
            button_register.Click += button_register_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 354);
            Controls.Add(button_register);
            Controls.Add(Inputxacnhan);
            Controls.Add(Inputmatkhau);
            Controls.Add(Inputdiachiaemail);
            Controls.Add(Inputdangnhap);
            Controls.Add(Txacnhan);
            Controls.Add(Tmatkhau);
            Controls.Add(Tdiachiemail);
            Controls.Add(Ttendangnhap);
            Controls.Add(lblTitle);
            Name = "form1";
            Text = "Form1";
            FormClosing += bai2_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label Ttendangnhap;
        private Label Tdiachiemail;
        private Label Tmatkhau;
        private Label Txacnhan;
        private TextBox Inputdangnhap;
        private TextBox Inputdiachiaemail;
        private TextBox Inputmatkhau;
        private TextBox Inputxacnhan;
        private Button button_register;
        private ErrorProvider errorProvider1;
    }
}
