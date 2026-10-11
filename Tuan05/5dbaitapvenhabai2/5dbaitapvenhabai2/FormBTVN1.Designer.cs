using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _5dbaitapvenhabai2
{
    public partial class FormBTVN1 : Form
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
            Tthoigian = new Label();
            button_batdau = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Tthoigian
            // 
            Tthoigian.AutoSize = true;
            Tthoigian.Location = new Point(198, 24);
            Tthoigian.Name = "Tthoigian";
            Tthoigian.Size = new Size(44, 20);
            Tthoigian.TabIndex = 0;
            Tthoigian.Text = "30:00";
            // 
            // button_batdau
            // 
            button_batdau.Location = new Point(174, 56);
            button_batdau.Name = "button_batdau";
            button_batdau.Size = new Size(94, 39);
            button_batdau.TabIndex = 1;
            button_batdau.Text = "Bắt đầu";
            button_batdau.UseVisualStyleBackColor = true;
            button_batdau.Click += buton_batdau_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 163);
            Controls.Add(button_batdau);
            Controls.Add(Tthoigian);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tthoigian;
        private Button button_batdau;
        private System.Windows.Forms.Timer timer1;
    }
}
