namespace _5dbaitapvenhabai2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnuBai1_Click(object sender, EventArgs e)
        {
            FormBai1TaiLop frm = new FormBai1TaiLop();
            frm.ShowDialog();
        }
        private void mnuBai2_Click(object sender, EventArgs e)
        {
            FormBai2TaiLop frm = new FormBai2TaiLop();
            frm.ShowDialog();
        }

        private void mnuBaiNangCao_Click(object sender, EventArgs e)
        {
            FormBaiNangCao frm = new FormBaiNangCao();
            frm.ShowDialog();
        }
        private void mnuBTVN1_Click(object sender, EventArgs e)
        {
            FormBTVN1 frm = new FormBTVN1();
            frm.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
