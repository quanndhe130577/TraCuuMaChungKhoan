
namespace TraCuuMaChungKhoan
{
    partial class AddCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLO_btPicture = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_addPicture = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_checkCode = new System.Windows.Forms.Button();
            this.lb_resultCheckCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Code:";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(83, 46);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(121, 23);
            this.tb_code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miêu tả:";
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(19, 151);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(346, 236);
            this.tb_Description.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hình ảnh:";
            // 
            // flowLO_btPicture
            // 
            this.flowLO_btPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLO_btPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLO_btPicture.Location = new System.Drawing.Point(391, 151);
            this.flowLO_btPicture.Name = "flowLO_btPicture";
            this.flowLO_btPicture.Size = new System.Drawing.Size(337, 236);
            this.flowLO_btPicture.TabIndex = 5;
            // 
            // bt_addPicture
            // 
            this.bt_addPicture.Location = new System.Drawing.Point(606, 111);
            this.bt_addPicture.Name = "bt_addPicture";
            this.bt_addPicture.Size = new System.Drawing.Size(122, 23);
            this.bt_addPicture.TabIndex = 6;
            this.bt_addPicture.Text = "Thêm hình ảnh";
            this.bt_addPicture.UseVisualStyleBackColor = true;
            this.bt_addPicture.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_save
            // 
            this.bt_save.Enabled = false;
            this.bt_save.Location = new System.Drawing.Point(606, 22);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(122, 47);
            this.bt_save.TabIndex = 7;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(509, 34);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 8;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_checkCode
            // 
            this.bt_checkCode.Location = new System.Drawing.Point(227, 45);
            this.bt_checkCode.Name = "bt_checkCode";
            this.bt_checkCode.Size = new System.Drawing.Size(75, 23);
            this.bt_checkCode.TabIndex = 9;
            this.bt_checkCode.Text = "Kiểm tra";
            this.bt_checkCode.UseVisualStyleBackColor = true;
            this.bt_checkCode.Click += new System.EventHandler(this.bt_checkCode_Click);
            // 
            // lb_resultCheckCode
            // 
            this.lb_resultCheckCode.AutoSize = true;
            this.lb_resultCheckCode.Location = new System.Drawing.Point(83, 86);
            this.lb_resultCheckCode.Name = "lb_resultCheckCode";
            this.lb_resultCheckCode.Size = new System.Drawing.Size(47, 15);
            this.lb_resultCheckCode.TabIndex = 10;
            this.lb_resultCheckCode.Text = "Kết quả";
            this.lb_resultCheckCode.Visible = false;
            // 
            // AddCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 402);
            this.Controls.Add(this.lb_resultCheckCode);
            this.Controls.Add(this.bt_checkCode);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_addPicture);
            this.Controls.Add(this.flowLO_btPicture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label1);
            this.Name = "AddCode";
            this.Text = "Thêm mã";
            this.Load += new System.EventHandler(this.AddCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLO_btPicture;
        private System.Windows.Forms.Button bt_addPicture;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_checkCode;
        private System.Windows.Forms.Label lb_resultCheckCode;
    }
}