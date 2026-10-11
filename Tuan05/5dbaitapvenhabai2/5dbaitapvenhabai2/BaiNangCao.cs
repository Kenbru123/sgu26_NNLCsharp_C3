namespace _5dbaitapvenhabai2
{
    public partial class FormBaiNangCao : Form
    {
        public FormBaiNangCao()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listlopA.Items.Add("Trần Hùng");
            listlopA.Items.Add("Nguyễn Hưng");
            listlopA.Items.Add("Lâm Tử");

            listlopB.Items.Add("Tuấn Hưng");
            listlopB.Items.Add("Hồng Ngọc");
            listlopB.Items.Add("Ánh Minh");
            listlopB.Items.Add("Bảo Lâm");
        }

        private void mnuSangLopB_Click(object sender, EventArgs e)
        {
            if (listlopA.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn học viên ở lớp A!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            List<object> dsChon = new List<object>();

            foreach (object item in listlopA.SelectedItems)
            {
                dsChon.Add(item);
            }

            foreach (object item in dsChon)
            {
                listlopB.Items.Add(item);
                listlopA.Items.Remove(item);
            }
        }

        private void mnuSangLopA_Click(object sender, EventArgs e)
        {
            if (listlopB.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn học viên ở lớp B!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            List<object> dsChon = new List<object>();

            foreach (object item in listlopB.SelectedItems)
            {
                dsChon.Add(item);
            }

            foreach (object item in dsChon)
            {
                listlopA.Items.Add(item);
                listlopB.Items.Remove(item);
            }
        }

        private void mnuXoaHocVien_Click(object sender, EventArgs e)
        {
            if (listlopA.SelectedItems.Count == 0 &&
                listlopB.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn học viên cần xóa!"
                );

                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn xóa học viên đang chọn không?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
                return;

            List<object> dsA = new List<object>();

            foreach (object item in listlopA.SelectedItems)
            {
                dsA.Add(item);
            }

            foreach (object item in dsA)
            {
                listlopA.Items.Remove(item);
            }

            List<object> dsB = new List<object>();

            foreach (object item in listlopB.SelectedItems)
            {
                dsB.Add(item);
            }

            foreach (object item in dsB)
            {
                listlopB.Items.Remove(item);
            }
        }

        private void mnuNhapHocVien_Click(object sender, EventArgs e)
        {
            FormNhapHocVien frm = new FormNhapHocVien(this);
            frm.ShowDialog();
        }

        public void ThemHocVien(string hoTen, string lop)
        {
            if (lop == "Lớp A")
            {
                listlopA.Items.Add(hoTen);
            }
            else
            {
                listlopB.Items.Add(hoTen);
            }
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn kết thúc chương trình không?",
                "Kết thúc",
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
