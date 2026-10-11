namespace _5cbai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_capnhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra textbox có rỗng không
            if (Inputnhapso.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Inputnhapso.Focus();
                return;
            }

            if (!int.TryParse(Inputnhapso.Text, out int n))
            {
                MessageBox.Show(
                    "Dữ liệu nhập phải là số nguyên!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Inputnhapso.SelectAll();
                Inputnhapso.Focus();
                return;
            }

            if (n <= 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên dương!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Inputnhapso.SelectAll();
                Inputnhapso.Focus();
                return;
            }

            foreach (object item in comboBox_nhapso.Items)
            {
                if (item.ToString() == n.ToString())
                {
                    MessageBox.Show(
                        "Số này đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    Inputnhapso.Clear();
                    Inputnhapso.Focus();
                    return;
                }
            }

            comboBox_nhapso.Items.Add(n);

            Inputnhapso.Clear();

            Inputnhapso.Focus();
        }

        private void comboBox_nhapso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_nhapso.SelectedIndex == -1)
                return;

            int n = Convert.ToInt32(comboBox_nhapso.SelectedItem);

            // Xóa danh sách ước cũ
            comboBox_danhsach.Items.Clear();

            // Tìm tất cả ước của n
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    comboBox_danhsach.Items.Add(i);
                }
            }
        }

        private void button_tong_Click(object sender, EventArgs e)
        {
            if (comboBox_danhsach.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn số!");
                return;
            }

            int tong = 0;

            foreach (object item in comboBox_danhsach.Items)
            {
                tong += Convert.ToInt32(item);
            }

            MessageBox.Show(
                "Tổng các ước số là: " + tong,
                "Kết quả",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void button_soluonguocsochan_Click(object sender, EventArgs e)
        {
            if (comboBox_danhsach.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn số!");
                return;
            }

            int dem = 0;

            foreach (object item in comboBox_danhsach.Items)
            {
                int x = Convert.ToInt32(item);

                if (x % 2 == 0)
                {
                    dem++;
                }
            }

            MessageBox.Show(
                "Số lượng ước số chẵn là: " + dem,
                "Kết quả",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        private void button_soluonguocnguyento_Click(object sender, EventArgs e)
        {
            if (comboBox_danhsach.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn số!");
                return;
            }

            int dem = 0;

            foreach (object item in comboBox_danhsach.Items)
            {
                int x = Convert.ToInt32(item);

                if (LaSoNguyenTo(x))
                {
                    dem++;
                }
            }

            MessageBox.Show(
                "Số lượng ước số nguyên tố là: " + dem,
                "Kết quả",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void Inputnhapso_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
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
