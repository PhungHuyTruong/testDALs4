namespace GUI
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
            ten = new TextBox();
            diachi = new TextBox();
            sdt = new TextBox();
            ngaytuyendung = new TextBox();
            timkiem = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            show = new Button();
            them = new Button();
            sua = new Button();
            xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ten
            // 
            ten.Location = new Point(170, 72);
            ten.Name = "ten";
            ten.Size = new Size(386, 31);
            ten.TabIndex = 0;
            // 
            // diachi
            // 
            diachi.Location = new Point(170, 151);
            diachi.Name = "diachi";
            diachi.Size = new Size(386, 31);
            diachi.TabIndex = 1;
            // 
            // sdt
            // 
            sdt.Location = new Point(170, 233);
            sdt.Name = "sdt";
            sdt.Size = new Size(386, 31);
            sdt.TabIndex = 2;
            // 
            // ngaytuyendung
            // 
            ngaytuyendung.Location = new Point(170, 316);
            ngaytuyendung.Name = "ngaytuyendung";
            ngaytuyendung.Size = new Size(386, 31);
            ngaytuyendung.TabIndex = 3;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(980, 72);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(386, 31);
            timkiem.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(980, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(360, 33);
            comboBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(179, 407);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1214, 279);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // show
            // 
            show.Location = new Point(198, 729);
            show.Name = "show";
            show.Size = new Size(214, 88);
            show.TabIndex = 7;
            show.Text = "button1";
            show.UseVisualStyleBackColor = true;
            show.Click += show_Click;
            // 
            // them
            // 
            them.Location = new Point(524, 729);
            them.Name = "them";
            them.Size = new Size(214, 88);
            them.TabIndex = 8;
            them.Text = "button2";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // sua
            // 
            sua.Location = new Point(842, 729);
            sua.Name = "sua";
            sua.Size = new Size(214, 88);
            sua.TabIndex = 9;
            sua.Text = "button3";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(1152, 729);
            xoa.Name = "xoa";
            xoa.Size = new Size(214, 88);
            xoa.TabIndex = 10;
            xoa.Text = "button4";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1686, 854);
            Controls.Add(xoa);
            Controls.Add(sua);
            Controls.Add(them);
            Controls.Add(show);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(timkiem);
            Controls.Add(ngaytuyendung);
            Controls.Add(sdt);
            Controls.Add(diachi);
            Controls.Add(ten);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ten;
        private TextBox diachi;
        private TextBox sdt;
        private TextBox ngaytuyendung;
        private TextBox timkiem;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button show;
        private Button them;
        private Button sua;
        private Button xoa;
    }
}
