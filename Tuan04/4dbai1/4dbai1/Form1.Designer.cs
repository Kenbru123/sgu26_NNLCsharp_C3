namespace _4dbai1
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
            Ta = new Label();
            Tb = new Label();
            Tc = new Label();
            Tketqua = new Label();
            Inputa = new TextBox();
            Inputb = new TextBox();
            Inputc = new TextBox();
            Outputketqua = new TextBox();
            button_giai = new Button();
            button_thoat = new Button();
            radioButton_bacnhat = new RadioButton();
            radioButton_bachai = new RadioButton();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.Red;
            lbltitle.Location = new Point(118, 21);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(239, 38);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Giải Phương Trình";
            // 
            // Ta
            // 
            Ta.AutoSize = true;
            Ta.Location = new Point(22, 167);
            Ta.Name = "Ta";
            Ta.Size = new Size(57, 20);
            Ta.TabIndex = 1;
            Ta.Text = "Nhập a";
            // 
            // Tb
            // 
            Tb.AutoSize = true;
            Tb.Location = new Point(22, 217);
            Tb.Name = "Tb";
            Tb.Size = new Size(58, 20);
            Tb.TabIndex = 2;
            Tb.Text = "Nhập b";
            // 
            // Tc
            // 
            Tc.AutoSize = true;
            Tc.Location = new Point(22, 268);
            Tc.Name = "Tc";
            Tc.Size = new Size(56, 20);
            Tc.TabIndex = 3;
            Tc.Text = "Nhập c";
            // 
            // Tketqua
            // 
            Tketqua.AutoSize = true;
            Tketqua.Location = new Point(22, 377);
            Tketqua.Name = "Tketqua";
            Tketqua.Size = new Size(60, 20);
            Tketqua.TabIndex = 4;
            Tketqua.Text = "Kết quả";
            // 
            // Inputa
            // 
            Inputa.Location = new Point(134, 167);
            Inputa.Name = "Inputa";
            Inputa.Size = new Size(125, 27);
            Inputa.TabIndex = 5;
            Inputa.TextChanged += txtDuLieu_TextChanged;
            // 
            // Inputb
            // 
            Inputb.Location = new Point(134, 217);
            Inputb.Name = "Inputb";
            Inputb.Size = new Size(125, 27);
            Inputb.TabIndex = 6;
            Inputb.TextChanged += txtDuLieu_TextChanged;
            // 
            // Inputc
            // 
            Inputc.Location = new Point(134, 268);
            Inputc.Name = "Inputc";
            Inputc.Size = new Size(125, 27);
            Inputc.TabIndex = 7;
            Inputc.TextChanged += txtDuLieu_TextChanged;
            // 
            // Outputketqua
            // 
            Outputketqua.Location = new Point(134, 370);
            Outputketqua.Name = "Outputketqua";
            Outputketqua.ReadOnly = true;
            Outputketqua.Size = new Size(305, 27);
            Outputketqua.TabIndex = 8;
            // 
            // button_giai
            // 
            button_giai.Location = new Point(345, 167);
            button_giai.Name = "button_giai";
            button_giai.Size = new Size(94, 59);
            button_giai.TabIndex = 9;
            button_giai.Text = "Giải";
            button_giai.UseVisualStyleBackColor = true;
            button_giai.Click += button_giai_Click;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(345, 239);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(94, 56);
            button_thoat.TabIndex = 10;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // radioButton_bacnhat
            // 
            radioButton_bacnhat.AutoSize = true;
            radioButton_bacnhat.Location = new Point(46, 79);
            radioButton_bacnhat.Name = "radioButton_bacnhat";
            radioButton_bacnhat.Size = new Size(176, 24);
            radioButton_bacnhat.TabIndex = 11;
            radioButton_bacnhat.TabStop = true;
            radioButton_bacnhat.Text = "Phương trình bậc nhất";
            radioButton_bacnhat.UseVisualStyleBackColor = true;
            radioButton_bacnhat.CheckedChanged += radiobutton_bacnhat_CheckedChanged;
            // 
            // radioButton_bachai
            // 
            radioButton_bachai.AutoSize = true;
            radioButton_bachai.Location = new Point(46, 109);
            radioButton_bachai.Name = "radioButton_bachai";
            radioButton_bachai.Size = new Size(167, 24);
            radioButton_bachai.TabIndex = 12;
            radioButton_bachai.TabStop = true;
            radioButton_bachai.Text = "Phương trình bậc hai";
            radioButton_bachai.UseVisualStyleBackColor = true;
            radioButton_bachai.CheckedChanged += radiobutton_bachai_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(radioButton_bachai);
            Controls.Add(radioButton_bacnhat);
            Controls.Add(button_thoat);
            Controls.Add(button_giai);
            Controls.Add(Outputketqua);
            Controls.Add(Inputc);
            Controls.Add(Inputb);
            Controls.Add(Inputa);
            Controls.Add(Tketqua);
            Controls.Add(Tc);
            Controls.Add(Tb);
            Controls.Add(Ta);
            Controls.Add(lbltitle);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label Ta;
        private Label Tb;
        private Label Tc;
        private Label Tketqua;
        private TextBox Inputa;
        private TextBox Inputb;
        private TextBox Inputc;
        private TextBox Outputketqua;
        private Button button_giai;
        private Button button_thoat;
        private RadioButton radioButton_bacnhat;
        private RadioButton radioButton_bachai;
    }
}
