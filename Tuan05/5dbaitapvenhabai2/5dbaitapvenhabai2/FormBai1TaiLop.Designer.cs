namespace _5dbaitapvenhabai2
{
    public partial class FormBai1TaiLop : Form
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
            Thoten = new Label();
            Tmasv = new Label();
            Tgioitinh = new Label();
            Tngoaingu = new Label();
            Tdantoc = new Label();
            Inputhoten = new TextBox();
            Inputmasv = new TextBox();
            chkBox_Anh = new CheckBox();
            chkBox_Phap = new CheckBox();
            chkBox_Hoa = new CheckBox();
            radioButton_Nam = new RadioButton();
            radioButton_Nu = new RadioButton();
            comboBox_dantoc = new ComboBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            cmsSinhVien = new ContextMenuStrip(components);
            mnuXoa = new ToolStripMenuItem();
            button_them = new Button();
            button_xoa = new Button();
            button_sua = new Button();
            cmsSinhVien.SuspendLayout();
            SuspendLayout();
            // 
            // Thoten
            // 
            Thoten.AutoSize = true;
            Thoten.Location = new Point(63, 27);
            Thoten.Name = "Thoten";
            Thoten.Size = new Size(75, 20);
            Thoten.TabIndex = 0;
            Thoten.Text = "Họ và Tên";
            // 
            // Tmasv
            // 
            Tmasv.AutoSize = true;
            Tmasv.Location = new Point(63, 65);
            Tmasv.Name = "Tmasv";
            Tmasv.Size = new Size(91, 20);
            Tmasv.TabIndex = 1;
            Tmasv.Text = "Mã sinh viên";
            // 
            // Tgioitinh
            // 
            Tgioitinh.AutoSize = true;
            Tgioitinh.Location = new Point(63, 113);
            Tgioitinh.Name = "Tgioitinh";
            Tgioitinh.Size = new Size(65, 20);
            Tgioitinh.TabIndex = 2;
            Tgioitinh.Text = "Giới tính";
            // 
            // Tngoaingu
            // 
            Tngoaingu.AutoSize = true;
            Tngoaingu.Location = new Point(63, 156);
            Tngoaingu.Name = "Tngoaingu";
            Tngoaingu.Size = new Size(80, 20);
            Tngoaingu.TabIndex = 3;
            Tngoaingu.Text = "Ngoại ngữ";
            // 
            // Tdantoc
            // 
            Tdantoc.AutoSize = true;
            Tdantoc.Location = new Point(63, 203);
            Tdantoc.Name = "Tdantoc";
            Tdantoc.Size = new Size(61, 20);
            Tdantoc.TabIndex = 4;
            Tdantoc.Text = "Dân tộc";
            // 
            // Inputhoten
            // 
            Inputhoten.Location = new Point(178, 20);
            Inputhoten.Name = "Inputhoten";
            Inputhoten.Size = new Size(282, 27);
            Inputhoten.TabIndex = 5;
            // 
            // Inputmasv
            // 
            Inputmasv.Location = new Point(178, 58);
            Inputmasv.Name = "Inputmasv";
            Inputmasv.Size = new Size(282, 27);
            Inputmasv.TabIndex = 6;
            // 
            // chkBox_Anh
            // 
            chkBox_Anh.AutoSize = true;
            chkBox_Anh.Location = new Point(178, 152);
            chkBox_Anh.Name = "chkBox_Anh";
            chkBox_Anh.Size = new Size(57, 24);
            chkBox_Anh.TabIndex = 7;
            chkBox_Anh.Text = "Anh";
            chkBox_Anh.UseVisualStyleBackColor = true;
            // 
            // chkBox_Phap
            // 
            chkBox_Phap.AutoSize = true;
            chkBox_Phap.Location = new Point(287, 152);
            chkBox_Phap.Name = "chkBox_Phap";
            chkBox_Phap.Size = new Size(64, 24);
            chkBox_Phap.TabIndex = 8;
            chkBox_Phap.Text = "Pháp";
            chkBox_Phap.UseVisualStyleBackColor = true;
            // 
            // chkBox_Hoa
            // 
            chkBox_Hoa.AutoSize = true;
            chkBox_Hoa.Location = new Point(401, 152);
            chkBox_Hoa.Name = "chkBox_Hoa";
            chkBox_Hoa.Size = new Size(59, 24);
            chkBox_Hoa.TabIndex = 9;
            chkBox_Hoa.Text = "Hoa";
            chkBox_Hoa.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nam
            // 
            radioButton_Nam.AutoSize = true;
            radioButton_Nam.Location = new Point(178, 109);
            radioButton_Nam.Name = "radioButton_Nam";
            radioButton_Nam.Size = new Size(62, 24);
            radioButton_Nam.TabIndex = 10;
            radioButton_Nam.TabStop = true;
            radioButton_Nam.Text = "Nam";
            radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nu
            // 
            radioButton_Nu.AutoSize = true;
            radioButton_Nu.Location = new Point(287, 109);
            radioButton_Nu.Name = "radioButton_Nu";
            radioButton_Nu.Size = new Size(50, 24);
            radioButton_Nu.TabIndex = 11;
            radioButton_Nu.TabStop = true;
            radioButton_Nu.Text = "Nữ";
            radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // comboBox_dantoc
            // 
            comboBox_dantoc.FormattingEnabled = true;
            comboBox_dantoc.Location = new Point(178, 195);
            comboBox_dantoc.Name = "comboBox_dantoc";
            comboBox_dantoc.Size = new Size(282, 28);
            comboBox_dantoc.TabIndex = 12;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.ContextMenuStrip = cmsSinhVien;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 245);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 136);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Họ tên";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã sinh viên";
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Giới tính";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngoại ngữ";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Dân tộc";
            columnHeader5.Width = 90;
            // 
            // cmsSinhVien
            // 
            cmsSinhVien.ImageScalingSize = new Size(20, 20);
            cmsSinhVien.Items.AddRange(new ToolStripItem[] { mnuXoa });
            cmsSinhVien.Name = "contextMenuStrip1";
            cmsSinhVien.Size = new Size(105, 28);
            // 
            // mnuXoa
            // 
            mnuXoa.Name = "mnuXoa";
            mnuXoa.Size = new Size(104, 24);
            mnuXoa.Text = "Xóa";
            mnuXoa.Click += mnuXoa_Click;
            // 
            // button_them
            // 
            button_them.Location = new Point(63, 387);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 51);
            button_them.TabIndex = 14;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(219, 387);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 51);
            button_xoa.TabIndex = 15;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_sua
            // 
            button_sua.Location = new Point(366, 387);
            button_sua.Name = "button_sua";
            button_sua.Size = new Size(94, 51);
            button_sua.TabIndex = 16;
            button_sua.Text = "Sửa";
            button_sua.UseVisualStyleBackColor = true;
            button_sua.Click += button_sua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 450);
            Controls.Add(button_sua);
            Controls.Add(button_xoa);
            Controls.Add(button_them);
            Controls.Add(listView1);
            Controls.Add(comboBox_dantoc);
            Controls.Add(radioButton_Nu);
            Controls.Add(radioButton_Nam);
            Controls.Add(chkBox_Hoa);
            Controls.Add(chkBox_Phap);
            Controls.Add(chkBox_Anh);
            Controls.Add(Inputmasv);
            Controls.Add(Inputhoten);
            Controls.Add(Tdantoc);
            Controls.Add(Tngoaingu);
            Controls.Add(Tgioitinh);
            Controls.Add(Tmasv);
            Controls.Add(Thoten);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            cmsSinhVien.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Thoten;
        private Label Tmasv;
        private Label Tgioitinh;
        private Label Tngoaingu;
        private Label Tdantoc;
        private TextBox Inputhoten;
        private TextBox Inputmasv;
        private CheckBox chkBox_Anh;
        private CheckBox chkBox_Phap;
        private CheckBox chkBox_Hoa;
        private RadioButton radioButton_Nam;
        private RadioButton radioButton_Nu;
        private ComboBox comboBox_dantoc;
        private ListView listView1;
        private Button button_them;
        private Button button_xoa;
        private Button button_sua;
        private ContextMenuStrip cmsSinhVien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ToolStripMenuItem mnuXoa;
    }
}
