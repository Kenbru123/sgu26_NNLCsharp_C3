namespace _6bbaitapnangcao2
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
            Tmonhoc = new Label();
            comboBox_monhoc = new ComboBox();
            button_loc = new Button();
            Ttongdiem = new Label();
            Outputdiem = new TextBox();
            listView_danhsach = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // Tmonhoc
            // 
            Tmonhoc.AutoSize = true;
            Tmonhoc.Location = new Point(28, 42);
            Tmonhoc.Name = "Tmonhoc";
            Tmonhoc.Size = new Size(67, 20);
            Tmonhoc.TabIndex = 0;
            Tmonhoc.Text = "Môn học";
            // 
            // comboBox_monhoc
            // 
            comboBox_monhoc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_monhoc.FormattingEnabled = true;
            comboBox_monhoc.Location = new Point(122, 34);
            comboBox_monhoc.Name = "comboBox_monhoc";
            comboBox_monhoc.Size = new Size(151, 28);
            comboBox_monhoc.TabIndex = 1;
            // 
            // button_loc
            // 
            button_loc.Location = new Point(341, 33);
            button_loc.Name = "button_loc";
            button_loc.Size = new Size(135, 29);
            button_loc.TabIndex = 2;
            button_loc.Text = "Lọc dữ liệu";
            button_loc.UseVisualStyleBackColor = true;
            button_loc.Click += button_loc_Click;
            // 
            // Ttongdiem
            // 
            Ttongdiem.AutoSize = true;
            Ttongdiem.Location = new Point(322, 412);
            Ttongdiem.Name = "Ttongdiem";
            Ttongdiem.Size = new Size(84, 20);
            Ttongdiem.TabIndex = 4;
            Ttongdiem.Text = "Tổng điểm:";
            // 
            // Outputdiem
            // 
            Outputdiem.Location = new Point(425, 405);
            Outputdiem.Name = "Outputdiem";
            Outputdiem.ReadOnly = true;
            Outputdiem.Size = new Size(125, 27);
            Outputdiem.TabIndex = 5;
            Outputdiem.TextAlign = HorizontalAlignment.Right;
            // 
            // listView_danhsach
            // 
            listView_danhsach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView_danhsach.FullRowSelect = true;
            listView_danhsach.GridLines = true;
            listView_danhsach.Location = new Point(28, 90);
            listView_danhsach.MultiSelect = false;
            listView_danhsach.Name = "listView_danhsach";
            listView_danhsach.Size = new Size(601, 292);
            listView_danhsach.TabIndex = 6;
            listView_danhsach.UseCompatibleStateImageBehavior = false;
            listView_danhsach.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên SV";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày sinh";
            columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tên môn học";
            columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Điểm";
            columnHeader5.Width = 65;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(listView_danhsach);
            Controls.Add(Outputdiem);
            Controls.Add(Ttongdiem);
            Controls.Add(button_loc);
            Controls.Add(comboBox_monhoc);
            Controls.Add(Tmonhoc);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tmonhoc;
        private ComboBox comboBox_monhoc;
        private Button button_loc;
        private Label Ttongdiem;
        private TextBox Outputdiem;
        private ListView listView_danhsach;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
