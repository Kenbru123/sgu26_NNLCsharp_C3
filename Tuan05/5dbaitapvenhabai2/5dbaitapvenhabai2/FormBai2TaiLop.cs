using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _5dbaitapvenhabai2
{
    public partial class FormBai2TaiLop : Form
    {
        public FormBai2TaiLop()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_luu.Enabled = false;
            button_xoa.Enabled = false;

            Outputtongtien.ReadOnly = true;
        }

        private void XoaTextBox()
        {
            Inputtaikhoan.Clear();
            Inputten.Clear();
            Inputdiachi.Clear();
            Inputsotk.Clear();

            Inputtaikhoan.Focus();
        }

        private bool SoTaiKhoanDaTonTai(string stk)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == stk)
                {
                    return true;
                }
            }

            return false;
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (button_them.Text == "Thêm")
            {
                button_them.Text = "Hủy";

                button_luu.Enabled = true;
                button_xoa.Enabled = false;

                XoaTextBox();
            }
            else
            {
                button_them.Text = "Thêm";

                button_luu.Enabled = false;

                XoaTextBox();
            }
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            string stk = Inputtaikhoan.Text.Trim();
            string ten = Inputten.Text.Trim();
            string diaChi = Inputdiachi.Text.Trim();

            if (stk == "" ||
                ten == "" ||
                diaChi == "" ||
                Inputsotk.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!double.TryParse(Inputsotk.Text, out double soTien))
            {
                MessageBox.Show(
                    "Số tiền không hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Inputsotk.Focus();
                return;
            }

            if (SoTaiKhoanDaTonTai(stk))
            {
                MessageBox.Show(
                    "Số tài khoản đã tồn tại!"
                );

                Inputsotk.Focus();
                return;
            }

            ListViewItem item =
                new ListViewItem(
                    (listView1.Items.Count + 1).ToString()
                );

            item.SubItems.Add(stk);
            item.SubItems.Add(ten);
            item.SubItems.Add(diaChi);
            item.SubItems.Add(soTien.ToString());

            listView1.Items.Add(item);

            TinhTongTien();

            button_them.Text = "Thêm";
            button_luu.Enabled = false;

            XoaTextBox();
        }

        private void listView1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                button_xoa.Enabled = false;
                return;
            }

            button_xoa.Enabled = true;

            ListViewItem item =
                listView1.SelectedItems[0];

            Inputtaikhoan.Text =
                item.SubItems[1].Text;

            Inputten.Text =
                item.SubItems[2].Text;

            Inputdiachi.Text =
                item.SubItems[3].Text;

            Inputsotk.Text =
                item.SubItems[4].Text;
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn tài khoản cần xóa!"
                );

                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn xóa không?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                listView1.SelectedItems[0].Remove();

                DanhLaiSTT();
                TinhTongTien();

                button_xoa.Enabled = false;

                XoaTextBox();
            }
        }

        private void DanhLaiSTT()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text =
                    (i + 1).ToString();
            }
        }

        private void TinhTongTien()
        {
            double tong = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                tong += Convert.ToDouble(
                    item.SubItems[4].Text
                );
            }

            Outputtongtien.Text =
                tong.ToString("N0");
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
