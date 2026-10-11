using Microsoft.VisualBasic;
namespace _5cbaitapnangcao
{
    public partial class Form1 : Form
    {
        Random rd = new Random();

        string[] HO =
        {
            "Lê", "Nguyễn", "Lý", "Trần",
            "Lâm", "Hồ", "Lai", "Huỳnh", "La"
        };

        string[] TENLOT =
        {
            "Quang", "Thành", "Ngọc", "Anh",
            "Xuân", "Bảo", "Cẩm", "Thị",
            "Kim", "Thái", "Hồng"
        };

        string[] TEN =
        {
            "Hà", "Danh", "Sơn", "Mai",
            "Thắng", "Kỳ", "Thành", "Lâm",
            "Tâm", "Phụng", "Thắm"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ngaunhien_Click(object sender, EventArgs e)
        {
            list_ten.Items.Clear();

            for (int i = 0; i < 50; i++)
            {
                string ho = HO[rd.Next(HO.Length)];
                string tenLot = TENLOT[rd.Next(TENLOT.Length)];
                string ten = TEN[rd.Next(TEN.Length)];

                string hoTen = ho + " " + tenLot + " " + ten;

                list_ten.Items.Add(hoTen);
            }
        }

        private void button_xoadangchon_Click(object sender, EventArgs e)
        {
            if (list_ten.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tên cần xóa!");
                return;
            }

            list_ten.Items.RemoveAt(list_ten.SelectedIndex);
        }

        private void button_xoatenson_Click(object sender, EventArgs e)
        {
            for (int i = list_ten.Items.Count - 1; i >= 0; i--)
            {
                string hoTen = list_ten.Items[i].ToString();

                string[] tach = hoTen.Split(' ');

                string ten = tach[tach.Length - 1];

                if (ten.Equals(
                    "Sơn",
                    StringComparison.OrdinalIgnoreCase))
                {
                    list_ten.Items.RemoveAt(i);
                }
            }
        }

        private void button_xoahole_Click(object sender, EventArgs e)
        {
            for (int i = list_ten.Items.Count - 1; i >= 0; i--)
            {
                string hoTen = list_ten.Items[i].ToString();

                string[] tach = hoTen.Split(' ');

                string ho = tach[0];

                if (ho.Equals(
                    "Lê",
                    StringComparison.OrdinalIgnoreCase))
                {
                    list_ten.Items.RemoveAt(i);
                }
            }
        }

        private void button_chuhoa_Click(object sender, EventArgs e)
        {
            if (list_ten.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn tên");
                return;
            }

            int vt = list_ten.SelectedIndex;

            string tenCu = list_ten.Items[vt]!.ToString()!;
            string tenMoi = tenCu.ToUpper();

            list_ten.Items.RemoveAt(vt);
            list_ten.Items.Insert(vt, tenMoi);

            list_ten.SelectedIndex = vt;
        }

        private void button_chuthuong_Click(object sender, EventArgs e)
        {
            if (list_ten.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn tên");
                return;
            }

            int vt = list_ten.SelectedIndex;

            string tenCu = list_ten.Items[vt]!.ToString()!;
            string tenMoi = tenCu.ToLower();

            MessageBox.Show(
                "Cũ: " + tenCu +
                "\nMới: " + tenMoi
            );

            list_ten.Items.RemoveAt(vt);
            list_ten.Items.Insert(vt, tenMoi);
            list_ten.SelectedIndex = vt;
        }

        private void button_viethoamoitudau_Click(object sender, EventArgs e)
        {
            if (list_ten.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn tên");
                return;
            }

            int vt = list_ten.SelectedIndex;

            string tenCu = list_ten.Items[vt]!.ToString()!.ToLower();

            string[] tach = tenCu.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries
            );

            for (int i = 0; i < tach.Length; i++)
            {
                tach[i] =
                    char.ToUpper(tach[i][0]) +
                    tach[i].Substring(1);
            }

            string tenMoi = string.Join(" ", tach);

            list_ten.Items.RemoveAt(vt);
            list_ten.Items.Insert(vt, tenMoi);

            list_ten.SelectedIndex = vt;
        }

        private void button_xoatatca_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có muốn xóa tất cả không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                list_ten.Items.Clear();
            }
        }
        private void list_ten_DoubleClick(object sender, EventArgs e)
        {
            if (list_ten.SelectedIndex == -1)
                return;

            int viTri = list_ten.SelectedIndex;

            string tenCu = list_ten.SelectedItem.ToString();

            string tenMoi = Interaction.InputBox(
                "Nhập tên mới:",
                "Thay đổi tên",
                tenCu
            );

            if (tenMoi.Trim() != "")
            {
                list_ten.Items[viTri] = tenMoi.Trim();
            }
        }
    }
}
