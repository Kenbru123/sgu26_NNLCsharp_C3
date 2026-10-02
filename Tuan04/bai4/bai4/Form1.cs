namespace bai4
{
    public partial class Form1 : Form
    {
        private List<int> danhsachSo = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_nhap_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Inputso.Text, out int so))
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Inputso.Focus();
                return;
            }

            danhsachSo.Add(so);

            Inputvuanhap.Text = string.Join(" ", danhsachSo);

            Inputso.Clear();
            Inputso.Focus();

        }

        private void button_tinhtong_Click(object sender, EventArgs e)
        {
            int tong = 0;

            foreach (int so in danhsachSo)
            {
                tong += so;
            }

            Inputtong.Text = tong.ToString();
        }

        private void button_tongchan_Click(object sender, EventArgs e)
        {
            int tongChan = 0;

            foreach (int so in danhsachSo)
            {
                if (so % 2 == 0)
                {
                    tongChan += so;
                }
            }

            Inputtongchan.Text = tongChan.ToString();
        }

        private void button_tongle_Click(object sender, EventArgs e)
        {
            int tongLe = 0;

            foreach (int so in danhsachSo)
            {
                if (so % 2 != 0)
                {
                    tongLe += so;
                }
            }

            Inputtongle.Text = tongLe.ToString();
        }

        private void button_tieptuc_Click(object sender, EventArgs e)
        {
            danhsachSo.Clear();

            Inputso.Clear();
            Inputvuanhap.Clear();
            Inputtong.Clear();
            Inputtongchan.Clear();
            Inputtongle.Clear();

            Inputso.Focus();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
