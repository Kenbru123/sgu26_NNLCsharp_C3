using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _6abaitaptailopbai1
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
            Tmamon = new Label();
            Tmonhoc = new Label();
            Inputma = new TextBox();
            Inputten = new TextBox();
            button_them = new Button();
            button_xoa = new Button();
            button_sua = new Button();
            SuspendLayout();
            // 
            // Tmamon
            // 
            Tmamon.AutoSize = true;
            Tmamon.Location = new Point(74, 47);
            Tmamon.Name = "Tmamon";
            Tmamon.Size = new Size(55, 20);
            Tmamon.TabIndex = 0;
            Tmamon.Text = "Mã mh";
            // 
            // Tmonhoc
            // 
            Tmonhoc.AutoSize = true;
            Tmonhoc.Location = new Point(74, 87);
            Tmonhoc.Name = "Tmonhoc";
            Tmonhoc.Size = new Size(57, 20);
            Tmonhoc.TabIndex = 1;
            Tmonhoc.Text = "Tên mh";
            // 
            // Inputma
            // 
            Inputma.Location = new Point(159, 40);
            Inputma.Name = "Inputma";
            Inputma.Size = new Size(246, 27);
            Inputma.TabIndex = 2;
            // 
            // Inputten
            // 
            Inputten.Location = new Point(159, 80);
            Inputten.Name = "Inputten";
            Inputten.Size = new Size(246, 27);
            Inputten.TabIndex = 3;
            // 
            // button_them
            // 
            button_them.Location = new Point(74, 156);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 46);
            button_them.TabIndex = 4;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(190, 156);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 46);
            button_xoa.TabIndex = 5;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_sua
            // 
            button_sua.Location = new Point(311, 156);
            button_sua.Name = "button_sua";
            button_sua.Size = new Size(94, 46);
            button_sua.TabIndex = 6;
            button_sua.Text = "Sửa";
            button_sua.UseVisualStyleBackColor = true;
            button_sua.Click += button_sua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 214);
            Controls.Add(button_sua);
            Controls.Add(button_xoa);
            Controls.Add(button_them);
            Controls.Add(Inputten);
            Controls.Add(Inputma);
            Controls.Add(Tmonhoc);
            Controls.Add(Tmamon);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tmamon;
        private Label Tmonhoc;
        private TextBox Inputma;
        private TextBox Inputten;
        private Button button_them;
        private Button button_xoa;
        private Button button_sua;
    }
}
