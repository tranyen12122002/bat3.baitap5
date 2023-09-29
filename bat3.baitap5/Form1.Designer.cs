namespace bat3.baitap5
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmsv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbthongtin = new System.Windows.Forms.GroupBox();
            this.btnxoahet = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnthem = new System.Windows.Forms.Button();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbthongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmsv,
            this.hoten,
            this.diachi,
            this.ngaysinh,
            this.lop});
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.Location = new System.Drawing.Point(0, 303);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 260);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmsv
            // 
            this.clmsv.Text = "Ma SV";
            this.clmsv.Width = 63;
            // 
            // hoten
            // 
            this.hoten.Text = "Họ tên";
            this.hoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoten.Width = 133;
            // 
            // diachi
            // 
            this.diachi.Text = "Địa chỉ";
            this.diachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.diachi.Width = 150;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Text = "Ngày sinh";
            this.ngaysinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ngaysinh.Width = 121;
            // 
            // lop
            // 
            this.lop.Text = "Lớp";
            this.lop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lop.Width = 72;
            // 
            // gbthongtin
            // 
            this.gbthongtin.Controls.Add(this.btnxoahet);
            this.gbthongtin.Controls.Add(this.btnthoat);
            this.gbthongtin.Controls.Add(this.btnxoa);
            this.gbthongtin.Controls.Add(this.btncapnhat);
            this.gbthongtin.Controls.Add(this.cblop);
            this.gbthongtin.Controls.Add(this.listView1);
            this.gbthongtin.Controls.Add(this.dtngaysinh);
            this.gbthongtin.Controls.Add(this.btnthem);
            this.gbthongtin.Controls.Add(this.txthoten);
            this.gbthongtin.Controls.Add(this.txtdiachi);
            this.gbthongtin.Controls.Add(this.txtmasv);
            this.gbthongtin.Controls.Add(this.label5);
            this.gbthongtin.Controls.Add(this.label4);
            this.gbthongtin.Controls.Add(this.label3);
            this.gbthongtin.Controls.Add(this.label2);
            this.gbthongtin.Controls.Add(this.label1);
            this.gbthongtin.Location = new System.Drawing.Point(11, 11);
            this.gbthongtin.Margin = new System.Windows.Forms.Padding(2);
            this.gbthongtin.Name = "gbthongtin";
            this.gbthongtin.Padding = new System.Windows.Forms.Padding(2);
            this.gbthongtin.Size = new System.Drawing.Size(538, 507);
            this.gbthongtin.TabIndex = 1;
            this.gbthongtin.TabStop = false;
            this.gbthongtin.Text = "Thông tin sinh viên";
            // 
            // btnxoahet
            // 
            this.btnxoahet.Location = new System.Drawing.Point(381, 193);
            this.btnxoahet.Name = "btnxoahet";
            this.btnxoahet.Size = new System.Drawing.Size(109, 41);
            this.btnxoahet.TabIndex = 14;
            this.btnxoahet.Text = "Xóa hết";
            this.btnxoahet.UseVisualStyleBackColor = true;
            this.btnxoahet.Click += new System.EventHandler(this.btnxoahet_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(381, 239);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(109, 41);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(381, 139);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(109, 41);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "Xóa Item";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(381, 84);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(136, 41);
            this.btncapnhat.TabIndex = 11;
            this.btncapnhat.Text = "Cập nhật Item";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Items.AddRange(new object[] {
            "Lớp A",
            "Lớp B",
            "Lớp C"});
            this.cblop.Location = new System.Drawing.Point(175, 239);
            this.cblop.Margin = new System.Windows.Forms.Padding(2);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(168, 28);
            this.cblop.TabIndex = 10;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(175, 187);
            this.dtngaysinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(168, 28);
            this.dtngaysinh.TabIndex = 9;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(381, 33);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 41);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(175, 81);
            this.txthoten.Margin = new System.Windows.Forms.Padding(2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(168, 28);
            this.txthoten.TabIndex = 8;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(175, 136);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(168, 28);
            this.txtdiachi.TabIndex = 6;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(175, 37);
            this.txtmasv.Margin = new System.Windows.Forms.Padding(2);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(168, 28);
            this.txtmasv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 534);
            this.Controls.Add(this.gbthongtin);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbthongtin.ResumeLayout(false);
            this.gbthongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmsv;
        private System.Windows.Forms.ColumnHeader hoten;
        private System.Windows.Forms.ColumnHeader diachi;
        private System.Windows.Forms.ColumnHeader ngaysinh;
        private System.Windows.Forms.ColumnHeader lop;
        private System.Windows.Forms.GroupBox gbthongtin;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoahet;
    }
}

