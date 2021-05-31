using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TraCuuMaChungKhoan
{
    public partial class AddCode : Form
    {
        string storageFolder = @"E:\\LuuTruMaChungKhoan";
        public AddCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddCode_Load(object sender, EventArgs e)
        {

        }

        private void bt_checkCode_Click(object sender, EventArgs e)
        {
            string code = tb_code.Text;
            if (String.IsNullOrEmpty(code))
            {
                lb_resultCheckCode.Visible = true;
                lb_resultCheckCode.Text = "Mã code không được để trống";
                return;
            }
            if (CheckCode(code))
            {
                lb_resultCheckCode.Visible = true;
                lb_resultCheckCode.Text = "Mã Code đã tồn tại";
            }
            else
            {
                lb_resultCheckCode.Visible = true;
                lb_resultCheckCode.Text = "Mã Code hợp lệ";
                bt_save.Enabled = true;
            }
        }

        private bool CheckCode(string code)
        {
            String[] subfolder = Directory.GetDirectories(storageFolder);
            bool checkExist = false;
            foreach (var item in subfolder)
            {
                DirectoryInfo d = new DirectoryInfo(item);
                if (d.Name.ToLower().Equals(code.ToLower()))
                {
                    checkExist = true;
                    break;
                }

            }
            return checkExist;
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            lb_resultCheckCode.Visible = false;
            tb_code.Text = "";
            tb_Description.Text = "";
            flowLO_btPicture.Controls.Clear();
            bt_save.Enabled = false;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string code = tb_code.Text;
            string description = tb_Description.Text;
            if (!Directory.Exists(Path.Combine(storageFolder, code)))
            {
                Directory.CreateDirectory(Path.Combine(storageFolder, code));
            }
            // Create the file, or overwrite if the file exists.
            using (FileStream fs = File.Create(Path.Combine(storageFolder, code, "description.txt")))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(description);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            MessageBox.Show("Lưu mã code " + code + " thành công");
        }
    }
}
