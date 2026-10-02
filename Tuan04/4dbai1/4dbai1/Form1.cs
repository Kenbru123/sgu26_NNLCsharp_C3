namespace _4dbai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_giai.Enabled = false;
            Inputc.Enabled = false;
            Outputketqua.ReadOnly = true;

            Inputa.Focus();
        }

        private void radiobutton_bacnhat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_bacnhat.Checked)
            {
                Inputc.Clear();
                Inputc.Enabled = false;
                Outputketqua.Clear();

                KiemTraDuLieu();
            }
        }

        private void radiobutton_bachai_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_bachai.Checked)
            {
                Inputc.Enabled = true;
                Outputketqua.Clear();

                KiemTraDuLieu();
            }
        }

        private void txtDuLieu_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void KiemTraDuLieu()
        {
            if (radioButton_bacnhat.Checked)
            {
                button_giai.Enabled =
                    Inputa.Text.Trim() != "" &&
                    Inputb.Text.Trim() != "";
            }
            else if (radioButton_bachai.Checked)
            {
                button_giai.Enabled =
                    Inputa.Text.Trim() != "" &&
                    Inputb.Text.Trim() != "" &&
                    Inputc.Text.Trim() != "";
            }
            else
            {
                button_giai.Enabled = false;
            }
        }

        private void button_giai_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(Inputa.Text, out double a))
            {
                MessageBox.Show("Hệ số a không hợp lệ!");
                Inputa.Focus();
                return;
            }

            if (!double.TryParse(Inputb.Text, out double b))
            {
                MessageBox.Show("Hệ số b không hợp lệ!");
                Inputb.Focus();
                return;
            }

            double c = 0;

            if (radioButton_bachai.Checked)
            {
                if (!double.TryParse(Inputc.Text, out c))
                {
                    MessageBox.Show("Hệ số c không hợp lệ!");
                    Inputc.Focus();
                    return;
                }
            }

            PhuongTrinhBacHai pt =
                new PhuongTrinhBacHai(a, b, c);

            if (radioButton_bacnhat.Checked)
            {
                Outputketqua.Text = pt.GiaiBacNhat();
            }
            else if (radioButton_bachai.Checked)
            {
                Outputketqua.Text = pt.GiaiBacHai();
            }

            button_giai.Enabled = false;
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
    public class PhuongTrinhBacHai
    {
        private double a;
        private double b;
        private double c;

        public PhuongTrinhBacHai(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string GiaiBacNhat()
        {
            if (a == 0)
            {
                if (b == 0)
                    return "Phương trình vô số nghiệm";
                else
                    return "Phương trình vô nghiệm";
            }

            double x = -b / a;
            return "Phương trình có nghiệm x = " + x;
        }

        public string GiaiBacHai()
        {
            if (a == 0)
            {
                return GiaiBacNhat();
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                return "Phương trình vô nghiệm";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return "Phương trình có nghiệm kép x = " + x;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                return "x1 = " + x1 + "\r\n"
                     + "x2 = " + x2;
            }
        }
    }
}