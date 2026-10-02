namespace _4dbai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Instance of MangSoNguyen to hold the array data
        private MangSoNguyen mang = new MangSoNguyen();

        // Đọc mảng từ TextBox
        private bool LayMang()
        {
            try
            {
                string[] s = Inputmang.Text.Trim().Split(' ');

                List<int> ds = new List<int>();

                foreach (string item in s)
                {
                    if (item != "")
                    {
                        ds.Add(int.Parse(item));
                    }
                }

                if (ds.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập mảng!");
                    return false;
                }

                mang.DanhSach = ds;

                return true;
            }
            catch
            {
                MessageBox.Show(
                    "Mảng chỉ được nhập số nguyên!\nVí dụ: 5 6 4 7 8 9",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

        private void HienThiMang()
        {
            Outputmang.Text = string.Join(" ", mang.DanhSach);
        }

        private void button_nhapmang_Click(object sender, EventArgs e)
        {
            if (Inputmang.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập mảng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Inputmang.Focus();
                return;
            }

            try
            {
                string[] s = Inputmang.Text.Trim().Split(' ');

                List<int> ds = new List<int>();

                foreach (string item in s)
                {
                    if (item != "")
                    {
                        ds.Add(int.Parse(item));
                    }
                }

                mang.DanhSach = ds;

                Outputmang.Text = string.Join(" ", mang.DanhSach);
            }
            catch
            {
                MessageBox.Show(
                    "Mảng chỉ được nhập số nguyên!\nVí dụ: 5 6 4 7 8 9",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void button_thuchien_Click(object sender, EventArgs e)
        {
            // Sắp xếp tăng
            if (radioButton_tang.Checked)
            {
                mang.SapXepTang();
                HienThiMang();
            }

            // Sắp xếp giảm
            else if (radioButton_giam.Checked)
            {
                mang.SapXepGiam();
                HienThiMang();
            }

            // Tìm giá trị
            else if (radioButton_giatritim.Checked)
            {
                if (!int.TryParse(Inputgiatritim.Text, out int x))
                {
                    MessageBox.Show("Giá trị tìm không hợp lệ!");
                    return;
                }

                int viTri = mang.TimGiaTri(x);

                if (viTri != -1)
                {
                    Outputtim.Text =
                        "Tìm thấy tại vị trí: " + viTri;
                }
                else
                {
                    Outputtim.Text = "Không tìm thấy";
                }
            }

            // Tìm theo vị trí
            if (radioButton_vitritim.Checked)
            {
                if (!int.TryParse(Inputvitritim.Text, out int viTri))
                {
                    MessageBox.Show("Vị trí không hợp lệ!");
                    return;
                }

                if (viTri < 0 || viTri >= mang.DanhSach.Count)
                {
                    MessageBox.Show("Vị trí vượt phạm vi mảng!");
                    return;
                }

                Outputtim.Text = mang.DanhSach[viTri].ToString();
            }
        }

        private void radioButton_giatrithem_Click(object sender, EventArgs e)
        {
            if (!LayMang())
                return;

            if (!int.TryParse(Inputgiatrithem.Text, out int giaTri))
            {
                MessageBox.Show("Giá trị thêm không hợp lệ!");
                return;
            }

            if (!int.TryParse(Inputvitrithem.Text, out int viTri))
            {
                MessageBox.Show("Vị trí thêm không hợp lệ!");
                return;
            }

            if (viTri < 0 || viTri > mang.DanhSach.Count)
            {
                MessageBox.Show("Vị trí thêm không hợp lệ!");
                return;
            }

            mang.Them(giaTri, viTri);

            Inputmang.Text =
                string.Join(" ", mang.DanhSach);

            HienThiMang();
        }

        private void radioButton_giatrixoa_Click(object sender, EventArgs e)
        {
            if (!LayMang())
                return;

            if (!int.TryParse(Inputgiatrixoa.Text, out int x))
            {
                MessageBox.Show("Giá trị cần xóa không hợp lệ!");
                return;
            }

            if (mang.XoaGiaTri(x))
            {
                Inputmang.Text =
                    string.Join(" ", mang.DanhSach);

                HienThiMang();
            }
            else
            {
                MessageBox.Show("Không tìm thấy giá trị cần xóa!");
            }
        }

        private void button_tong_Click(object sender, EventArgs e)
        {
            if (!LayMang())
                return;

            Outputtongmang.Text = mang.Tong().ToString();
            Outputtongchan.Text = mang.TongChan().ToString();
            Outputtongle.Text = mang.TongLe().ToString();
        }

        private void button_tim_Click(object sender, EventArgs e)
        {
            if (!LayMang())
                return;

            Outputmax.Text = mang.Max().ToString();
            Outputmin.Text = mang.Min().ToString();
        }

        private void radioButton_giatrithay_Click(object sender, EventArgs e)
        {
            if (!LayMang())
                return;

            if (!int.TryParse(
                Inputgiatrithay.Text,
                out int giaTriCu))
            {
                MessageBox.Show("Giá trị cần thay không hợp lệ!");
                return;
            }

            if (!int.TryParse(
                Inputsothaythe.Text,
                out int giaTriMoi))
            {
                MessageBox.Show("Giá trị thay thế không hợp lệ!");
                return;
            }

            if (mang.ThayThe(giaTriCu, giaTriMoi))
            {
                Inputmang.Text =
                    string.Join(" ", mang.DanhSach);

                HienThiMang();
            }
            else
            {
                MessageBox.Show("Không tìm thấy giá trị cần thay!");
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            Inputmang.Clear();
            Outputmang.Clear();

            Inputgiatritim.Clear();
            Inputvitritim.Clear();
            Outputtim.Clear();

            Inputgiatrithem.Clear();
            Inputvitrithem.Clear();

            Inputgiatrixoa.Clear();
            Inputvitrixoa.Clear();

            Outputtongmang.Clear();
            Outputtongchan.Clear();
            Outputtongle.Clear();

            Outputmax.Clear();
            Outputmin.Clear();

            Inputgiatrithay.Clear();
            Inputvitrithay.Clear();
            Inputsothaythe.Clear();

            radioButton_tang.Checked = false;
            radioButton_giam.Checked = false;
            radioButton_giatritim.Checked = false;
            radioButton_vitritim.Checked = false;

            mang.DanhSach.Clear();

            Inputmang.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
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

        public class MangSoNguyen
        {
            public List<int> DanhSach { get; set; }

            public MangSoNguyen()
            {
                DanhSach = new List<int>();
            }

            public void SapXepTang()
            {
                DanhSach.Sort();
            }

            public void SapXepGiam()
            {
                DanhSach.Sort();
                DanhSach.Reverse();
            }

            public int TimGiaTri(int x)
            {
                return DanhSach.IndexOf(x);
            }

            public void Them(int giaTri, int viTri)
            {
                DanhSach.Insert(viTri, giaTri);
            }

            public bool XoaGiaTri(int x)
            {
                return DanhSach.Remove(x);
            }

            public int Tong()
            {
                int tong = 0;

                foreach (int x in DanhSach)
                {
                    tong += x;
                }

                return tong;
            }

            public int TongChan()
            {
                int tong = 0;

                foreach (int x in DanhSach)
                {
                    if (x % 2 == 0)
                    {
                        tong += x;
                    }
                }

                return tong;
            }

            public int TongLe()
            {
                int tong = 0;

                foreach (int x in DanhSach)
                {
                    if (x % 2 != 0)
                    {
                        tong += x;
                    }
                }

                return tong;
            }

            public int Max()
            {
                int max = DanhSach[0];

                foreach (int x in DanhSach)
                {
                    if (x > max)
                    {
                        max = x;
                    }
                }

                return max;
            }

            public int Min()
            {
                int min = DanhSach[0];

                foreach (int x in DanhSach)
                {
                    if (x < min)
                    {
                        min = x;
                    }
                }

                return min;
            }

            public bool ThayThe(int giaTriCu, int giaTriMoi)
            {
                int viTri = DanhSach.IndexOf(giaTriCu);

                if (viTri == -1)
                {
                    return false;
                }

                DanhSach[viTri] = giaTriMoi;

                return true;
            }
        }
    }
}
