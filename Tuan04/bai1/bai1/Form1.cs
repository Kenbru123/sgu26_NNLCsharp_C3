namespace bai1
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private bool KiemTraDuLieu(out double a, out double b)
        {
            errorProvider1.Clear();
            bool hopleA = double.TryParse(Inputa.Text, out a);
            bool hopleB = double.TryParse(Inputb.Text, out b);
            if (!hopleA)
            {
                errorProvider1.SetError(Inputa, "a phải là số");
            }

            if (!hopleB)
            {
                errorProvider1.SetError(Inputb, "b phải là số");
            }

            if (!hopleA || !hopleB)
            {
                MessageBox.Show(
                    "Vui lòng nhập a và b là số!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }

            return true;
        }
        private void button1_plus(object sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                Outputresult.Text = (a + b).ToString();
            }
        }

        private void button2_minus(object sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                Outputresult.Text = (a - b).ToString();
            }
        }

        private void button3_multiply(object sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                Outputresult.Text = (a * b).ToString();
            }
        }

        private void button4_divide(object sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                if (b == 0)
                {
                    errorProvider1.SetError(Inputb, "b phải khác 0");

                    MessageBox.Show(
                        "Không thể chia cho 0!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                Outputresult.Text = (a / b).ToString();
            }
        }
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == '-' && txt.SelectionStart == 0
                && !txt.Text.Contains("-"))
                return;

            if ((e.KeyChar == '.' || e.KeyChar == ',')
                && !txt.Text.Contains(".")
                && !txt.Text.Contains(","))
                return;

            e.Handled = true;
        }
        private void bai1_FormClosing(
           object sender,
           FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Ban co muon thoat khong ?",
                "Thoat",
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
