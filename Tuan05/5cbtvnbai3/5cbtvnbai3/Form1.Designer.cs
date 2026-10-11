namespace _5cbtvnbai3
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
            treeView_danhba = new TreeView();
            Inputfirst = new TextBox();
            Inputlast = new TextBox();
            Tfirstname = new Label();
            Tlastname = new Label();
            button_add = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // treeView_danhba
            // 
            treeView_danhba.Location = new Point(12, 12);
            treeView_danhba.Name = "treeView_danhba";
            treeView_danhba.Size = new Size(253, 426);
            treeView_danhba.TabIndex = 0;
            // 
            // Inputfirst
            // 
            Inputfirst.Location = new Point(362, 38);
            Inputfirst.Name = "Inputfirst";
            Inputfirst.Size = new Size(205, 27);
            Inputfirst.TabIndex = 1;
            // 
            // Inputlast
            // 
            Inputlast.Location = new Point(362, 105);
            Inputlast.Name = "Inputlast";
            Inputlast.Size = new Size(205, 27);
            Inputlast.TabIndex = 2;
            // 
            // Tfirstname
            // 
            Tfirstname.AutoSize = true;
            Tfirstname.Location = new Point(287, 45);
            Tfirstname.Name = "Tfirstname";
            Tfirstname.Size = new Size(80, 20);
            Tfirstname.TabIndex = 3;
            Tfirstname.Text = "First Name";
            // 
            // Tlastname
            // 
            Tlastname.AutoSize = true;
            Tlastname.Location = new Point(287, 112);
            Tlastname.Name = "Tlastname";
            Tlastname.Size = new Size(79, 20);
            Tlastname.TabIndex = 4;
            Tlastname.Text = "Last Name";
            // 
            // button_add
            // 
            button_add.Location = new Point(473, 152);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 5;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(493, 243);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 6;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 450);
            Controls.Add(button_exit);
            Controls.Add(button_add);
            Controls.Add(Tlastname);
            Controls.Add(Tfirstname);
            Controls.Add(Inputlast);
            Controls.Add(Inputfirst);
            Controls.Add(treeView_danhba);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView_danhba;
        private TextBox Inputfirst;
        private TextBox Inputlast;
        private Label Tfirstname;
        private Label Tlastname;
        private Button button_add;
        private Button button_exit;
    }
}
