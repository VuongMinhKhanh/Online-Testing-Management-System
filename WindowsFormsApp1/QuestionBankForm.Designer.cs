
namespace QuestionBank_GUI
{
    partial class QuestionBankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionBankForm));
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listQuestion = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.addDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSubject
            // 
            resources.ApplyResources(this.cbSubject, "cbSubject");
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Name = "cbSubject";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listQuestion
            // 
            resources.ApplyResources(this.listQuestion, "listQuestion");
            this.listQuestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listQuestion.HideSelection = false;
            this.listQuestion.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listQuestion.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listQuestion.Items1"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listQuestion.Items2"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listQuestion.Items3")))});
            this.listQuestion.Name = "listQuestion";
            this.listQuestion.UseCompatibleStateImageBehavior = false;
            this.listQuestion.View = System.Windows.Forms.View.Details;
            this.listQuestion.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdjust
            // 
            resources.ApplyResources(this.btnAdjust, "btnAdjust");
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.UseVisualStyleBackColor = true;
            // 
            // addDelete
            // 
            resources.ApplyResources(this.addDelete, "addDelete");
            this.addDelete.Name = "addDelete";
            this.addDelete.UseVisualStyleBackColor = true;
            // 
            // QuestionBankForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addDelete);
            this.Controls.Add(this.btnAdjust);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSubject);
            this.Name = "QuestionBankForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listQuestion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdjust;
        private System.Windows.Forms.Button addDelete;
    }
}

