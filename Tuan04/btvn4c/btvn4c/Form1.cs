namespace btvn4c
{
    public partial class Form1 : Form
    {
        double soThuNhat = 0;
        string phepTinh = "";
        bool nhapSoMoi = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (nhapSoMoi)
            {
                Input.Clear();
                nhapSoMoi = false;
            }

            Input.Text += btn.Text;
        }
        private void bbutton_cong_Click(object sender, EventArgs e)
        {
            ChonPhepTinh("+");
        }
        private void button_tru_Click(object sender, EventArgs e)
        {
            ChonPhepTinh("-");
        }
        private void button_nhan_Click(object sender, EventArgs e)
        {
            ChonPhepTinh("*");
        }
        private void button_chia_Click(object sender, EventArgs e)
        {
            ChonPhepTinh("/");
        }

        private void ChonPhepTinh(string phep)
        {
            if (Input.Text == "")
                return;

            soThuNhat = double.Parse(Input.Text);

            phepTinh = phep;

            nhapSoMoi = true;
        }

        private void button_bang_Click(object sender, EventArgs e)
        {
            if (Input.Text == "" || phepTinh == "")
                return;

            double soThuHai = double.Parse(Input.Text);
            double ketQua = 0;

            switch (phepTinh)
            {
                case "+":
                    ketQua = soThuNhat + soThuHai;
                    break;

                case "-":
                    ketQua = soThuNhat - soThuHai;
                    break;

                case "*":
                    ketQua = soThuNhat * soThuHai;
                    break;

                case "/":
                    if (soThuHai == 0)
                    {
                        MessageBox.Show(
                            "Không thể chia cho 0!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                    }

                    ketQua = soThuNhat / soThuHai;
                    break;
            }

            Input.Text = ketQua.ToString();

            phepTinh = "";
            nhapSoMoi = true;
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            Input.Clear();

            soThuNhat = 0;
            phepTinh = "";
            nhapSoMoi = false;
        }
    }
}
