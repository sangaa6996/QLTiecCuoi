namespace GUI
{
    partial class DichVu
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
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbTen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(44, 32);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 62;
            this.dgvDichVu.Size = new System.Drawing.Size(359, 266);
            this.dgvDichVu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn giá";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(558, 100);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(148, 26);
            this.txtSL.TabIndex = 2;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(558, 180);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(148, 26);
            this.txtDonGia.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(748, 263);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbTen
            // 
            this.cbTen.FormattingEnabled = true;
            this.cbTen.Location = new System.Drawing.Point(558, 32);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(150, 28);
            this.cbTen.TabIndex = 4;
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTen);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDichVu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DichVu";
            this.Text = "DichVu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbTen;
    }
}