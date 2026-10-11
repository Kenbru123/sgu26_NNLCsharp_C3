namespace _5cbai2
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
            treeView_danhsach = new TreeView();
            Tchonlop = new Label();
            Tthongtinsv = new Label();
            Tmasv = new Label();
            Thoten = new Label();
            Tdiachi = new Label();
            Inputmasv = new TextBox();
            Inputhoten = new TextBox();
            Inputdiachi = new TextBox();
            button_capnhat = new Button();
            button_xoa = new Button();
            checkBox_themlop = new CheckBox();
            Ttenlop = new Label();
            inputlop = new TextBox();
            button_themlop = new Button();
            Outputlop = new ComboBox();
            grpThemLop = new GroupBox();
            grpThemLop.SuspendLayout();
            SuspendLayout();
            // 
            // treeView_danhsach
            // 
            treeView_danhsach.Location = new Point(12, 12);
            treeView_danhsach.Name = "treeView_danhsach";
            treeView_danhsach.Size = new Size(226, 426);
            treeView_danhsach.TabIndex = 0;
            treeView_danhsach.AfterSelect += treeView_danhsach_AfterSelect;
            // 
            // Tchonlop
            // 
            Tchonlop.AutoSize = true;
            Tchonlop.Location = new Point(303, 19);
            Tchonlop.Name = "Tchonlop";
            Tchonlop.Size = new Size(69, 20);
            Tchonlop.TabIndex = 1;
            Tchonlop.Text = "Chọn lớp";
            // 
            // Tthongtinsv
            // 
            Tthongtinsv.AutoSize = true;
            Tthongtinsv.Location = new Point(258, 51);
            Tthongtinsv.Name = "Tthongtinsv";
            Tthongtinsv.Size = new Size(133, 20);
            Tthongtinsv.TabIndex = 2;
            Tthongtinsv.Text = "Thông tin sinh viên";
            // 
            // Tmasv
            // 
            Tmasv.AutoSize = true;
            Tmasv.Location = new Point(303, 94);
            Tmasv.Name = "Tmasv";
            Tmasv.Size = new Size(54, 20);
            Tmasv.TabIndex = 3;
            Tmasv.Text = "Mã SV:";
            // 
            // Thoten
            // 
            Thoten.AutoSize = true;
            Thoten.Location = new Point(303, 140);
            Thoten.Name = "Thoten";
            Thoten.Size = new Size(59, 20);
            Thoten.TabIndex = 4;
            Thoten.Text = "Họ Tên:";
            // 
            // Tdiachi
            // 
            Tdiachi.AutoSize = true;
            Tdiachi.Location = new Point(303, 182);
            Tdiachi.Name = "Tdiachi";
            Tdiachi.Size = new Size(60, 20);
            Tdiachi.TabIndex = 5;
            Tdiachi.Text = "Địa Chỉ:";
            // 
            // Inputmasv
            // 
            Inputmasv.Location = new Point(369, 87);
            Inputmasv.Name = "Inputmasv";
            Inputmasv.Size = new Size(373, 27);
            Inputmasv.TabIndex = 7;
            // 
            // Inputhoten
            // 
            Inputhoten.Location = new Point(369, 133);
            Inputhoten.Name = "Inputhoten";
            Inputhoten.Size = new Size(373, 27);
            Inputhoten.TabIndex = 8;
            // 
            // Inputdiachi
            // 
            Inputdiachi.Location = new Point(369, 175);
            Inputdiachi.Name = "Inputdiachi";
            Inputdiachi.Size = new Size(373, 27);
            Inputdiachi.TabIndex = 9;
            // 
            // button_capnhat
            // 
            button_capnhat.Location = new Point(369, 235);
            button_capnhat.Name = "button_capnhat";
            button_capnhat.Size = new Size(225, 34);
            button_capnhat.TabIndex = 10;
            button_capnhat.Text = "Cập Nhật";
            button_capnhat.UseVisualStyleBackColor = true;
            button_capnhat.Click += button_capnhat_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(648, 235);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 34);
            button_xoa.TabIndex = 11;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // checkBox_themlop
            // 
            checkBox_themlop.AutoSize = true;
            checkBox_themlop.Location = new Point(258, 289);
            checkBox_themlop.Name = "checkBox_themlop";
            checkBox_themlop.Size = new Size(94, 24);
            checkBox_themlop.TabIndex = 12;
            checkBox_themlop.Text = "Thêm lớp";
            checkBox_themlop.UseVisualStyleBackColor = true;
            checkBox_themlop.CheckedChanged += checkbox_themlop_CheckedChanged;
            // 
            // Ttenlop
            // 
            Ttenlop.AutoSize = true;
            Ttenlop.Location = new Point(47, 38);
            Ttenlop.Name = "Ttenlop";
            Ttenlop.Size = new Size(58, 20);
            Ttenlop.TabIndex = 14;
            Ttenlop.Text = "Tên lớp";
            // 
            // inputlop
            // 
            inputlop.Location = new Point(111, 31);
            inputlop.Name = "inputlop";
            inputlop.Size = new Size(225, 27);
            inputlop.TabIndex = 15;
            // 
            // button_themlop
            // 
            button_themlop.Location = new Point(390, 29);
            button_themlop.Name = "button_themlop";
            button_themlop.Size = new Size(94, 29);
            button_themlop.TabIndex = 16;
            button_themlop.Text = "Thêm lớp";
            button_themlop.UseVisualStyleBackColor = true;
            button_themlop.Click += button_themlop_Click;
            // 
            // Outputlop
            // 
            Outputlop.FormattingEnabled = true;
            Outputlop.Location = new Point(369, 16);
            Outputlop.Name = "Outputlop";
            Outputlop.Size = new Size(373, 28);
            Outputlop.TabIndex = 17;
            // 
            // grpThemLop
            // 
            grpThemLop.Controls.Add(Ttenlop);
            grpThemLop.Controls.Add(inputlop);
            grpThemLop.Controls.Add(button_themlop);
            grpThemLop.Location = new Point(258, 319);
            grpThemLop.Name = "grpThemLop";
            grpThemLop.Size = new Size(496, 125);
            grpThemLop.TabIndex = 18;
            grpThemLop.TabStop = false;
            grpThemLop.Text = "Thông tin lớp";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpThemLop);
            Controls.Add(Outputlop);
            Controls.Add(checkBox_themlop);
            Controls.Add(button_xoa);
            Controls.Add(button_capnhat);
            Controls.Add(Inputdiachi);
            Controls.Add(Inputhoten);
            Controls.Add(Inputmasv);
            Controls.Add(Tdiachi);
            Controls.Add(Thoten);
            Controls.Add(Tmasv);
            Controls.Add(Tthongtinsv);
            Controls.Add(Tchonlop);
            Controls.Add(treeView_danhsach);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpThemLop.ResumeLayout(false);
            grpThemLop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView_danhsach;
        private Label Tchonlop;
        private Label Tthongtinsv;
        private Label Tmasv;
        private Label Thoten;
        private Label Tdiachi;
        private TextBox Inputmasv;
        private TextBox Inputhoten;
        private TextBox Inputdiachi;
        private Button button_capnhat;
        private Button button_xoa;
        private CheckBox checkBox_themlop;
        private Label Ttenlop;
        private TextBox inputlop;
        private Button button_themlop;
        private ComboBox Outputlop;
        private GroupBox grpThemLop;
    }
}
