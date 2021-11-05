
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnThemTour = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSuaTour = new System.Windows.Forms.Button();
            this.btnXoaTour = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbMaDoan = new System.Windows.Forms.Label();
            this.txtMaDoan = new System.Windows.Forms.TextBox();
            this.txtHanhTrinh = new System.Windows.Forms.TextBox();
            this.lbHanhTrinh = new System.Windows.Forms.Label();
            this.lbKhachSan = new System.Windows.Forms.Label();
            this.txtKhachSan = new System.Windows.Forms.TextBox();
            this.lbDiaDiem = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemTour
            // 
            this.btnThemTour.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemTour.Location = new System.Drawing.Point(62, 520);
            this.btnThemTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTour.Name = "btnThemTour";
            this.btnThemTour.Size = new System.Drawing.Size(140, 45);
            this.btnThemTour.TabIndex = 0;
            this.btnThemTour.Text = "Thêm tour";
            this.btnThemTour.UseVisualStyleBackColor = false;
            this.btnThemTour.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTitle.Location = new System.Drawing.Point(56, 21);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(178, 32);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Quản lý Tour";
            this.lbTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSuaTour
            // 
            this.btnSuaTour.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaTour.Location = new System.Drawing.Point(344, 520);
            this.btnSuaTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaTour.Name = "btnSuaTour";
            this.btnSuaTour.Size = new System.Drawing.Size(140, 45);
            this.btnSuaTour.TabIndex = 2;
            this.btnSuaTour.Text = "Sửa tour";
            this.btnSuaTour.UseVisualStyleBackColor = false;
            this.btnSuaTour.Click += new System.EventHandler(this.btnSuaTour_Click);
            // 
            // btnXoaTour
            // 
            this.btnXoaTour.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoaTour.Location = new System.Drawing.Point(627, 520);
            this.btnXoaTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTour.Name = "btnXoaTour";
            this.btnXoaTour.Size = new System.Drawing.Size(140, 45);
            this.btnXoaTour.TabIndex = 3;
            this.btnXoaTour.Text = "Xóa tour";
            this.btnXoaTour.UseVisualStyleBackColor = false;
            this.btnXoaTour.Click += new System.EventHandler(this.btnXoaTour_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(693, 253);
            this.dataGridView1.TabIndex = 4;
            // 
            // lbMaDoan
            // 
            this.lbMaDoan.AutoSize = true;
            this.lbMaDoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDoan.Location = new System.Drawing.Point(85, 90);
            this.lbMaDoan.Name = "lbMaDoan";
            this.lbMaDoan.Size = new System.Drawing.Size(79, 22);
            this.lbMaDoan.TabIndex = 5;
            this.lbMaDoan.Text = "Mã đoàn";
            this.lbMaDoan.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaDoan
            // 
            this.txtMaDoan.Location = new System.Drawing.Point(181, 83);
            this.txtMaDoan.Multiline = true;
            this.txtMaDoan.Name = "txtMaDoan";
            this.txtMaDoan.Size = new System.Drawing.Size(201, 29);
            this.txtMaDoan.TabIndex = 6;
            this.txtMaDoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHanhTrinh
            // 
            this.txtHanhTrinh.Location = new System.Drawing.Point(566, 83);
            this.txtHanhTrinh.Multiline = true;
            this.txtHanhTrinh.Name = "txtHanhTrinh";
            this.txtHanhTrinh.Size = new System.Drawing.Size(201, 29);
            this.txtHanhTrinh.TabIndex = 7;
            // 
            // lbHanhTrinh
            // 
            this.lbHanhTrinh.AutoSize = true;
            this.lbHanhTrinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHanhTrinh.Location = new System.Drawing.Point(452, 90);
            this.lbHanhTrinh.Name = "lbHanhTrinh";
            this.lbHanhTrinh.Size = new System.Drawing.Size(92, 22);
            this.lbHanhTrinh.TabIndex = 8;
            this.lbHanhTrinh.Text = "Hành trình";
            this.lbHanhTrinh.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbKhachSan
            // 
            this.lbKhachSan.AutoSize = true;
            this.lbKhachSan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachSan.Location = new System.Drawing.Point(85, 164);
            this.lbKhachSan.Name = "lbKhachSan";
            this.lbKhachSan.Size = new System.Drawing.Size(91, 22);
            this.lbKhachSan.TabIndex = 9;
            this.lbKhachSan.Text = "Khách sạn";
            this.lbKhachSan.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtKhachSan
            // 
            this.txtKhachSan.Location = new System.Drawing.Point(181, 157);
            this.txtKhachSan.Multiline = true;
            this.txtKhachSan.Name = "txtKhachSan";
            this.txtKhachSan.Size = new System.Drawing.Size(201, 29);
            this.txtKhachSan.TabIndex = 10;
            // 
            // lbDiaDiem
            // 
            this.lbDiaDiem.AutoSize = true;
            this.lbDiaDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaDiem.Location = new System.Drawing.Point(452, 164);
            this.lbDiaDiem.Name = "lbDiaDiem";
            this.lbDiaDiem.Size = new System.Drawing.Size(83, 22);
            this.lbDiaDiem.TabIndex = 11;
            this.lbDiaDiem.Text = "Địa điểm";
            this.lbDiaDiem.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(566, 157);
            this.txtDiaDiem.Multiline = true;
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(201, 29);
            this.txtDiaDiem.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 594);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.lbDiaDiem);
            this.Controls.Add(this.txtKhachSan);
            this.Controls.Add(this.lbKhachSan);
            this.Controls.Add(this.lbHanhTrinh);
            this.Controls.Add(this.txtHanhTrinh);
            this.Controls.Add(this.txtMaDoan);
            this.Controls.Add(this.lbMaDoan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoaTour);
            this.Controls.Add(this.btnSuaTour);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnThemTour);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemTour;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSuaTour;
        private System.Windows.Forms.Button btnXoaTour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMaDoan;
        private System.Windows.Forms.TextBox txtMaDoan;
        private System.Windows.Forms.TextBox txtHanhTrinh;
        private System.Windows.Forms.Label lbHanhTrinh;
        private System.Windows.Forms.Label lbKhachSan;
        private System.Windows.Forms.TextBox txtKhachSan;
        private System.Windows.Forms.Label lbDiaDiem;
        private System.Windows.Forms.TextBox txtDiaDiem;
    }
}

