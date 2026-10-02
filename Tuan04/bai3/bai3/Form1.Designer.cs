namespace bai3
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
            lblTitle = new Label();
            Ta = new Label();
            Tb = new Label();
            Tuocso = new Label();
            Tboiso = new Label();
            Inputa = new TextBox();
            Inputb = new TextBox();
            Inputucln = new TextBox();
            Inputbcnn = new TextBox();
            button_thuchien = new Button();
            button_tieptuc = new Button();
            button_thoat = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(45, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ước số chung - Bội số chung";
            // 
            // Ta
            // 
            Ta.AutoSize = true;
            Ta.Location = new Point(66, 95);
            Ta.Name = "Ta";
            Ta.Size = new Size(83, 20);
            Ta.TabIndex = 1;
            Ta.Text = "Nhập số a :";
            // 
            // Tb
            // 
            Tb.AutoSize = true;
            Tb.Location = new Point(66, 147);
            Tb.Name = "Tb";
            Tb.Size = new Size(84, 20);
            Tb.TabIndex = 2;
            Tb.Text = "Nhập số b :";
            // 
            // Tuocso
            // 
            Tuocso.AutoSize = true;
            Tuocso.Location = new Point(65, 192);
            Tuocso.Name = "Tuocso";
            Tuocso.Size = new Size(164, 20);
            Tuocso.TabIndex = 3;
            Tuocso.Text = "Ước số chung lớn nhất :";
            // 
            // Tboiso
            // 
            Tboiso.AutoSize = true;
            Tboiso.Location = new Point(65, 242);
            Tboiso.Name = "Tboiso";
            Tboiso.Size = new Size(163, 20);
            Tboiso.TabIndex = 4;
            Tboiso.Text = "Bội số chung nhỏ nhất :";
            // 
            // Inputa
            // 
            Inputa.Location = new Point(168, 88);
            Inputa.Name = "Inputa";
            Inputa.Size = new Size(139, 27);
            Inputa.TabIndex = 5;
            Inputa.KeyPress += txtSo_KeyPress;
            // 
            // Inputb
            // 
            Inputb.Location = new Point(168, 140);
            Inputb.Name = "Inputb";
            Inputb.Size = new Size(139, 27);
            Inputb.TabIndex = 6;
            Inputb.KeyPress += txtSo_KeyPress;
            // 
            // Inputucln
            // 
            Inputucln.Location = new Point(235, 185);
            Inputucln.Name = "Inputucln";
            Inputucln.ReadOnly = true;
            Inputucln.Size = new Size(72, 27);
            Inputucln.TabIndex = 7;
            // 
            // Inputbcnn
            // 
            Inputbcnn.Location = new Point(235, 235);
            Inputbcnn.Name = "Inputbcnn";
            Inputbcnn.ReadOnly = true;
            Inputbcnn.Size = new Size(72, 27);
            Inputbcnn.TabIndex = 8;
            // 
            // button_thuchien
            // 
            button_thuchien.BackColor = SystemColors.Control;
            button_thuchien.Location = new Point(23, 290);
            button_thuchien.Name = "button_thuchien";
            button_thuchien.Size = new Size(94, 37);
            button_thuchien.TabIndex = 9;
            button_thuchien.Text = "Thực hiện";
            button_thuchien.UseVisualStyleBackColor = false;
            button_thuchien.Click += button_thuchien_Click;
            // 
            // button_tieptuc
            // 
            button_tieptuc.BackColor = SystemColors.Control;
            button_tieptuc.Location = new Point(134, 290);
            button_tieptuc.Name = "button_tieptuc";
            button_tieptuc.Size = new Size(94, 37);
            button_tieptuc.TabIndex = 10;
            button_tieptuc.Text = "Tiếp tục";
            button_tieptuc.UseVisualStyleBackColor = false;
            button_tieptuc.Click += button_tieptuc_Click;
            // 
            // button_thoat
            // 
            button_thoat.BackColor = SystemColors.Control;
            button_thoat.Location = new Point(245, 290);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(94, 37);
            button_thoat.TabIndex = 11;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = false;
            button_thoat.Click += button_thoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 367);
            Controls.Add(button_thoat);
            Controls.Add(button_tieptuc);
            Controls.Add(button_thuchien);
            Controls.Add(Inputbcnn);
            Controls.Add(Inputucln);
            Controls.Add(Inputb);
            Controls.Add(Inputa);
            Controls.Add(Tboiso);
            Controls.Add(Tuocso);
            Controls.Add(Tb);
            Controls.Add(Ta);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            FormClosing += bai3_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label Ta;
        private Label Tb;
        private Label Tuocso;
        private Label Tboiso;
        private TextBox Inputa;
        private TextBox Inputb;
        private TextBox Inputucln;
        private TextBox Inputbcnn;
        private Button button_thuchien;
        private Button button_tieptuc;
        private Button button_thoat;
    }
}
