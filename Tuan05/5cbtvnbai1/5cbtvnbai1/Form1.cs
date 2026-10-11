namespace _5cbtvnbai1
{
    public partial class Form1 : Form
    {
        List<TuDien> danhSachTu = new List<TuDien>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Dữ liệu mẫu
            danhSachTu.Add(new TuDien("student", "sinh viên, học sinh"));
            danhSachTu.Add(new TuDien("teacher", "giáo viên"));
            danhSachTu.Add(new TuDien("worker", "công nhân"));
            danhSachTu.Add(new TuDien("hat", "cái nón"));
            danhSachTu.Add(new TuDien("head", "cái đầu"));
            danhSachTu.Add(new TuDien("mouse", "con chuột"));
            danhSachTu.Add(new TuDien("cat", "con mèo"));
            danhSachTu.Add(new TuDien("dog", "con chó"));
            danhSachTu.Add(new TuDien("snake", "con rắn"));
            danhSachTu.Add(new TuDien("lamb", "con cừu"));
            danhSachTu.Add(new TuDien("loan", "khoản vay"));
            danhSachTu.Add(new TuDien("frog", "con ếch"));
            danhSachTu.Add(new TuDien("sheep", "con cừu"));

            LoadDuLieu();

            Outputdich.ReadOnly = true;
        }

        private void LoadDuLieu()
        {
            comboBox_Anh.Items.Clear();

            AutoCompleteStringCollection dsAnh =
                new AutoCompleteStringCollection();

            AutoCompleteStringCollection dsViet =
                new AutoCompleteStringCollection();

            foreach (TuDien tu in danhSachTu)
            {
                comboBox_Anh.Items.Add(tu.TiengAnh);

                dsAnh.Add(tu.TiengAnh);
                dsViet.Add(tu.TiengViet);
            }

            // Tự động dò từ khi gõ
            comboBox_Anh.AutoCompleteMode =
                AutoCompleteMode.SuggestAppend;

            comboBox_Anh.AutoCompleteSource =
                AutoCompleteSource.CustomSource;

            comboBox_Anh.AutoCompleteCustomSource = dsAnh;

        }
        private void TraAnhViet()
        {
            string tuCanTra =
                comboBox_Anh.Text.Trim();

            foreach (TuDien tu in danhSachTu)
            {
                if (string.Compare(
                    tu.TiengAnh,
                    tuCanTra,
                    true) == 0)
                {
                    Outputdich.Text =
                        tu.TiengViet;

                    return;
                }
            }

            Outputdich.Text =
                "Không tìm thấy từ!";
        }

        private void comboBox_Anh_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TraAnhViet();
            }
        }

        private void comboBox_Anh_DoubleClick(
            object sender,
            EventArgs e)
        {
            TraAnhViet();
        }

        private void button_thoat_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult r =
                MessageBox.Show(
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

        public class TuDien
        {
            public string TiengAnh { get; set; }

            public string TiengViet { get; set; }

            public TuDien(
                string tiengAnh,
                string tiengViet)
            {
                TiengAnh = tiengAnh;
                TiengViet = tiengViet;
            }
        }
    }
}
