using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _5dbaitapvenhabai2
{
    public partial class FormBai1TaiLop : Form
    {
        public FormBai1TaiLop()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_dantoc.Items.Add("Kinh");
            comboBox_dantoc.Items.Add("Hoa");
            comboBox_dantoc.Items.Add("K'Me");
            comboBox_dantoc.Items.Add("H'Mong");
            comboBox_dantoc.Items.Add("Khác");

            comboBox_dantoc.SelectedIndex = 0;

            radioButton_Nam.Checked = true;

            Inputhoten.Focus();
        }

        private bool MaSVDaTonTai(string maSV)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text.Equals(
                    maSV,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private string LayGioiTinh()
        {
            if (radioButton_Nam.Checked)
                return "Nam";

            return "Nữ";
        }

        private string LayNgoaiNgu()
        {
            List<string> ds = new List<string>();

            if (chkBox_Anh.Checked)
                ds.Add("Anh");

            if (chkBox_Phap.Checked)
                ds.Add("Pháp");

            if (chkBox_Hoa.Checked)
                ds.Add("Hoa");

            return string.Join(", ", ds);
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            string hoTen = Inputhoten.Text.Trim();
            string maSV = Inputmasv.Text.Trim();

            if (hoTen == "")
            {
                MessageBox.Show(
                    "Họ tên không được để trống!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Inputhoten.Focus();
                return;
            }

            if (maSV == "")
            {
                MessageBox.Show(
                    "Mã sinh viên không được để trống!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Inputmasv.Focus();
                return;
            }

            if (MaSVDaTonTai(maSV))
            {
                MessageBox.Show(
                    "Mã sinh viên đã tồn tại!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Inputmasv.SelectAll();
                Inputmasv.Focus();
                return;
            }

            string gioiTinh = LayGioiTinh();
            string ngoaiNgu = LayNgoaiNgu();
            string danToc = comboBox_dantoc.Text;

            ListViewItem item =
                new ListViewItem(hoTen);

            item.SubItems.Add(maSV);
            item.SubItems.Add(gioiTinh);
            item.SubItems.Add(ngoaiNgu);
            item.SubItems.Add(danToc);

            listView1.Items.Add(item);

            XoaDuLieuNhap();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            XoaSinhVien();
        }

        private void XoaSinhVien()
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần xóa!"
                );

                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                listView1.SelectedItems[0].Remove();

                XoaDuLieuNhap();
            }
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVien();
        }

        private void listView1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item =
                listView1.SelectedItems[0];

            Inputhoten.Text =
                item.SubItems[0].Text;

            Inputmasv.Text =
                item.SubItems[1].Text;

            string gioiTinh =
                item.SubItems[2].Text;

            radioButton_Nam.Checked =
                gioiTinh == "Nam";

            radioButton_Nu.Checked =
                gioiTinh == "Nữ";

            string ngoaiNgu =
                item.SubItems[3].Text;

            chkBox_Anh.Checked =
                ngoaiNgu.Contains("Anh");

            chkBox_Phap.Checked =
                ngoaiNgu.Contains("Pháp");

            chkBox_Hoa.Checked =
                ngoaiNgu.Contains("Hoa");

            comboBox_dantoc.Text =
                item.SubItems[4].Text;

            // Không cho sửa mã sinh viên
            Inputmasv.ReadOnly = true;
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần sửa!"
                );

                return;
            }

            if (Inputhoten.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Họ tên không được để trống!"
                );

                return;
            }

            ListViewItem item =
                listView1.SelectedItems[0];

            // Chỉ sửa các thông tin khác
            // KHÔNG sửa mã sinh viên
            item.SubItems[0].Text =
                Inputhoten.Text.Trim();

            item.SubItems[2].Text =
                LayGioiTinh();

            item.SubItems[3].Text =
                LayNgoaiNgu();

            item.SubItems[4].Text =
                comboBox_dantoc.Text;

            MessageBox.Show(
                "Sửa thông tin thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            XoaDuLieuNhap();
        }

        private void XoaDuLieuNhap()
        {
            Inputhoten.Clear();
            Inputmasv.Clear();

            Inputmasv.ReadOnly = false;

            radioButton_Nam.Checked = true;

            chkBox_Anh.Checked = false;
            chkBox_Phap.Checked = false;
            chkBox_Hoa.Checked = false;

            if (comboBox_dantoc.Items.Count > 0)
                comboBox_dantoc.SelectedIndex = 0;

            Inputhoten.Focus();
        }

        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình không?",
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
