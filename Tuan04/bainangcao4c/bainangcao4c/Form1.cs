namespace bainangcao4c
{
    public partial class Form1 : Form
    {
        private Button[] dsGhe;
        public Form1()
        {
            InitializeComponent();
            dsGhe = new Button[]
            {
                button1, button2, button3, button4, button5,
                button6, button7, button8, button9,button10,
                button11, button12,button13, button14, button15
            };
            // Gán cùng một sự kiện cho tất cả ghế
            foreach (Button ghe in dsGhe)
            {
                ghe.Click += Ghe_Click;
                ghe.BackColor = Color.White;
            }

            Outputtien.Text = "0";
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            Button ghe = (Button)sender;

            // Ghế chưa bán -> chọn
            if (ghe.BackColor == Color.White)
            {
                ghe.BackColor = Color.Blue;
            }

            // Ghế đang chọn -> bỏ chọn
            else if (ghe.BackColor == Color.Blue)
            {
                ghe.BackColor = Color.White;
            }

            // Ghế đã bán
            else if (ghe.BackColor == Color.Yellow)
            {
                MessageBox.Show(
                    "Ghế này đã được bán!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private int GiaVe(int soGhe)
        {
            if (soGhe >= 1 && soGhe <= 5)
                return 1000;

            if (soGhe >= 6 && soGhe <= 10)
                return 1500;

            return 2000;
        }

        private void button_chon_Click(object sender, EventArgs e)
        {
            int tongTien = 0;

            foreach (Button ghe in dsGhe)
            {
                if (ghe.BackColor == Color.Blue)
                {
                    int soGhe = int.Parse(ghe.Text);

                    tongTien += GiaVe(soGhe);

                    // Chuyển sang trạng thái đã bán
                    ghe.BackColor = Color.Yellow;
                }
            }

            Outputtien.Text = tongTien.ToString();
        }

        // Nút Hủy bỏ
        private void button_huybo_Click(object sender, EventArgs e)
        {
            foreach (Button ghe in dsGhe)
            {
                // Chỉ hủy những ghế đang chọn
                if (ghe.BackColor == Color.Blue)
                {
                    ghe.BackColor = Color.White;
                }
            }

            Outputtien.Text = "0";
        }

        // Nút Kết thúc
        private void button_ketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xác nhận đóng Form
        private void bainangcao4c_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
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
