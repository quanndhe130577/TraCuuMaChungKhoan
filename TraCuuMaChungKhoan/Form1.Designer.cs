
namespace TraCuuMaChungKhoan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_AddCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.bt_findCode = new System.Windows.Forms.Button();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLO_btPicture = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_resultFind = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_changePicture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_AddCode
            // 
            this.bt_AddCode.Location = new System.Drawing.Point(638, 24);
            this.bt_AddCode.Name = "bt_AddCode";
            this.bt_AddCode.Size = new System.Drawing.Size(75, 23);
            this.bt_AddCode.TabIndex = 0;
            this.bt_AddCode.Text = "Thêm mã";
            this.bt_AddCode.UseVisualStyleBackColor = true;
            this.bt_AddCode.Click += new System.EventHandler(this.bt_AddCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Code:";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(85, 25);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(166, 23);
            this.tb_code.TabIndex = 2;
            // 
            // bt_findCode
            // 
            this.bt_findCode.Location = new System.Drawing.Point(290, 24);
            this.bt_findCode.Name = "bt_findCode";
            this.bt_findCode.Size = new System.Drawing.Size(75, 23);
            this.bt_findCode.TabIndex = 3;
            this.bt_findCode.Text = "Tìm kiếm";
            this.bt_findCode.UseVisualStyleBackColor = true;
            this.bt_findCode.Click += new System.EventHandler(this.bt_findCode_Click);
            // 
            // tb_Description
            // 
            this.tb_Description.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Description.Location = new System.Drawing.Point(20, 129);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(345, 208);
            this.tb_Description.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Miêu tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hình ảnh:";
            // 
            // flowLO_btPicture
            // 
            this.flowLO_btPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLO_btPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLO_btPicture.Location = new System.Drawing.Point(378, 129);
            this.flowLO_btPicture.Name = "flowLO_btPicture";
            this.flowLO_btPicture.Size = new System.Drawing.Size(335, 208);
            this.flowLO_btPicture.TabIndex = 7;
            // 
            // lb_resultFind
            // 
            this.lb_resultFind.AutoSize = true;
            this.lb_resultFind.Location = new System.Drawing.Point(85, 70);
            this.lb_resultFind.Name = "lb_resultFind";
            this.lb_resultFind.Size = new System.Drawing.Size(47, 15);
            this.lb_resultFind.TabIndex = 8;
            this.lb_resultFind.Text = "Kết quả";
            this.lb_resultFind.Visible = false;
            // 
            // bt_save
            // 
            this.bt_save.Enabled = false;
            this.bt_save.Location = new System.Drawing.Point(545, 24);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 9;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_changePicture
            // 
            this.bt_changePicture.Enabled = false;
            this.bt_changePicture.Location = new System.Drawing.Point(638, 93);
            this.bt_changePicture.Name = "bt_changePicture";
            this.bt_changePicture.Size = new System.Drawing.Size(75, 23);
            this.bt_changePicture.TabIndex = 10;
            this.bt_changePicture.Text = "Đổi ảnh";
            this.bt_changePicture.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 377);
            this.Controls.Add(this.bt_changePicture);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.lb_resultFind);
            this.Controls.Add(this.flowLO_btPicture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.bt_findCode);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_AddCode);
            this.Name = "Form1";
            this.Text = "Tra Cứu Mã Chứng Khoán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_AddCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Button bt_findCode;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLO_btPicture;
        private System.Windows.Forms.Label lb_resultFind;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_changePicture;
    }
}

