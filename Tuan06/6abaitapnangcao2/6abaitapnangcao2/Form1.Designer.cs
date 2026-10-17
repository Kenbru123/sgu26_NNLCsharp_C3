using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _6abaitapnangcao2
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
            Tmasv = new Label();
            Tmamh = new Label();
            Tdiem = new Label();
            button_them = new Button();
            button_xoa = new Button();
            button_sua = new Button();
            Inputmasv = new TextBox();
            Inputmamh = new TextBox();
            Inputdiem = new TextBox();
            SuspendLayout();
            // 
            // Tmasv
            // 
            Tmasv.AutoSize = true;
            Tmasv.Location = new Point(30, 42);
            Tmasv.Name = "Tmasv";
            Tmasv.Size = new Size(47, 20);
            Tmasv.TabIndex = 0;
            Tmasv.Text = "Mã sv";
            // 
            // Tmamh
            // 
            Tmamh.AutoSize = true;
            Tmamh.Location = new Point(30, 88);
            Tmamh.Name = "Tmamh";
            Tmamh.Size = new Size(55, 20);
            Tmamh.TabIndex = 1;
            Tmamh.Text = "Mã mh";
            // 
            // Tdiem
            // 
            Tdiem.AutoSize = true;
            Tdiem.Location = new Point(30, 135);
            Tdiem.Name = "Tdiem";
            Tdiem.Size = new Size(45, 20);
            Tdiem.TabIndex = 2;
            Tdiem.Text = "Điểm";
            // 
            // button_them
            // 
            button_them.Location = new Point(44, 180);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 29);
            button_them.TabIndex = 3;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(153, 180);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 29);
            button_xoa.TabIndex = 4;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_sua
            // 
            button_sua.Location = new Point(263, 180);
            button_sua.Name = "button_sua";
            button_sua.Size = new Size(94, 29);
            button_sua.TabIndex = 5;
            button_sua.Text = "Sửa";
            button_sua.UseVisualStyleBackColor = true;
            button_sua.Click += button_sua_Click;
            // 
            // Inputmasv
            // 
            Inputmasv.Location = new Point(106, 35);
            Inputmasv.Name = "Inputmasv";
            Inputmasv.Size = new Size(251, 27);
            Inputmasv.TabIndex = 6;
            // 
            // Inputmamh
            // 
            Inputmamh.Location = new Point(106, 81);
            Inputmamh.Name = "Inputmamh";
            Inputmamh.Size = new Size(251, 27);
            Inputmamh.TabIndex = 7;
            // 
            // Inputdiem
            // 
            Inputdiem.Location = new Point(106, 128);
            Inputdiem.Name = "Inputdiem";
            Inputdiem.Size = new Size(251, 27);
            Inputdiem.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 231);
            Controls.Add(Inputdiem);
            Controls.Add(Inputmamh);
            Controls.Add(Inputmasv);
            Controls.Add(button_sua);
            Controls.Add(button_xoa);
            Controls.Add(button_them);
            Controls.Add(Tdiem);
            Controls.Add(Tmamh);
            Controls.Add(Tmasv);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tmasv;
        private Label Tmamh;
        private Label Tdiem;
        private Button button_them;
        private Button button_xoa;
        private Button button_sua;
        private TextBox Inputmasv;
        private TextBox Inputmamh;
        private TextBox Inputdiem;
    }
}
