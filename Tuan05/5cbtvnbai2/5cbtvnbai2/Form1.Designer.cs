namespace _5cbtvnbai2
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
            Ttitle = new Label();
            Listbox = new ListBox();
            Inputnhap = new TextBox();
            button_nhap = new Button();
            Txuly = new Label();
            button_tongphantu = new Button();
            button_xoadaucuoi = new Button();
            button_xoadangchon = new Button();
            button_tangphantu = new Button();
            button_thaybinhphuong = new Button();
            button_chonchan = new Button();
            button_chonle = new Button();
            button_ketthuc = new Button();
            SuspendLayout();
            // 
            // Ttitle
            // 
            Ttitle.AutoSize = true;
            Ttitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ttitle.ForeColor = Color.FromArgb(255, 128, 0);
            Ttitle.Location = new Point(216, 9);
            Ttitle.Name = "Ttitle";
            Ttitle.Size = new Size(129, 41);
            Ttitle.TabIndex = 0;
            Ttitle.Text = "LISTBOX";
            // 
            // Listbox
            // 
            Listbox.FormattingEnabled = true;
            Listbox.Location = new Point(51, 175);
            Listbox.Name = "Listbox";
            Listbox.SelectionMode = SelectionMode.MultiExtended;
            Listbox.Size = new Size(150, 224);
            Listbox.TabIndex = 1;
            // 
            // Inputnhap
            // 
            Inputnhap.Location = new Point(61, 85);
            Inputnhap.Name = "Inputnhap";
            Inputnhap.Size = new Size(125, 27);
            Inputnhap.TabIndex = 2;
            Inputnhap.KeyPress += Inputnhap_KeyPress;
            // 
            // button_nhap
            // 
            button_nhap.Location = new Point(61, 118);
            button_nhap.Name = "button_nhap";
            button_nhap.Size = new Size(125, 39);
            button_nhap.TabIndex = 3;
            button_nhap.Text = "&Nhập";
            button_nhap.UseVisualStyleBackColor = true;
            button_nhap.Click += button_nhap_Click;
            // 
            // Txuly
            // 
            Txuly.AutoSize = true;
            Txuly.Location = new Point(281, 55);
            Txuly.Name = "Txuly";
            Txuly.Size = new Size(93, 20);
            Txuly.TabIndex = 4;
            Txuly.Text = "Xử lý Listbox";
            // 
            // button_tongphantu
            // 
            button_tongphantu.Location = new Point(281, 85);
            button_tongphantu.Name = "button_tongphantu";
            button_tongphantu.Size = new Size(241, 39);
            button_tongphantu.TabIndex = 5;
            button_tongphantu.Text = "Tổng các phần tử trong List";
            button_tongphantu.UseVisualStyleBackColor = true;
            button_tongphantu.Click += button_tongphantu_Click;
            // 
            // button_xoadaucuoi
            // 
            button_xoadaucuoi.Location = new Point(281, 130);
            button_xoadaucuoi.Name = "button_xoadaucuoi";
            button_xoadaucuoi.Size = new Size(241, 39);
            button_xoadaucuoi.TabIndex = 6;
            button_xoadaucuoi.Text = "Xóa phần tử đầu và cuối";
            button_xoadaucuoi.UseVisualStyleBackColor = true;
            button_xoadaucuoi.Click += button_xoadaucuoi_Click;
            // 
            // button_xoadangchon
            // 
            button_xoadangchon.Location = new Point(281, 175);
            button_xoadangchon.Name = "button_xoadangchon";
            button_xoadangchon.Size = new Size(241, 39);
            button_xoadangchon.TabIndex = 7;
            button_xoadangchon.Text = "Xóa phần tử đang chọn";
            button_xoadangchon.UseVisualStyleBackColor = true;
            button_xoadangchon.Click += button_xoadangchon_Click;
            // 
            // button_tangphantu
            // 
            button_tangphantu.Location = new Point(281, 220);
            button_tangphantu.Name = "button_tangphantu";
            button_tangphantu.Size = new Size(241, 39);
            button_tangphantu.TabIndex = 8;
            button_tangphantu.Text = "Tăng mỗi phần tử lên 2";
            button_tangphantu.UseVisualStyleBackColor = true;
            button_tangphantu.Click += button_tangphantu_Click;
            // 
            // button_thaybinhphuong
            // 
            button_thaybinhphuong.Location = new Point(281, 265);
            button_thaybinhphuong.Name = "button_thaybinhphuong";
            button_thaybinhphuong.Size = new Size(241, 39);
            button_thaybinhphuong.TabIndex = 9;
            button_thaybinhphuong.Text = "Thay bằng bình phương";
            button_thaybinhphuong.UseVisualStyleBackColor = true;
            button_thaybinhphuong.Click += button_thaybinhphuong_Click;
            // 
            // button_chonchan
            // 
            button_chonchan.Location = new Point(281, 310);
            button_chonchan.Name = "button_chonchan";
            button_chonchan.Size = new Size(241, 39);
            button_chonchan.TabIndex = 10;
            button_chonchan.Text = "Chọn số chẵn";
            button_chonchan.UseVisualStyleBackColor = true;
            button_chonchan.Click += button_chonchan_Click;
            // 
            // button_chonle
            // 
            button_chonle.Location = new Point(281, 360);
            button_chonle.Name = "button_chonle";
            button_chonle.Size = new Size(241, 39);
            button_chonle.TabIndex = 11;
            button_chonle.Text = "Chọn số lẻ";
            button_chonle.UseVisualStyleBackColor = true;
            button_chonle.Click += button_chonle_Click;
            // 
            // button_ketthuc
            // 
            button_ketthuc.Location = new Point(51, 424);
            button_ketthuc.Name = "button_ketthuc";
            button_ketthuc.Size = new Size(471, 50);
            button_ketthuc.TabIndex = 12;
            button_ketthuc.Text = "&KẾT THÚC";
            button_ketthuc.UseVisualStyleBackColor = true;
            button_ketthuc.Click += button_ketthuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 486);
            Controls.Add(button_ketthuc);
            Controls.Add(button_chonle);
            Controls.Add(button_chonchan);
            Controls.Add(button_thaybinhphuong);
            Controls.Add(button_tangphantu);
            Controls.Add(button_xoadangchon);
            Controls.Add(button_xoadaucuoi);
            Controls.Add(button_tongphantu);
            Controls.Add(Txuly);
            Controls.Add(button_nhap);
            Controls.Add(Inputnhap);
            Controls.Add(Listbox);
            Controls.Add(Ttitle);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Ttitle;
        private ListBox Listbox;
        private TextBox Inputnhap;
        private Button button_nhap;
        private Label Txuly;
        private Button button_tongphantu;
        private Button button_xoadaucuoi;
        private Button button_xoadangchon;
        private Button button_tangphantu;
        private Button button_thaybinhphuong;
        private Button button_chonchan;
        private Button button_chonle;
        private Button button_ketthuc;
    }
}
