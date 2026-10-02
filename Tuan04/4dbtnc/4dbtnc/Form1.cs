namespace _4dbtnc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tongKhach = 0;
        double tongTien = 0;
        double tienHienTai = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Inputten.Focus();

            button_tinhtien.Enabled = false;
            button_nhaplai.Enabled = false;
            button_thanhtoan.Enabled = false;

            Outputkhachhang.ReadOnly = true;
            Outputthanhtoan.ReadOnly = true;
        }

        private void KiemTraDuLieu()
        {
            bool coTen = Inputten.Text.Trim() != "";

            bool coSoKhach =
                int.TryParse(Inputso.Text, out int soKhach)
                && soKhach > 0;

            bool coCafe =
                radioButton_cfden.Checked ||
                radioButton_cfda.Checked ||
                radioButton_cfsua.Checked ||
                radioButton_cfsuada.Checked ||
                radioButton_cfkem.Checked;

            button_tinhtien.Enabled =
                coTen && coSoKhach && coCafe;
        }

        private void txtDuLieu_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void LuaChon_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void Inputso_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private double TinhGiaCafe()
        {
            if (radioButton_cfden.Checked)
                return 20000;

            if (radioButton_cfda.Checked)
                return 25000;

            if (radioButton_cfsua.Checked)
                return 25000;

            if (radioButton_cfsuada.Checked)
                return 30000;

            if (radioButton_cfkem.Checked)
                return 35000;

            return 0;
        }

        private double TinhGiaThucAn()
        {
            double tien = 0;

            if (chkBanhMiTrung.Checked)
                tien += 15000;

            if (chkBanhMiCa.Checked)
                tien += 15000;

            if (chkMiTomTrung.Checked)
                tien += 20000;

            if (chkMyXaoBo.Checked)
                tien += 30000;

            if (chkMyCay.Checked)
                tien += 50000;

            return tien;
        }

        private void button_tinhtien_Click(object sender, EventArgs e)
        {
            if (Inputten.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống!");
                return;
            }

            if (!int.TryParse(Inputso.Text, out int soKhach)
                || soKhach <= 0)
            {
                MessageBox.Show("Số khách không hợp lệ!");
                return;
            }

            double tienCafe = TinhGiaCafe();
            double tienThucAn = TinhGiaThucAn();

            // Mỗi khách dùng một phần lựa chọn hiện tại
            tienHienTai =
                (tienCafe + tienThucAn) * soKhach;

            // Sinh viên giảm 20%
            if (chkSinhVien.Checked)
            {
                tienHienTai = tienHienTai * 0.8;
            }

            MessageBox.Show(
                "Khách hàng: " + Inputten.Text + "\n"
                + "Số khách: " + soKhach + "\n"
                + "Thành tiền: "
                + tienHienTai.ToString("N0") + " VNĐ",
                "Tính tiền",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            button_tinhtien.Enabled = false;
            button_nhaplai.Enabled = true;
            button_thanhtoan.Enabled = true;
        }

        private void button_thanhtoan_Click(object sender, EventArgs e)
        {
            int soKhach = int.Parse(Inputso.Text);

            tongKhach += soKhach;
            tongTien += tienHienTai;

            Outputkhachhang.Text = tongKhach.ToString();
            Outputthanhtoan.Text =
                tongTien.ToString("N0") + " VNĐ";

            button_thanhtoan.Enabled = false;
        }

        private void button_nhaplai_Click(object sender, EventArgs e)
        {
            Inputten.Clear();
            Inputso.Clear();

            chkSinhVien.Checked = false;

            radioButton_cfden.Checked = false;
            radioButton_cfda.Checked = false;
            radioButton_cfsua.Checked = false;
            radioButton_cfsuada.Checked = false;
            radioButton_cfkem.Checked = false;

            chkBanhMiTrung.Checked = false;
            chkBanhMiCa.Checked = false;
            chkMiTomTrung.Checked = false;
            chkMyXaoBo.Checked = false;
            chkMyCay.Checked = false;

            tienHienTai = 0;

            button_tinhtien.Enabled = false;
            button_nhaplai.Enabled = false;
            button_thanhtoan.Enabled = false;

            Inputten.Focus();
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
