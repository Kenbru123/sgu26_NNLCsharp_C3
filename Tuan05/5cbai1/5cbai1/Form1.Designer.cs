namespace _5cbai1
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
            Tnhapso = new Label();
            Inputnhapso = new TextBox();
            button_capnhat = new Button();
            comboBox_nhapso = new ComboBox();
            comboBox_danhsach = new ComboBox();
            Tdanhsach = new Label();
            button_tong = new Button();
            button_soluonguocsochan = new Button();
            button_soluonguocnguyento = new Button();
            button_thoat = new Button();
            SuspendLayout();
            // 
            // Tnhapso
            // 
            Tnhapso.AutoSize = true;
            Tnhapso.Location = new Point(87, 23);
            Tnhapso.Name = "Tnhapso";
            Tnhapso.Size = new Size(66, 20);
            Tnhapso.TabIndex = 0;
            Tnhapso.Text = "Nhập Số";
            // 
            // Inputnhapso
            // 
            Inputnhapso.Location = new Point(87, 59);
            Inputnhapso.Name = "Inputnhapso";
            Inputnhapso.Size = new Size(125, 27);
            Inputnhapso.TabIndex = 1;
            Inputnhapso.KeyPress += Inputnhapso_KeyPress;
            // 
            // button_capnhat
            // 
            button_capnhat.Location = new Point(236, 58);
            button_capnhat.Name = "button_capnhat";
            button_capnhat.Size = new Size(94, 29);
            button_capnhat.TabIndex = 2;
            button_capnhat.Text = "&Cập nhật";
            button_capnhat.UseVisualStyleBackColor = true;
            button_capnhat.Click += button_capnhat_Click;
            // 
            // comboBox_nhapso
            // 
            comboBox_nhapso.FormattingEnabled = true;
            comboBox_nhapso.Location = new Point(87, 111);
            comboBox_nhapso.Name = "comboBox_nhapso";
            comboBox_nhapso.Size = new Size(243, 28);
            comboBox_nhapso.TabIndex = 3;
            comboBox_nhapso.SelectedIndexChanged += comboBox_nhapso_SelectedIndexChanged;
            // 
            // comboBox_danhsach
            // 
            comboBox_danhsach.FormattingEnabled = true;
            comboBox_danhsach.Location = new Point(414, 59);
            comboBox_danhsach.Name = "comboBox_danhsach";
            comboBox_danhsach.Size = new Size(214, 28);
            comboBox_danhsach.TabIndex = 4;
            // 
            // Tdanhsach
            // 
            Tdanhsach.AutoSize = true;
            Tdanhsach.Location = new Point(414, 23);
            Tdanhsach.Name = "Tdanhsach";
            Tdanhsach.Size = new Size(151, 20);
            Tdanhsach.TabIndex = 5;
            Tdanhsach.Text = "Danh sách các ước số";
            // 
            // button_tong
            // 
            button_tong.Location = new Point(414, 111);
            button_tong.Name = "button_tong";
            button_tong.Size = new Size(214, 29);
            button_tong.TabIndex = 6;
            button_tong.Text = "&Tổng các ước số";
            button_tong.UseVisualStyleBackColor = true;
            button_tong.Click += button_tong_Click;
            // 
            // button_soluonguocsochan
            // 
            button_soluonguocsochan.Location = new Point(414, 157);
            button_soluonguocsochan.Name = "button_soluonguocsochan";
            button_soluonguocsochan.Size = new Size(214, 29);
            button_soluonguocsochan.TabIndex = 7;
            button_soluonguocsochan.Text = "Số lượng các ước &số chẵn";
            button_soluonguocsochan.UseVisualStyleBackColor = true;
            button_soluonguocsochan.Click += button_soluonguocsochan_Click;
            // 
            // button_soluonguocnguyento
            // 
            button_soluonguocnguyento.Location = new Point(414, 207);
            button_soluonguocnguyento.Name = "button_soluonguocnguyento";
            button_soluonguocnguyento.Size = new Size(214, 29);
            button_soluonguocnguyento.TabIndex = 8;
            button_soluonguocnguyento.Text = "Số lượng các ư&ớc số nguyên tố";
            button_soluonguocnguyento.UseVisualStyleBackColor = true;
            button_soluonguocnguyento.Click += button_soluonguocnguyento_Click;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(236, 207);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(94, 29);
            button_thoat.TabIndex = 9;
            button_thoat.Text = "T&hoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 285);
            Controls.Add(button_thoat);
            Controls.Add(button_soluonguocnguyento);
            Controls.Add(button_soluonguocsochan);
            Controls.Add(button_tong);
            Controls.Add(Tdanhsach);
            Controls.Add(comboBox_danhsach);
            Controls.Add(comboBox_nhapso);
            Controls.Add(button_capnhat);
            Controls.Add(Inputnhapso);
            Controls.Add(Tnhapso);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tnhapso;
        private TextBox Inputnhapso;
        private Button button_capnhat;
        private ComboBox comboBox_nhapso;
        private ComboBox comboBox_danhsach;
        private Label Tdanhsach;
        private Button button_tong;
        private Button button_soluonguocsochan;
        private Button button_soluonguocnguyento;
        private Button button_thoat;
    }
}
