namespace _5cbtvnbai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_nhap_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Inputnhap.Text, out int n))
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Inputnhap.Focus();
                return;
            }

            if (n < 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập số tự nhiên!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Inputnhap.Focus();
                return;
            }

            Listbox.Items.Add(n);

            Inputnhap.Clear();
            Inputnhap.Focus();
        }

        private void button_tongphantu_Click(object sender, EventArgs e)
        {
            int tong = 0;

            foreach (object item in Listbox.Items)
            {
                tong += Convert.ToInt32(item);
            }

            MessageBox.Show(
                "Tổng các phần tử là: " + tong,
                "Kết quả",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void button_xoadaucuoi_Click(object sender, EventArgs e)
        {
            if (Listbox.Items.Count == 0)
            {
                MessageBox.Show("ListBox đang rỗng!");
                return;
            }

            if (Listbox.Items.Count == 1)
            {
                Listbox.Items.RemoveAt(0);
                return;
            }

            Listbox.Items.RemoveAt(Listbox.Items.Count - 1);

            Listbox.Items.RemoveAt(0);
        }

        private void button_xoadangchon_Click(object sender, EventArgs e)
        {
            if (Listbox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử!");
                return;
            }

            for (int i = Listbox.SelectedIndices.Count - 1;
                 i >= 0;
                 i--)
            {
                Listbox.Items.RemoveAt(
                    Listbox.SelectedIndices[i]
                );
            }
        }

        private void button_tangphantu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Listbox.Items.Count; i++)
            {
                int n = Convert.ToInt32(Listbox.Items[i]);

                Listbox.Items[i] = n + 2;
            }
        }

        private void button_thaybinhphuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Listbox.Items.Count; i++)
            {
                int n = Convert.ToInt32(Listbox.Items[i]);

                Listbox.Items[i] = n * n;
            }
        }

        private void button_chonchan_Click(object sender, EventArgs e)
        {
            Listbox.ClearSelected();

            for (int i = 0; i < Listbox.Items.Count; i++)
            {
                int n = Convert.ToInt32(Listbox.Items[i]);

                if (n % 2 == 0)
                {
                    Listbox.SetSelected(i, true);
                }
            }
        }

        private void button_chonle_Click(object sender, EventArgs e)
        {
            Listbox.ClearSelected();

            for (int i = 0; i < Listbox.Items.Count; i++)
            {
                int n = Convert.ToInt32(Listbox.Items[i]);

                if (n % 2 != 0)
                {
                    Listbox.SetSelected(i, true);
                }
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

        private void button_ketthuc_Click(object sender, EventArgs e)
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
