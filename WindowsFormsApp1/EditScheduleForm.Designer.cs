namespace QuestionBank_GUI
{
    partial class EditScheduleForm
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
            this.lbTittle = new System.Windows.Forms.Label();
            this.dateNgayThi = new System.Windows.Forms.DateTimePicker();
            this.cbGioThi = new System.Windows.Forms.ComboBox();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.cbMaMon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTittle
            // 
            this.lbTittle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbTittle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTittle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Black;
            this.lbTittle.Location = new System.Drawing.Point(0, 0);
            this.lbTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(699, 78);
            this.lbTittle.TabIndex = 21;
            this.lbTittle.Text = "Chỉnh sửa lịch thi";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateNgayThi
            // 
            this.dateNgayThi.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayThi.CustomFormat = "dd/MM/yyyy";
            this.dateNgayThi.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayThi.Location = new System.Drawing.Point(113, 233);
            this.dateNgayThi.Name = "dateNgayThi";
            this.dateNgayThi.Size = new System.Drawing.Size(166, 34);
            this.dateNgayThi.TabIndex = 29;
            // 
            // cbGioThi
            // 
            this.cbGioThi.FormattingEnabled = true;
            this.cbGioThi.Items.AddRange(new object[] {
            "7:30",
            "9:45",
            "13:00",
            "15:30",
            "18:00"});
            this.cbGioThi.Location = new System.Drawing.Point(425, 233);
            this.cbGioThi.Name = "cbGioThi";
            this.cbGioThi.Size = new System.Drawing.Size(166, 28);
            this.cbGioThi.TabIndex = 28;
            // 
            // cbMaLop
            // 
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Items.AddRange(new object[] {
            "DH21IT01"});
            this.cbMaLop.Location = new System.Drawing.Point(425, 140);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(166, 28);
            this.cbMaLop.TabIndex = 27;
            // 
            // cbMaMon
            // 
            this.cbMaMon.FormattingEnabled = true;
            this.cbMaMon.Items.AddRange(new object[] {
            "IT2101"});
            this.cbMaMon.Location = new System.Drawing.Point(113, 140);
            this.cbMaMon.Name = "cbMaMon";
            this.cbMaMon.Size = new System.Drawing.Size(166, 28);
            this.cbMaMon.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(420, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giờ thi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(108, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mã Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(420, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã môn:";
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Blue;
            this.btExit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btExit.Location = new System.Drawing.Point(364, 286);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(136, 92);
            this.btExit.TabIndex = 31;
            this.btExit.Text = "Đóng";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.Blue;
            this.btConfirm.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btConfirm.Location = new System.Drawing.Point(198, 286);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(136, 92);
            this.btConfirm.TabIndex = 30;
            this.btConfirm.Text = "Xác nhận";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // EditScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 394);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.dateNgayThi);
            this.Controls.Add(this.cbGioThi);
            this.Controls.Add(this.cbMaLop);
            this.Controls.Add(this.cbMaMon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTittle);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "EditScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditScheduleForm";
            this.Load += new System.EventHandler(this.EditScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.DateTimePicker dateNgayThi;
        private System.Windows.Forms.ComboBox cbGioThi;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.ComboBox cbMaMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btConfirm;
    }
}