namespace _6bbaitapnangcao1
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
            button_hienthi = new Button();
            button_thoat = new Button();
            listView_danhsach = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // button_hienthi
            // 
            button_hienthi.Location = new Point(27, 30);
            button_hienthi.Name = "button_hienthi";
            button_hienthi.Size = new Size(120, 29);
            button_hienthi.TabIndex = 0;
            button_hienthi.Text = "Hiển thị dữ liệu";
            button_hienthi.UseVisualStyleBackColor = true;
            button_hienthi.Click += button_hienthi_Click;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(433, 398);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(94, 40);
            button_thoat.TabIndex = 1;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // listView_danhsach
            // 
            listView_danhsach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView_danhsach.FullRowSelect = true;
            listView_danhsach.GridLines = true;
            listView_danhsach.Location = new Point(27, 65);
            listView_danhsach.MultiSelect = false;
            listView_danhsach.Name = "listView_danhsach";
            listView_danhsach.Size = new Size(500, 327);
            listView_danhsach.TabIndex = 2;
            listView_danhsach.UseCompatibleStateImageBehavior = false;
            listView_danhsach.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã lớp";
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên lớp";
            columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Mã khoa";
            columnHeader4.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 450);
            Controls.Add(listView_danhsach);
            Controls.Add(button_thoat);
            Controls.Add(button_hienthi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button_hienthi;
        private Button button_thoat;
        private ListView listView_danhsach;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
