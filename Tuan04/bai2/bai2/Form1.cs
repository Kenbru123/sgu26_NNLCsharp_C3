namespace bai2
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        private bool KiemTraRong()
        {
            errorProvider1.Clear();

            bool hopLe = true;

            if (Inputdangnhap.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    Inputdangnhap,
                    "Tên đăng nhập không được để trống"
                );

                hopLe = false;
            }

            if (Inputdiachiaemail.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    Inputdiachiaemail,
                    "Email không được để trống"
                );

                hopLe = false;
            }

            if (Inputmatkhau.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    Inputmatkhau,
                    "Mật khẩu không được để trống"
                );

                hopLe = false;
            }

            return hopLe;
        }
        private void Inputdiachiemail_Leave(object sender, EventArgs e)
        {
            string email = Inputdiachiaemail.Text.Trim();

            if (email == "")
            {
                errorProvider1.SetError(
                    Inputdiachiaemail,
                    "Email không được để trống"
                );
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                errorProvider1.SetError(
                    Inputdiachiaemail,
                    "Email không đúng định dạng"
                );
            }
            else
            {
                errorProvider1.SetError(Inputdiachiaemail, "");
            }
        }
        private void button_register_Click(object sender, EventArgs e)
        {
            if (!KiemTraRong())
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (Inputmatkhau.Text != Inputxacnhan.Text)
            {
                errorProvider1.SetError(
                    Inputxacnhan,
                    "Mật khẩu xác nhận không khớp"
                );

                MessageBox.Show(
                    "Mật khẩu xác nhận không khớp!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            string s = "";

            s += "Tên đăng nhập: " + Inputdangnhap.Text + "\n";
            s += "Email: " + Inputdiachiaemail.Text + "\n";
            s += "Mật khẩu: " + Inputmatkhau.Text + "\n";
            s += "Xác nhận mật khẩu: " + Inputxacnhan.Text;

            MessageBox.Show(
                s,
                "Thông tin đăng ký",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private void Inputxacnhan_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_register.PerformClick();
            }
        }

        private void bai2_FormClosing(
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
