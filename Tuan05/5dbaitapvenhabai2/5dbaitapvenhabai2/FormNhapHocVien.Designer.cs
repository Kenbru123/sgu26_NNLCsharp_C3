using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _5dbaitapvenhabai2
{
    public partial class FormNhapHocVien : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Thoten = new Label();
            Tlop = new Label();
            Inputhoten = new TextBox();
            comboBox_Lop = new ComboBox();
            button_capnhat = new Button();
            button_trove = new Button();
            SuspendLayout();
            // 
            // Thoten
            // 
            Thoten.AutoSize = true;
            Thoten.Location = new Point(90, 71);
            Thoten.Name = "Thoten";
            Thoten.Size = new Size(75, 20);
            Thoten.TabIndex = 0;
            Thoten.Text = "Họ và Tên";
            // 
            // Tlop
            // 
            Tlop.AutoSize = true;
            Tlop.Location = new Point(90, 126);
            Tlop.Name = "Tlop";
            Tlop.Size = new Size(34, 20);
            Tlop.TabIndex = 1;
            Tlop.Text = "Lớp";
            // 
            // Inputhoten
            // 
            Inputhoten.Location = new Point(191, 64);
            Inputhoten.Name = "Inputhoten";
            Inputhoten.Size = new Size(151, 27);
            Inputhoten.TabIndex = 2;
            // 
            // comboBox_Lop
            // 
            comboBox_Lop.FormattingEnabled = true;
            comboBox_Lop.Location = new Point(191, 118);
            comboBox_Lop.Name = "comboBox_Lop";
            comboBox_Lop.Size = new Size(151, 28);
            comboBox_Lop.TabIndex = 3;
            // 
            // button_capnhat
            // 
            button_capnhat.Location = new Point(90, 184);
            button_capnhat.Name = "button_capnhat";
            button_capnhat.Size = new Size(94, 29);
            button_capnhat.TabIndex = 4;
            button_capnhat.Text = "Cập nhật";
            button_capnhat.UseVisualStyleBackColor = true;
            button_capnhat.Click += button_capnhat_Click;
            // 
            // button_trove
            // 
            button_trove.Location = new Point(248, 184);
            button_trove.Name = "button_trove";
            button_trove.Size = new Size(94, 29);
            button_trove.TabIndex = 5;
            button_trove.Text = "Trở về";
            button_trove.UseVisualStyleBackColor = true;
            button_trove.Click += button_trove_Click;
            // 
            // FormNhapHocVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_trove);
            Controls.Add(button_capnhat);
            Controls.Add(comboBox_Lop);
            Controls.Add(Inputhoten);
            Controls.Add(Tlop);
            Controls.Add(Thoten);
            Name = "FormNhapHocVien";
            Text = "Form2";
            LocationChanged += FormNhapHocVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Thoten;
        private Label Tlop;
        private TextBox Inputhoten;
        private ComboBox comboBox_Lop;
        private Button button_capnhat;
        private Button button_trove;
    }
}