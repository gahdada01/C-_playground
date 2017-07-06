namespace WindowsFormsApplication1
{
    partial class fViewCOI
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
            this.dgv_COInsured = new System.Windows.Forms.DataGridView();
            this.cCOI_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCO_CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOI_Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOI_Middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOI_Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOI_Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOI_Relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCOI_COCNo = new System.Windows.Forms.Label();
            this.txtCOI_COCNo = new System.Windows.Forms.TextBox();
            this.btnCOI_Add = new System.Windows.Forms.Button();
            this.btnCOI_Edit = new System.Windows.Forms.Button();
            this.btnCOI_Delete = new System.Windows.Forms.Button();
            this.btnCI_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_COInsured)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_COInsured
            // 
            this.dgv_COInsured.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_COInsured.BackgroundColor = System.Drawing.Color.White;
            this.dgv_COInsured.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_COInsured.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCOI_ID,
            this.cCO_CID,
            this.cCOI_Firstname,
            this.cCOI_Middlename,
            this.cCOI_Lastname,
            this.cCOI_Birthdate,
            this.cCOI_Relationship});
            this.dgv_COInsured.GridColor = System.Drawing.Color.Black;
            this.dgv_COInsured.Location = new System.Drawing.Point(12, 92);
            this.dgv_COInsured.Name = "dgv_COInsured";
            this.dgv_COInsured.ReadOnly = true;
            this.dgv_COInsured.RowHeadersVisible = false;
            this.dgv_COInsured.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_COInsured.Size = new System.Drawing.Size(683, 178);
            this.dgv_COInsured.TabIndex = 0;
            this.dgv_COInsured.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_COInsured_MouseClick);
            // 
            // cCOI_ID
            // 
            this.cCOI_ID.HeaderText = "ID";
            this.cCOI_ID.Name = "cCOI_ID";
            this.cCOI_ID.ReadOnly = true;
            // 
            // cCO_CID
            // 
            this.cCO_CID.HeaderText = "CID";
            this.cCO_CID.Name = "cCO_CID";
            this.cCO_CID.ReadOnly = true;
            // 
            // cCOI_Firstname
            // 
            this.cCOI_Firstname.HeaderText = "Firstname";
            this.cCOI_Firstname.Name = "cCOI_Firstname";
            this.cCOI_Firstname.ReadOnly = true;
            // 
            // cCOI_Middlename
            // 
            this.cCOI_Middlename.HeaderText = "Middlename";
            this.cCOI_Middlename.Name = "cCOI_Middlename";
            this.cCOI_Middlename.ReadOnly = true;
            // 
            // cCOI_Lastname
            // 
            this.cCOI_Lastname.HeaderText = "Lastname";
            this.cCOI_Lastname.Name = "cCOI_Lastname";
            this.cCOI_Lastname.ReadOnly = true;
            // 
            // cCOI_Birthdate
            // 
            this.cCOI_Birthdate.HeaderText = "Birthdate";
            this.cCOI_Birthdate.Name = "cCOI_Birthdate";
            this.cCOI_Birthdate.ReadOnly = true;
            // 
            // cCOI_Relationship
            // 
            this.cCOI_Relationship.HeaderText = "Relationship";
            this.cCOI_Relationship.Name = "cCOI_Relationship";
            this.cCOI_Relationship.ReadOnly = true;
            // 
            // lblCOI_COCNo
            // 
            this.lblCOI_COCNo.AutoSize = true;
            this.lblCOI_COCNo.Location = new System.Drawing.Point(26, 15);
            this.lblCOI_COCNo.Name = "lblCOI_COCNo";
            this.lblCOI_COCNo.Size = new System.Drawing.Size(43, 13);
            this.lblCOI_COCNo.TabIndex = 6;
            this.lblCOI_COCNo.Text = "COCNo";
            // 
            // txtCOI_COCNo
            // 
            this.txtCOI_COCNo.Enabled = false;
            this.txtCOI_COCNo.Location = new System.Drawing.Point(75, 12);
            this.txtCOI_COCNo.Name = "txtCOI_COCNo";
            this.txtCOI_COCNo.Size = new System.Drawing.Size(100, 20);
            this.txtCOI_COCNo.TabIndex = 7;
            // 
            // btnCOI_Add
            // 
            this.btnCOI_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCOI_Add.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOI_Add.Location = new System.Drawing.Point(68, 54);
            this.btnCOI_Add.Name = "btnCOI_Add";
            this.btnCOI_Add.Size = new System.Drawing.Size(107, 23);
            this.btnCOI_Add.TabIndex = 8;
            this.btnCOI_Add.Text = "Add";
            this.btnCOI_Add.UseVisualStyleBackColor = false;
            this.btnCOI_Add.Click += new System.EventHandler(this.btnCOI_Add_Click);
            // 
            // btnCOI_Edit
            // 
            this.btnCOI_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCOI_Edit.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOI_Edit.Location = new System.Drawing.Point(538, 54);
            this.btnCOI_Edit.Name = "btnCOI_Edit";
            this.btnCOI_Edit.Size = new System.Drawing.Size(107, 23);
            this.btnCOI_Edit.TabIndex = 9;
            this.btnCOI_Edit.Text = "Edit";
            this.btnCOI_Edit.UseVisualStyleBackColor = false;
            this.btnCOI_Edit.Click += new System.EventHandler(this.btnCOI_Edit_Click);
            // 
            // btnCOI_Delete
            // 
            this.btnCOI_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCOI_Delete.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOI_Delete.Location = new System.Drawing.Point(304, 54);
            this.btnCOI_Delete.Name = "btnCOI_Delete";
            this.btnCOI_Delete.Size = new System.Drawing.Size(107, 23);
            this.btnCOI_Delete.TabIndex = 10;
            this.btnCOI_Delete.Text = "Delete";
            this.btnCOI_Delete.UseVisualStyleBackColor = false;
            this.btnCOI_Delete.Click += new System.EventHandler(this.btnCOI_Delete_Click);
            // 
            // btnCI_Update
            // 
            this.btnCI_Update.BackColor = System.Drawing.Color.Gray;
            this.btnCI_Update.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCI_Update.Location = new System.Drawing.Point(318, 289);
            this.btnCI_Update.Name = "btnCI_Update";
            this.btnCI_Update.Size = new System.Drawing.Size(75, 23);
            this.btnCI_Update.TabIndex = 11;
            this.btnCI_Update.Text = "Refresh";
            this.btnCI_Update.UseVisualStyleBackColor = false;
            this.btnCI_Update.Click += new System.EventHandler(this.btnCI_Update_Click);
            // 
            // fViewCOI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(707, 334);
            this.Controls.Add(this.btnCI_Update);
            this.Controls.Add(this.btnCOI_Delete);
            this.Controls.Add(this.btnCOI_Edit);
            this.Controls.Add(this.btnCOI_Add);
            this.Controls.Add(this.txtCOI_COCNo);
            this.Controls.Add(this.lblCOI_COCNo);
            this.Controls.Add(this.dgv_COInsured);
            this.Name = "fViewCOI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_COInsured)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_COInsured;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOI_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCO_CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOI_Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOI_Middlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOI_Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOI_Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOI_Relationship;
        private System.Windows.Forms.Label lblCOI_COCNo;
        private System.Windows.Forms.TextBox txtCOI_COCNo;
        private System.Windows.Forms.Button btnCOI_Add;
        private System.Windows.Forms.Button btnCOI_Edit;
        private System.Windows.Forms.Button btnCOI_Delete;
        private System.Windows.Forms.Button btnCI_Update;
    }
}