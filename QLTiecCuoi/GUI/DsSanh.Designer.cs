namespace GUI
{
    partial class DsSanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DsSanh));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(680, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SẢNH";
            // 
            // dgvDS
            // 
            this.dgvDS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDS.Location = new System.Drawing.Point(402, 395);
            this.dgvDS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowHeadersWidth = 62;
            this.dgvDS.Size = new System.Drawing.Size(1018, 328);
            this.dgvDS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TÊN SẢNH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "LOẠI SẢNH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "SỐ LƯỢNG BÀN TỐI ĐA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1026, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "GHI CHÚ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "ĐƠN GIÁ TỐI THIỂU";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(633, 103);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(334, 26);
            this.txtTen.TabIndex = 7;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(633, 268);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(158, 26);
            this.txtDonGia.TabIndex = 8;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(1128, 111);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(292, 184);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(633, 214);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(158, 26);
            this.txtSL.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(412, 326);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(230, 46);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(726, 326);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(230, 46);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1030, 326);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(230, 46);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(633, 162);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(334, 28);
            this.cbLoai.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 71);
            this.button4.TabIndex = 16;
            this.button4.Text = "DANH SÁCH SẢNH";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 169);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 71);
            this.button5.TabIndex = 17;
            this.button5.Text = "DANH SÁCH TIỆC CƯỚI";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(20, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(216, 71);
            this.button6.TabIndex = 18;
            this.button6.Text = "DOANH THU";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(14, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 448);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // DsSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1436, 726);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDS);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DsSanh";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

