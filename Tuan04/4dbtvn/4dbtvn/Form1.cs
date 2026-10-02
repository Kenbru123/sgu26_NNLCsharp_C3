namespace _4dbtvn
{
    public partial class Form1 : Form
    {
        int tongSoKhach = 0;
        double tongTien = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inputhoten.Focus();

            button_thanhtoan.Enabled = false;
            button_nhapmoi.Enabled = false;
            button_tongket.Enabled = false;

            Outputthanhtien.ReadOnly = true;
            Outputsoluot.ReadOnly = true;
            Outputtongtien.ReadOnly = true;
        }

        private void KiemTraDuLieu()
        {
            bool coTen = Inputhoten.Text.Trim() != "";
            bool coDiaChi = Inputdiachi.Text.Trim() != "";

            bool coSoNgay =
                int.TryParse(Inputsongay.Text, out int soNgay)
                && soNgay > 0;

            bool coLoaiPhong =
                radioButton_phongdon.Checked ||
                radioButton_phongdoi.Checked ||
                radioButton_phongba.Checked;

            button_thanhtoan.Enabled =
                coTen &&
                coDiaChi &&
                coSoNgay &&
                coLoaiPhong;
        }

        private void txtDuLieu_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void radioPhong_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void Inputsongay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private double TinhTienPhong(int soNgay)
        {
            if (radioButton_phongdon.Checked)
                return 300000 * soNgay;

            if (radioButton_phongdoi.Checked)
                return 350000 * soNgay;

            if (radioButton_phongba.Checked)
                return 400000 * soNgay;

            return 0;
        }

        private double TinhTienTienNghi()
        {
            double tien = 0;

            if (chkTivi.Checked)
                tien += 10000;

            if (chkInternet.Checked)
                tien += 10000;

            if (chkMaynuocnong.Checked)
                tien += 10000;

            return tien;
        }

        private double TinhTienDichVu(int soNgay)
        {
            double tien = 0;

            if (chkKaraoke.Checked)
                tien += 50000;

            if (chkAnsang.Checked)
                tien += 15000 * soNgay;

            return tien;
        }

        private void button_thanhtoan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Inputsongay.Text, out int soNgay) || soNgay <= 0)
            {
                MessageBox.Show(
                    "Số ngày ở không hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            double tienPhong = TinhTienPhong(soNgay);
            double tienTienNghi = TinhTienTienNghi();
            double tienDichVu = TinhTienDichVu(soNgay);

            double thanhTien =
                tienPhong +
                tienTienNghi +
                tienDichVu;

            Outputthanhtien.Text =
                thanhTien.ToString("N0") + " VNĐ";

            tongSoKhach++;
            tongTien += thanhTien;

            button_thanhtoan.Enabled = false;
            button_nhapmoi.Enabled = true;
            button_tongket.Enabled = true;
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            Inputhoten.Clear();
            Inputdiachi.Clear();
            Inputsongay.Clear();
            Outputthanhtien.Clear();

            radioButton_phongdon.Checked = false;
            radioButton_phongdoi.Checked = false;
            radioButton_phongba.Checked = false;

            chkTivi.Checked = false;
            chkInternet.Checked = false;
            chkMaynuocnong.Checked = false;

            chkKaraoke.Checked = false;
            chkAnsang.Checked = false;

            button_thanhtoan.Enabled = false;
            button_nhapmoi.Enabled = false;

            Inputhoten.Focus();
        }

        private void button_tong_Click(object sender, EventArgs e)
        {
            Outputsoluot.Text =
                tongSoKhach.ToString();

            Outputtongtien.Text =
                tongTien.ToString("N0") + " VNĐ";

            tongSoKhach = 0;
            tongTien = 0;

            button_tongket.Enabled = false;
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Thoát",
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
