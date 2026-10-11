namespace _5dbaitapvenhabai1
{
    public partial class FormBTVN1 : Form
    {
        int tongGiay = 30 * 60;
        public FormBTVN1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiThoiGian();
        }
        private void buton_batdau_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button_batdau.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tongGiay > 0)
            {
                tongGiay--;

                HienThiThoiGian();
            }
            else
            {
                timer1.Stop();

                MessageBox.Show(
                    "Hết thời gian!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                button_batdau.Enabled = true;
            }
        }

        private void HienThiThoiGian()
        {
            int phut = tongGiay / 60;
            int giay = tongGiay % 60;

            Tthoigian.Text =
                phut.ToString("00") + ":" +
                giay.ToString("00");
        }
    }
}
