namespace QuestionBank_GUI
{
    partial class ClassListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSearchResult = new System.Windows.Forms.DataGridView();
            this.panelOption = new System.Windows.Forms.Panel();
            this.btDetail = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtFind = new System.Windows.Forms.TextBox();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.lbTittle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).BeginInit();
            this.panelOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearchResult
            // 
            this.dataGridViewSearchResult.AllowUserToAddRows = false;
            this.dataGridViewSearchResult.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResult.AllowUserToResizeColumns = false;
            this.dataGridViewSearchResult.AllowUserToResizeRows = false;
            this.dataGridViewSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchResult.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewSearchResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResult.ColumnHeadersVisible = false;
            this.dataGridViewSearchResult.Location = new System.Drawing.Point(446, 144);
            this.dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            this.dataGridViewSearchResult.RowHeadersVisible = false;
            this.dataGridViewSearchResult.RowHeadersWidth = 51;
            this.dataGridViewSearchResult.RowTemplate.Height = 30;
            this.dataGridViewSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchResult.Size = new System.Drawing.Size(392, 0);
            this.dataGridViewSearchResult.TabIndex = 19;
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.Color.RosyBrown;
            this.panelOption.Controls.Add(this.btDetail);
            this.panelOption.Controls.Add(this.btFind);
            this.panelOption.Controls.Add(this.txtFind);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOption.Location = new System.Drawing.Point(0, 83);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(852, 41);
            this.panelOption.TabIndex = 21;
            // 
            // btDetail
            // 
            this.btDetail.Location = new System.Drawing.Point(19, 3);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(229, 34);
            this.btDetail.TabIndex = 12;
            this.btDetail.Text = "Xem bảng điểm";
            this.btDetail.UseVisualStyleBackColor = true;
            this.btDetail.Click += new System.EventHandler(this.btDetail_Click);
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.Teal;
            this.btFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFind.BackgroundImage")));
            this.btFind.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.ImageIndex = 0;
            this.btFind.ImageList = this.imageList1;
            this.btFind.Location = new System.Drawing.Point(766, 2);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(67, 34);
            this.btFind.TabIndex = 11;
            this.btFind.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "find.png");
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFind.Location = new System.Drawing.Point(368, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(392, 34);
            this.txtFind.TabIndex = 10;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudent.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudent.Location = new System.Drawing.Point(19, 150);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.RowHeadersVisible = false;
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudent.Size = new System.Drawing.Size(819, 451);
            this.dataGridViewStudent.TabIndex = 2;
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
            this.lbTittle.Size = new System.Drawing.Size(852, 83);
            this.lbTittle.TabIndex = 18;
            this.lbTittle.Text = "Danh sách sinh viên";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 613);
            this.Controls.Add(this.dataGridViewSearchResult);
            this.Controls.Add(this.panelOption);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.lbTittle);
            this.Name = "ClassListForm";
            this.Text = "ClassListForm";
            this.Load += new System.EventHandler(this.ClassListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).EndInit();
            this.panelOption.ResumeLayout(false);
            this.panelOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSearchResult;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Button btDetail;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.ImageList imageList1;
    }
}