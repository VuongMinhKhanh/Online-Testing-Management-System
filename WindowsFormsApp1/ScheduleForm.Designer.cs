namespace QuestionBank_GUI
{
    partial class ScheduleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btFind = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.listSchedule = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(179, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(507, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(832, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Lớp:";
            // 
            // lbTittle
            // 
            this.lbTittle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbTittle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTittle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Black;
            this.lbTittle.Location = new System.Drawing.Point(0, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(1312, 62);
            this.lbTittle.TabIndex = 3;
            this.lbTittle.Text = "Danh sách lịch thi";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMaMon.Location = new System.Drawing.Point(184, 157);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(192, 34);
            this.txtMaMon.TabIndex = 4;
            this.txtMaMon.Text = "VD:T103GENG";
            this.txtMaMon.Enter += new System.EventHandler(this.txtMaMon_Enter);
            this.txtMaMon.Leave += new System.EventHandler(this.txtMaMon_Leave);
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTenMonHoc.Location = new System.Drawing.Point(512, 157);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(186, 34);
            this.txtTenMonHoc.TabIndex = 5;
            this.txtTenMonHoc.Text = "VD:Tiếng Anh";
            this.txtTenMonHoc.Enter += new System.EventHandler(this.txtMaMon_Enter);
            this.txtTenMonHoc.Leave += new System.EventHandler(this.txtMaMon_Leave);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMaLop.Location = new System.Drawing.Point(837, 157);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(167, 34);
            this.txtMaLop.TabIndex = 6;
            this.txtMaLop.Text = "VD:IT2101";
            this.txtMaLop.Enter += new System.EventHandler(this.txtMaMon_Enter);
            this.txtMaLop.Leave += new System.EventHandler(this.txtMaMon_Leave);
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.Blue;
            this.btFind.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btFind.Location = new System.Drawing.Point(1031, 151);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(136, 44);
            this.btFind.TabIndex = 7;
            this.btFind.Text = "Tìm kiếm";
            this.btFind.UseVisualStyleBackColor = false;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Blue;
            this.btAdd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAdd.Location = new System.Drawing.Point(184, 619);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(136, 92);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Blue;
            this.btDelete.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDelete.Location = new System.Drawing.Point(350, 619);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(136, 92);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // listSchedule
            // 
            this.listSchedule.BackColor = System.Drawing.SystemColors.Window;
            this.listSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listSchedule.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSchedule.FullRowSelect = true;
            this.listSchedule.HideSelection = false;
            this.listSchedule.Location = new System.Drawing.Point(184, 218);
            this.listSchedule.Name = "listSchedule";
            this.listSchedule.Size = new System.Drawing.Size(983, 366);
            this.listSchedule.TabIndex = 10;
            this.listSchedule.UseCompatibleStateImageBehavior = false;
            this.listSchedule.View = System.Windows.Forms.View.Details;
            this.listSchedule.DoubleClick += new System.EventHandler(this.listSchedule_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã môn học";
            this.columnHeader1.Width = 203;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên môn học";
            this.columnHeader2.Width = 267;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Lớp học";
            this.columnHeader3.Width = 206;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày thi";
            this.columnHeader4.Width = 192;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giờ thi";
            this.columnHeader5.Width = 111;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 745);
            this.Controls.Add(this.listSchedule);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txtTenMonHoc);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.Leave += new System.EventHandler(this.txtMaMon_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ListView listSchedule;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}