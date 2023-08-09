namespace ADO_Demo
{
    partial class Form3
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
            this.btSearch = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.txSalary = new System.Windows.Forms.TextBox();
            this.txEName = new System.Windows.Forms.TextBox();
            this.txEid = new System.Windows.Forms.TextBox();
            this.lbESalary = new System.Windows.Forms.Label();
            this.lbEname = new System.Windows.Forms.Label();
            this.lbEid = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(267, 361);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(112, 34);
            this.btSearch.TabIndex = 23;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(106, 361);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(112, 34);
            this.btDelete.TabIndex = 22;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(267, 294);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(112, 34);
            this.btUpdate.TabIndex = 21;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(106, 294);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(112, 34);
            this.btSave.TabIndex = 20;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(238, 218);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(132, 24);
            this.cbDepartment.TabIndex = 19;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(103, 208);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(77, 16);
            this.lbDepartment.TabIndex = 18;
            this.lbDepartment.Text = "Department";
            this.lbDepartment.Click += new System.EventHandler(this.lbDepartment_Click);
            // 
            // txSalary
            // 
            this.txSalary.Location = new System.Drawing.Point(238, 142);
            this.txSalary.Multiline = true;
            this.txSalary.Name = "txSalary";
            this.txSalary.Size = new System.Drawing.Size(132, 35);
            this.txSalary.TabIndex = 17;
            this.txSalary.TextChanged += new System.EventHandler(this.txSalary_TextChanged);
            // 
            // txEName
            // 
            this.txEName.Location = new System.Drawing.Point(238, 82);
            this.txEName.Multiline = true;
            this.txEName.Name = "txEName";
            this.txEName.Size = new System.Drawing.Size(132, 35);
            this.txEName.TabIndex = 16;
            this.txEName.TextChanged += new System.EventHandler(this.txEName_TextChanged);
            // 
            // txEid
            // 
            this.txEid.Location = new System.Drawing.Point(238, 21);
            this.txEid.Multiline = true;
            this.txEid.Name = "txEid";
            this.txEid.Size = new System.Drawing.Size(132, 35);
            this.txEid.TabIndex = 15;
            this.txEid.TextChanged += new System.EventHandler(this.txEid_TextChanged);
            // 
            // lbESalary
            // 
            this.lbESalary.AutoSize = true;
            this.lbESalary.Location = new System.Drawing.Point(103, 145);
            this.lbESalary.Name = "lbESalary";
            this.lbESalary.Size = new System.Drawing.Size(111, 16);
            this.lbESalary.TabIndex = 14;
            this.lbESalary.Text = "Employee Salary";
            this.lbESalary.Click += new System.EventHandler(this.lbESalary_Click);
            // 
            // lbEname
            // 
            this.lbEname.AutoSize = true;
            this.lbEname.Location = new System.Drawing.Point(103, 82);
            this.lbEname.Name = "lbEname";
            this.lbEname.Size = new System.Drawing.Size(109, 16);
            this.lbEname.TabIndex = 13;
            this.lbEname.Text = "Employee Name";
            this.lbEname.Click += new System.EventHandler(this.lbEname_Click);
            // 
            // lbEid
            // 
            this.lbEid.AutoSize = true;
            this.lbEid.Location = new System.Drawing.Point(103, 21);
            this.lbEid.Name = "lbEid";
            this.lbEid.Size = new System.Drawing.Size(83, 16);
            this.lbEid.TabIndex = 12;
            this.lbEid.Text = "Employee Id";
            this.lbEid.Click += new System.EventHandler(this.lbEid_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(442, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(586, 298);
            this.dataGridView.TabIndex = 24;
            // 
            // btShowAll
            // 
            this.btShowAll.Location = new System.Drawing.Point(659, 342);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(112, 34);
            this.btShowAll.TabIndex = 25;
            this.btShowAll.Text = "ShowAll";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 528);
            this.Controls.Add(this.btShowAll);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.txSalary);
            this.Controls.Add(this.txEName);
            this.Controls.Add(this.txEid);
            this.Controls.Add(this.lbESalary);
            this.Controls.Add(this.lbEname);
            this.Controls.Add(this.lbEid);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.TextBox txSalary;
        private System.Windows.Forms.TextBox txEName;
        private System.Windows.Forms.TextBox txEid;
        private System.Windows.Forms.Label lbESalary;
        private System.Windows.Forms.Label lbEname;
        private System.Windows.Forms.Label lbEid;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btShowAll;
    }
}