namespace _5cbtvnbai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView_danhba.Nodes.Clear();

            // Tạo các node từ A -> Z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                treeView_danhba.Nodes.Add(c.ToString());
            }

            Inputfirst.Focus();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string firstName = Inputfirst.Text.Trim();
            string lastName = Inputlast.Text.Trim();

            if (firstName == "" || lastName == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ First Name và Last Name!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            char chuCaiDau =
                char.ToUpper(firstName[0]);

            if (chuCaiDau < 'A' || chuCaiDau > 'Z')
            {
                MessageBox.Show(
                    "Tên phải bắt đầu bằng chữ cái A đến Z!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Inputfirst.Focus();
                return;
            }

            foreach (TreeNode node in treeView_danhba.Nodes)
            {
                if (node.Text == chuCaiDau.ToString())
                {
                    string hoTen =
                        firstName + ", " + lastName;

                    node.Nodes.Add(hoTen);

                    node.Expand();

                    break;
                }
            }

            Inputfirst.Clear();
            Inputlast.Clear();

            Inputfirst.Focus();
        }

        private void button_exit_Click(object sender, EventArgs e)
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
}
