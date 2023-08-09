namespace ADO_Demo
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
            this.txId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbCategoryNAme = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.btSvae = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSaveAll = new System.Windows.Forms.Button();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(224, 34);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(113, 22);
            this.txId.TabIndex = 0;
            this.txId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(76, 34);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(67, 16);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Product Id";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(76, 83);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(93, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Product Nmae";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(76, 141);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(80, 16);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Prodct Price";
            // 
            // lbCategoryNAme
            // 
            this.lbCategoryNAme.AutoSize = true;
            this.lbCategoryNAme.Location = new System.Drawing.Point(76, 201);
            this.lbCategoryNAme.Name = "lbCategoryNAme";
            this.lbCategoryNAme.Size = new System.Drawing.Size(102, 16);
            this.lbCategoryNAme.TabIndex = 4;
            this.lbCategoryNAme.Text = "Category Name";
            this.lbCategoryNAme.Click += new System.EventHandler(this.lbCategoryNAme_Click);
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(224, 77);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(113, 22);
            this.txName.TabIndex = 5;
            this.txName.TextChanged += new System.EventHandler(this.txName_TextChanged);
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(224, 135);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(113, 22);
            this.txPrice.TabIndex = 6;
            // 
            // btSvae
            // 
            this.btSvae.Location = new System.Drawing.Point(93, 309);
            this.btSvae.Name = "btSvae";
            this.btSvae.Size = new System.Drawing.Size(125, 48);
            this.btSvae.TabIndex = 8;
            this.btSvae.Text = "Save";
            this.btSvae.UseVisualStyleBackColor = true;
            this.btSvae.Click += new System.EventHandler(this.btSvae_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(275, 309);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(125, 48);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(465, 51);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(125, 48);
            this.btSearch.TabIndex = 10;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(654, 51);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(125, 48);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(386, 136);
            this.dataGridView1.TabIndex = 12;
            // 
            // btSaveAll
            // 
            this.btSaveAll.Location = new System.Drawing.Point(528, 309);
            this.btSaveAll.Name = "btSaveAll";
            this.btSaveAll.Size = new System.Drawing.Size(125, 48);
            this.btSaveAll.TabIndex = 13;
            this.btSaveAll.Text = "Save all";
            this.btSaveAll.UseVisualStyleBackColor = true;
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(224, 201);
            this.cbCategoryName.Name = "cbCategoryName";
            this.cbCategoryName.Size = new System.Drawing.Size(113, 24);
            this.cbCategoryName.TabIndex = 14;
            this.cbCategoryName.SelectedIndexChanged += new System.EventHandler(this.cbCategoryName_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCategoryName);
            this.Controls.Add(this.btSaveAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSvae);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.lbCategoryNAme);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbCategoryNAme;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Button btSvae;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSaveAll;
        private System.Windows.Forms.ComboBox cbCategoryName;
    }
}

