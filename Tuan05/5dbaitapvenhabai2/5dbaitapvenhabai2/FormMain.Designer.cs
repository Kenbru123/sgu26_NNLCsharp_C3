namespace _5dbaitapvenhabai2
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            mnuBaitap = new ToolStripMenuItem();
            mnuBai1 = new ToolStripMenuItem();
            mnuBai2 = new ToolStripMenuItem();
            mnuNangCao = new ToolStripMenuItem();
            mnuBTVN1 = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBaitap });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBaitap
            // 
            mnuBaitap.DropDownItems.AddRange(new ToolStripItem[] { mnuBai1, mnuBai2, mnuNangCao, mnuBTVN1, mnuThoat });
            mnuBaitap.Name = "mnuBaitap";
            mnuBaitap.Size = new Size(70, 24);
            mnuBaitap.Text = "Bài tập";
            // 
            // mnuBai1
            // 
            mnuBai1.Name = "mnuBai1";
            mnuBai1.Size = new Size(224, 26);
            mnuBai1.Text = "Bài 1 tại lớp";
            mnuBai1.Click += mnuBai1_Click;
            // 
            // mnuBai2
            // 
            mnuBai2.Name = "mnuBai2";
            mnuBai2.Size = new Size(224, 26);
            mnuBai2.Text = "Bài 2 tại lớp";
            mnuBai2.Click += mnuBai2_Click;
            // 
            // mnuNangCao
            // 
            mnuNangCao.Name = "mnuNangCao";
            mnuNangCao.Size = new Size(224, 26);
            mnuNangCao.Text = "Bài tập nâng cao";
            mnuNangCao.Click += mnuBaiNangCao_Click;
            // 
            // mnuBTVN1
            // 
            mnuBTVN1.Name = "mnuBTVN1";
            mnuBTVN1.Size = new Size(224, 26);
            mnuBTVN1.Text = "BTVN 1";
            mnuBTVN1.Click += mnuBTVN1_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(224, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBaitap;
        private ToolStripMenuItem mnuBai1;
        private ToolStripMenuItem mnuBai2;
        private ToolStripMenuItem mnuNangCao;
        private ToolStripMenuItem mnuBTVN1;
        private ToolStripMenuItem mnuThoat;
    }
}
