namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm tính UCLN
        private int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            return a;
        }
        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_thuchien_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Inputa.Text, out int a) ||
                !int.TryParse(Inputb.Text, out int b))
            {
                MessageBox.Show(
                    "Vui lòng nhập a và b là số nguyên!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (a == 0 && b == 0)
            {
                MessageBox.Show(
                    "a và b không được đồng thời bằng 0!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            int ucln = TimUCLN(a, b);

            int bcnn;

            if (a == 0 || b == 0)
            {
                bcnn = 0;
            }
            else
            {
                bcnn = Math.Abs(a * b) / ucln;
            }

            Inputucln.Text = ucln.ToString();
            Inputbcnn.Text = bcnn.ToString();
        }
        private void button_tieptuc_Click(object sender, EventArgs e)
        {
            Inputa.Clear();
            Inputb.Clear();
            Inputucln.Clear();
            Inputbcnn.Clear();

            Inputa.Focus();
        }

        private void bai3_FormClosing(
            object sender,
            FormClosingEventArgs e)
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

        // Chặn nhập ký tự không phải số
        private void txtSo_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
