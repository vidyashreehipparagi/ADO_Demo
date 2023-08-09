namespace ADO_Demo.Models
{
    partial class Form2
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
            this.lbEid = new System.Windows.Forms.Label();
            this.lbEname = new System.Windows.Forms.Label();
            this.lbESalary = new System.Windows.Forms.Label();
            this.txEid = new System.Windows.Forms.TextBox();
            this.txEName = new System.Windows.Forms.TextBox();
            this.txSalary = new System.Windows.Forms.TextBox();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEid
            // 
            this.lbEid.AutoSize = true;
            this.lbEid.Location = new System.Drawing.Point(84, 47);
            this.lbEid.Name = "lbEid";
            this.lbEid.Size = new System.Drawing.Size(83, 16);
            this.lbEid.TabIndex = 0;
            this.lbEid.Text = "Employee Id";
            // 
            // lbEname
            // 
            this.lbEname.AutoSize = true;
            this.lbEname.Location = new System.Drawing.Point(84, 108);
            this.lbEname.Name = "lbEname";
            this.lbEname.Size = new System.Drawing.Size(109, 16);
            this.lbEname.TabIndex = 1;
            this.lbEname.Text = "Employee Name";
            // 
            // lbESalary
            // 
            this.lbESalary.AutoSize = true;
            this.lbESalary.Location = new System.Drawing.Point(84, 171);
            this.lbESalary.Name = "lbESalary";
            this.lbESalary.Size = new System.Drawing.Size(111, 16);
            this.lbESalary.TabIndex = 2;
            this.lbESalary.Text = "Employee Salary";
            // 
            // txEid
            // 
            this.txEid.Location = new System.Drawing.Point(219, 47);
            this.txEid.Multiline = true;
            this.txEid.Name = "txEid";
            this.txEid.Size = new System.Drawing.Size(132, 35);
            this.txEid.TabIndex = 3;
            this.txEid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txEName
            // 
            this.txEName.Location = new System.Drawing.Point(219, 108);
            this.txEName.Multiline = true;
            this.txEName.Name = "txEName";
            this.txEName.Size = new System.Drawing.Size(132, 35);
            this.txEName.TabIndex = 4;
            // 
            // txSalary
            // 
            this.txSalary.Location = new System.Drawing.Point(219, 168);
            this.txSalary.Multiline = true;
            this.txSalary.Name = "txSalary";
            this.txSalary.Size = new System.Drawing.Size(132, 35);
            this.txSalary.TabIndex = 5;
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(84, 234);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(77, 16);
            this.lbDepartment.TabIndex = 6;
            this.lbDepartment.Text = "Department";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(219, 244);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(132, 24);
            this.cbDepartment.TabIndex = 7;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(87, 320);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(112, 34);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(248, 320);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(112, 34);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(87, 387);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(112, 34);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(248, 387);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(112, 34);
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEid;
        private System.Windows.Forms.Label lbEname;
        private System.Windows.Forms.Label lbESalary;
        private System.Windows.Forms.TextBox txEid;
        private System.Windows.Forms.TextBox txEName;
        private System.Windows.Forms.TextBox txSalary;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSearch;
    }
}