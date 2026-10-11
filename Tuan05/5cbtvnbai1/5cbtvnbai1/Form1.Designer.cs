namespace _5cbtvnbai1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Outputdich = new TextBox();
            comboBox_Anh = new ComboBox();
            Ttiengviet = new Label();
            Ttienganh = new Label();
            tabPage2 = new TabPage();
            button_thoat = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(35, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(480, 407);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Outputdich);
            tabPage1.Controls.Add(comboBox_Anh);
            tabPage1.Controls.Add(Ttiengviet);
            tabPage1.Controls.Add(Ttienganh);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(472, 374);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ANH - VIỆT";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Outputdich
            // 
            Outputdich.Location = new Point(246, 52);
            Outputdich.Multiline = true;
            Outputdich.Name = "Outputdich";
            Outputdich.ReadOnly = true;
            Outputdich.Size = new Size(200, 316);
            Outputdich.TabIndex = 3;
            // 
            // comboBox_Anh
            // 
            comboBox_Anh.FormattingEnabled = true;
            comboBox_Anh.Location = new Point(22, 51);
            comboBox_Anh.Name = "comboBox_Anh";
            comboBox_Anh.Size = new Size(208, 28);
            comboBox_Anh.TabIndex = 2;
            comboBox_Anh.Click += comboBox_Anh_DoubleClick;
            comboBox_Anh.KeyDown += comboBox_Anh_KeyDown;
            // 
            // Ttiengviet
            // 
            Ttiengviet.AutoSize = true;
            Ttiengviet.Location = new Point(246, 28);
            Ttiengviet.Name = "Ttiengviet";
            Ttiengviet.Size = new Size(76, 20);
            Ttiengviet.TabIndex = 1;
            Ttiengviet.Text = "Tiếng Việt";
            // 
            // Ttienganh
            // 
            Ttienganh.AutoSize = true;
            Ttienganh.Location = new Point(22, 28);
            Ttienganh.Name = "Ttienganh";
            Ttienganh.Size = new Size(76, 20);
            Ttienganh.TabIndex = 0;
            Ttienganh.Text = "Tiếng Anh";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(472, 374);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "VIỆT - ANH";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(450, 440);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(94, 29);
            button_thoat.TabIndex = 1;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 477);
            Controls.Add(button_thoat);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button_thoat;
        private ComboBox comboBox_Anh;
        private Label Ttiengviet;
        private Label Ttienganh;
        private TextBox Outputdich;
    }
}
