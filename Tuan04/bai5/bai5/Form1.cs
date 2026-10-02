namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string DocMotSo(int n)
        {
            switch (n)
            {
                case 0: return "không";
                case 1: return "một";
                case 2: return "hai";
                case 3: return "ba";
                case 4: return "bốn";
                case 5: return "năm";
                case 6: return "sáu";
                case 7: return "bảy";
                case 8: return "tám";
                case 9: return "chín";
                default: return "";
            }
        }

        private string DocSo(int n)
        {
            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int donVi = n % 10;

            string ketQua = "";

            // Hàng trăm
            if (tram > 0)
            {
                ketQua += DocMotSo(tram) + " trăm";

                if (chuc == 0 && donVi > 0)
                {
                    ketQua += " lẻ";
                }
            }

            // Hàng chục
            if (chuc > 1)
            {
                ketQua += " " + DocMotSo(chuc) + " mươi";
            }
            else if (chuc == 1)
            {
                ketQua += " mười";
            }

            // Hàng đơn vị
            if (donVi > 0)
            {
                if (chuc > 1)
                {
                    if (donVi == 1)
                        ketQua += " mốt";
                    else if (donVi == 5)
                        ketQua += " lăm";
                    else
                        ketQua += " " + DocMotSo(donVi);
                }
                else
                {
                    ketQua += " " + DocMotSo(donVi);
                }
            }

            return ketQua.Trim();
        }

        private void button_thuchien_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Inputnhap.Text, out int n))
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (n < 1 || n > 999)
            {
                MessageBox.Show(
                    "Chỉ được nhập số từ 1 đến 999!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            Outputketqua.Text = DocSo(n);
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            Inputnhap.Clear();
            Outputketqua.Clear();

            Inputnhap.Focus();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bai5_FormClosing(
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

        private void Inputnhap_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
