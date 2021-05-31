using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TraCuuMaChungKhoan
{
    public partial class Form1 : Form
    {

        string storageFolder = @"E:\\LuuTruMaChungKhoan";

        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(storageFolder))
            {
                Directory.CreateDirectory(storageFolder);
            }
        }

        private void bt_AddCode_Click(object sender, EventArgs e)
        {
            AddCode addCode = new AddCode();
            addCode.ShowDialog();
        }

        private void bt_findCode_Click(object sender, EventArgs e)
        {
            ResetPage();

            string code = tb_code.Text;
            if (String.IsNullOrEmpty(code))
            {
                lb_resultFind.Visible = true;
                lb_resultFind.Text = "Mã code không được để trống";
                return;
            }
            String[] subfolder = Directory.GetDirectories(storageFolder);
            bool checkExist = false;
            foreach (var item in subfolder)
            {
                DirectoryInfo d = new DirectoryInfo(item);
                if (d.Name.ToLower().Equals(code.ToLower()))
                {
                    checkExist = true;
                    FileInfo[] files = d.GetFiles("description.txt"); //Getting Text files
                    if (files.Length != 0)
                    {
                        string des = File.ReadAllText(files[0].FullName);
                        tb_Description.Text = des;
                        break;
                    }
                    else
                    {
                        // Create the file, or overwrite if the file exists.
                        using (FileStream fs = File.Create(Path.Combine(d.FullName, "description.txt")))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes("");
                            // Add some information to the file.
                            fs.Write(info, 0, info.Length);
                        }
                    }
                }

            }
            if (!checkExist)
            {
                lb_resultFind.Visible = true;
                lb_resultFind.Text = "Không tìm thấy mã";
            }
            else
            {
                bt_save.Enabled = true;
                bt_changePicture.Enabled = true;
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string code = tb_code.Text;
            string description = tb_Description.Text;
            // Create the file, or overwrite if the file exists.
            using (FileStream fs = File.Create(Path.Combine(storageFolder, code, "description.txt")))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(description);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
            MessageBox.Show("Lưu mã code " + code + " thành công");
        }

        private void ResetPage()
        {
            tb_Description.Text = "";
            bt_changePicture.Enabled = false;
            bt_save.Enabled = false;
            lb_resultFind.Visible = false;
        }
    }
}
