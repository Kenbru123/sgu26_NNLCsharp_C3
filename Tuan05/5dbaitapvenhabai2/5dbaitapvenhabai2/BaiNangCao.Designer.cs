using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _5dbaitapvenhabai2
{
    public partial class FormBaiNangCao : Form
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
            listlopA = new ListBox();
            listlopB = new ListBox();
            menuStrip1 = new MenuStrip();
            mnuCapNhat = new ToolStripMenuItem();
            mnuNhapHocVien = new ToolStripMenuItem();
            mnuSangLopB = new ToolStripMenuItem();
            mnuSangLopA = new ToolStripMenuItem();
            mnuXoaHocVien = new ToolStripMenuItem();
            mnuKetthuc = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listlopA
            // 
            listlopA.FormattingEnabled = true;
            listlopA.Location = new Point(42, 69);
            listlopA.Name = "listlopA";
            listlopA.SelectionMode = SelectionMode.MultiExtended;
            listlopA.Size = new Size(150, 104);
            listlopA.TabIndex = 0;
            // 
            // listlopB
            // 
            listlopB.FormattingEnabled = true;
            listlopB.Location = new Point(232, 69);
            listlopB.Name = "listlopB";
            listlopB.SelectionMode = SelectionMode.MultiExtended;
            listlopB.Size = new Size(150, 104);
            listlopB.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCapNhat, mnuKetthuc });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(544, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuCapNhat
            // 
            mnuCapNhat.DropDownItems.AddRange(new ToolStripItem[] { mnuNhapHocVien, mnuSangLopB, mnuSangLopA, mnuXoaHocVien });
            mnuCapNhat.Name = "mnuCapNhat";
            mnuCapNhat.Size = new Size(82, 24);
            mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuNhapHocVien
            // 
            mnuNhapHocVien.Name = "mnuNhapHocVien";
            mnuNhapHocVien.Size = new Size(224, 26);
            mnuNhapHocVien.Text = "Nhập học viên mới";
            mnuNhapHocVien.Click += mnuNhapHocVien_Click;
            // 
            // mnuSangLopB
            // 
            mnuSangLopB.Name = "mnuSangLopB";
            mnuSangLopB.Size = new Size(224, 26);
            mnuSangLopB.Text = "Chuyển sang lớp B";
            mnuSangLopB.Click += mnuSangLopB_Click;
            // 
            // mnuSangLopA
            // 
            mnuSangLopA.Name = "mnuSangLopA";
            mnuSangLopA.Size = new Size(224, 26);
            mnuSangLopA.Text = "Chuyển sang lớp A";
            mnuSangLopA.Click += mnuSangLopA_Click;
            // 
            // mnuXoaHocVien
            // 
            mnuXoaHocVien.Name = "mnuXoaHocVien";
            mnuXoaHocVien.Size = new Size(224, 26);
            mnuXoaHocVien.Text = "Xóa học viên";
            mnuXoaHocVien.Click += mnuXoaHocVien_Click;
            // 
            // mnuKetthuc
            // 
            mnuKetthuc.Name = "mnuKetthuc";
            mnuKetthuc.Size = new Size(77, 24);
            mnuKetthuc.Text = "Kết thúc";
            mnuKetthuc.Click += mnuKetThuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 417);
            Controls.Add(listlopB);
            Controls.Add(listlopA);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listlopA;
        private ListBox listlopB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuCapNhat;
        private ToolStripMenuItem mnuNhapHocVien;
        private ToolStripMenuItem mnuSangLopB;
        private ToolStripMenuItem mnuSangLopA;
        private ToolStripMenuItem mnuXoaHocVien;
        private ToolStripMenuItem mnuKetthuc;
    }
}
