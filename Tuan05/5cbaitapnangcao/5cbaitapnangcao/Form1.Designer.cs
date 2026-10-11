namespace _5cbaitapnangcao
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
            list_ten = new ListBox();
            button_ngaunhien = new Button();
            button_xoadangchon = new Button();
            button_xoatenson = new Button();
            button_xoahole = new Button();
            button_chuhoa = new Button();
            button_chuthuong = new Button();
            button_viethoamoitudau = new Button();
            button_xoatatca = new Button();
            SuspendLayout();
            // 
            // list_ten
            // 
            list_ten.FormattingEnabled = true;
            list_ten.Location = new Point(37, 63);
            list_ten.Name = "list_ten";
            list_ten.Size = new Size(230, 464);
            list_ten.TabIndex = 0;
            list_ten.DoubleClick += list_ten_DoubleClick;
            // 
            // button_ngaunhien
            // 
            button_ngaunhien.Location = new Point(37, 12);
            button_ngaunhien.Name = "button_ngaunhien";
            button_ngaunhien.Size = new Size(230, 45);
            button_ngaunhien.TabIndex = 1;
            button_ngaunhien.Text = "Nhập tên ngẫu nhiên";
            button_ngaunhien.UseVisualStyleBackColor = true;
            button_ngaunhien.Click += button_ngaunhien_Click;
            // 
            // button_xoadangchon
            // 
            button_xoadangchon.Location = new Point(293, 63);
            button_xoadangchon.Name = "button_xoadangchon";
            button_xoadangchon.Size = new Size(423, 45);
            button_xoadangchon.TabIndex = 2;
            button_xoadangchon.Text = "Xóa Phần tử đang chọn";
            button_xoadangchon.UseVisualStyleBackColor = true;
            button_xoadangchon.Click += button_xoadangchon_Click;
            // 
            // button_xoatenson
            // 
            button_xoatenson.Location = new Point(293, 130);
            button_xoatenson.Name = "button_xoatenson";
            button_xoatenson.Size = new Size(423, 45);
            button_xoatenson.TabIndex = 3;
            button_xoatenson.Text = "Xóa phần tử có tên là Sơn";
            button_xoatenson.UseVisualStyleBackColor = true;
            button_xoatenson.Click += button_xoatenson_Click;
            // 
            // button_xoahole
            // 
            button_xoahole.Location = new Point(293, 200);
            button_xoahole.Name = "button_xoahole";
            button_xoahole.Size = new Size(423, 45);
            button_xoahole.TabIndex = 4;
            button_xoahole.Text = "Xóa phần tử có họ là Lê";
            button_xoahole.UseVisualStyleBackColor = true;
            button_xoahole.Click += button_xoahole_Click;
            // 
            // button_chuhoa
            // 
            button_chuhoa.Location = new Point(293, 273);
            button_chuhoa.Name = "button_chuhoa";
            button_chuhoa.Size = new Size(423, 45);
            button_chuhoa.TabIndex = 5;
            button_chuhoa.Text = "Chuyển PT đang chọn thành chữ HOA";
            button_chuhoa.UseVisualStyleBackColor = true;
            button_chuhoa.Click += button_chuhoa_Click;
            // 
            // button_chuthuong
            // 
            button_chuthuong.Location = new Point(293, 345);
            button_chuthuong.Name = "button_chuthuong";
            button_chuthuong.Size = new Size(423, 45);
            button_chuthuong.TabIndex = 6;
            button_chuthuong.Text = "Chuyển PT đang chọn thành chữ thường";
            button_chuthuong.UseVisualStyleBackColor = true;
            button_chuthuong.Click += button_chuthuong_Click;
            // 
            // button_viethoamoitudau
            // 
            button_viethoamoitudau.Location = new Point(293, 418);
            button_viethoamoitudau.Name = "button_viethoamoitudau";
            button_viethoamoitudau.Size = new Size(423, 45);
            button_viethoamoitudau.TabIndex = 7;
            button_viethoamoitudau.Text = "Chuyển PT đang chọn thành viết Hoa đầu mỗi từ";
            button_viethoamoitudau.UseVisualStyleBackColor = true;
            button_viethoamoitudau.Click += button_viethoamoitudau_Click;
            // 
            // button_xoatatca
            // 
            button_xoatatca.Location = new Point(293, 481);
            button_xoatatca.Name = "button_xoatatca";
            button_xoatatca.Size = new Size(423, 45);
            button_xoatatca.TabIndex = 8;
            button_xoatatca.Text = "Xóa tất cả các phần tử";
            button_xoatatca.UseVisualStyleBackColor = true;
            button_xoatatca.Click += button_xoatatca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 546);
            Controls.Add(button_xoatatca);
            Controls.Add(button_viethoamoitudau);
            Controls.Add(button_chuthuong);
            Controls.Add(button_chuhoa);
            Controls.Add(button_xoahole);
            Controls.Add(button_xoatenson);
            Controls.Add(button_xoadangchon);
            Controls.Add(button_ngaunhien);
            Controls.Add(list_ten);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox list_ten;
        private Button button_ngaunhien;
        private Button button_xoadangchon;
        private Button button_xoatenson;
        private Button button_xoahole;
        private Button button_chuhoa;
        private Button button_chuthuong;
        private Button button_viethoamoitudau;
        private Button button_xoatatca;
    }
}
