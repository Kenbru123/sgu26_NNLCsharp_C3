namespace bai4
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
            Tnhapso = new Label();
            Tvuanhap = new Label();
            Ttong = new Label();
            Ttongchan = new Label();
            button_nhap = new Button();
            button_tinhtong = new Button();
            button_tongchan = new Button();
            button_tongle = new Button();
            button_tieptuc = new Button();
            button_thoat = new Button();
            Inputso = new TextBox();
            Inputvuanhap = new TextBox();
            Inputtong = new TextBox();
            Inputtongchan = new TextBox();
            Ttongle = new Label();
            Inputtongle = new TextBox();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.Red;
            lbltitle.Location = new Point(63, 21);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(347, 38);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Nhập Dãy Số và Tính Tổng";
            // 
            // Tnhapso
            // 
            Tnhapso.AutoSize = true;
            Tnhapso.Location = new Point(31, 83);
            Tnhapso.Name = "Tnhapso";
            Tnhapso.Size = new Size(71, 20);
            Tnhapso.TabIndex = 1;
            Tnhapso.Text = "Nhập số :";
            // 
            // Tvuanhap
            // 
            Tvuanhap.AutoSize = true;
            Tvuanhap.Location = new Point(31, 134);
            Tvuanhap.Name = "Tvuanhap";
            Tvuanhap.Size = new Size(107, 20);
            Tvuanhap.TabIndex = 2;
            Tvuanhap.Text = "Dãy vừa nhập :";
            // 
            // Ttong
            // 
            Ttong.AutoSize = true;
            Ttong.Location = new Point(31, 186);
            Ttong.Name = "Ttong";
            Ttong.Size = new Size(199, 20);
            Ttong.TabIndex = 3;
            Ttong.Text = "Tổng các phần tử trong dãy :";
            // 
            // Ttongchan
            // 
            Ttongchan.AutoSize = true;
            Ttongchan.Location = new Point(31, 241);
            Ttongchan.Name = "Ttongchan";
            Ttongchan.Size = new Size(87, 20);
            Ttongchan.TabIndex = 4;
            Ttongchan.Text = "Tổng Chẵn :";
            // 
            // button_nhap
            // 
            button_nhap.BackColor = SystemColors.Control;
            button_nhap.Location = new Point(278, 74);
            button_nhap.Name = "button_nhap";
            button_nhap.Size = new Size(94, 29);
            button_nhap.TabIndex = 5;
            button_nhap.Text = "Nhập";
            button_nhap.UseVisualStyleBackColor = false;
            button_nhap.Click += button_nhap_Click;
            // 
            // button_tinhtong
            // 
            button_tinhtong.Location = new Point(31, 313);
            button_tinhtong.Name = "button_tinhtong";
            button_tinhtong.Size = new Size(94, 29);
            button_tinhtong.TabIndex = 6;
            button_tinhtong.Text = "Tính tổng";
            button_tinhtong.UseVisualStyleBackColor = true;
            button_tinhtong.Click += button_tinhtong_Click;
            // 
            // button_tongchan
            // 
            button_tongchan.Location = new Point(158, 313);
            button_tongchan.Name = "button_tongchan";
            button_tongchan.Size = new Size(94, 29);
            button_tongchan.TabIndex = 7;
            button_tongchan.Text = "Tổng chẵn";
            button_tongchan.UseVisualStyleBackColor = true;
            button_tongchan.Click += button_tongchan_Click;
            // 
            // button_tongle
            // 
            button_tongle.Location = new Point(290, 313);
            button_tongle.Name = "button_tongle";
            button_tongle.Size = new Size(94, 29);
            button_tongle.TabIndex = 8;
            button_tongle.Text = "Tổng lẻ";
            button_tongle.UseVisualStyleBackColor = true;
            button_tongle.Click += button_tongle_Click;
            // 
            // button_tieptuc
            // 
            button_tieptuc.Location = new Point(124, 367);
            button_tieptuc.Name = "button_tieptuc";
            button_tieptuc.Size = new Size(94, 29);
            button_tieptuc.TabIndex = 9;
            button_tieptuc.Text = "Tiếp tục";
            button_tieptuc.UseVisualStyleBackColor = true;
            button_tieptuc.Click += button_tieptuc_Click;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(278, 367);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(94, 29);
            button_thoat.TabIndex = 10;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // Inputso
            // 
            Inputso.Location = new Point(127, 76);
            Inputso.Name = "Inputso";
            Inputso.Size = new Size(125, 27);
            Inputso.TabIndex = 11;
            // 
            // Inputvuanhap
            // 
            Inputvuanhap.Location = new Point(144, 127);
            Inputvuanhap.Name = "Inputvuanhap";
            Inputvuanhap.ReadOnly = true;
            Inputvuanhap.Size = new Size(125, 27);
            Inputvuanhap.TabIndex = 12;
            // 
            // Inputtong
            // 
            Inputtong.Location = new Point(259, 179);
            Inputtong.Name = "Inputtong";
            Inputtong.ReadOnly = true;
            Inputtong.Size = new Size(125, 27);
            Inputtong.TabIndex = 13;
            // 
            // Inputtongchan
            // 
            Inputtongchan.Location = new Point(124, 234);
            Inputtongchan.Name = "Inputtongchan";
            Inputtongchan.ReadOnly = true;
            Inputtongchan.Size = new Size(106, 27);
            Inputtongchan.TabIndex = 14;
            // 
            // Ttongle
            // 
            Ttongle.AutoSize = true;
            Ttongle.Location = new Point(236, 241);
            Ttongle.Name = "Ttongle";
            Ttongle.Size = new Size(69, 20);
            Ttongle.TabIndex = 15;
            Ttongle.Text = "Tổng Lẻ :";
            // 
            // Inputtongle
            // 
            Inputtongle.Location = new Point(311, 234);
            Inputtongle.Name = "Inputtongle";
            Inputtongle.ReadOnly = true;
            Inputtongle.Size = new Size(73, 27);
            Inputtongle.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 450);
            Controls.Add(Inputtongle);
            Controls.Add(Ttongle);
            Controls.Add(Inputtongchan);
            Controls.Add(Inputtong);
            Controls.Add(Inputvuanhap);
            Controls.Add(Inputso);
            Controls.Add(button_thoat);
            Controls.Add(button_tieptuc);
            Controls.Add(button_tongle);
            Controls.Add(button_tongchan);
            Controls.Add(button_tinhtong);
            Controls.Add(button_nhap);
            Controls.Add(Ttongchan);
            Controls.Add(Ttong);
            Controls.Add(Tvuanhap);
            Controls.Add(Tnhapso);
            Controls.Add(lbltitle);
            Name = "Form1";
            Text = "Form1";
            FormClosing += bai4_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label Tnhapso;
        private Label Tvuanhap;
        private Label Ttong;
        private Label Ttongchan;
        private Button button_nhap;
        private Button button_tinhtong;
        private Button button_tongchan;
        private Button button_tongle;
        private Button button_tieptuc;
        private Button button_thoat;
        private TextBox Inputso;
        private TextBox Inputvuanhap;
        private TextBox Inputtong;
        private TextBox Inputtongchan;
        private Label Ttongle;
        private TextBox Inputtongle;
    }
}
