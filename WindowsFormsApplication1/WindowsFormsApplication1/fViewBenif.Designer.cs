namespace WindowsFormsApplication1
{
    partial class fViewBenif
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
            this.dgv_Benificiaries = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMiddlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRelationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnB_Add = new System.Windows.Forms.Button();
            this.btnB_Edit = new System.Windows.Forms.Button();
            this.btnB_Delete = new System.Windows.Forms.Button();
            this.txtC_COCNo = new System.Windows.Forms.TextBox();
            this.lblC_COCNo = new System.Windows.Forms.Label();
            this.btnB_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Benificiaries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Benificiaries
            // 
            this.dgv_Benificiaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Benificiaries.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Benificiaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Benificiaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cCID,
            this.cFirstname,
            this.cMiddlename,
            this.cLastname,
            this.cRelationship,
            this.cAddress,
            this.cBirthdate,
            this.cGender,
            this.cPhone,
            this.cMobile});
            this.dgv_Benificiaries.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Benificiaries.Location = new System.Drawing.Point(12, 109);
            this.dgv_Benificiaries.Name = "dgv_Benificiaries";
            this.dgv_Benificiaries.ReadOnly = true;
            this.dgv_Benificiaries.RowHeadersVisible = false;
            this.dgv_Benificiaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Benificiaries.Size = new System.Drawing.Size(724, 189);
            this.dgv_Benificiaries.TabIndex = 0;
            this.dgv_Benificiaries.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Benificiaries_MouseClick);
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cCID
            // 
            this.cCID.HeaderText = "ClientID";
            this.cCID.Name = "cCID";
            this.cCID.ReadOnly = true;
            // 
            // cFirstname
            // 
            this.cFirstname.HeaderText = "FirstName";
            this.cFirstname.Name = "cFirstname";
            this.cFirstname.ReadOnly = true;
            // 
            // cMiddlename
            // 
            this.cMiddlename.HeaderText = "MiddleName";
            this.cMiddlename.Name = "cMiddlename";
            this.cMiddlename.ReadOnly = true;
            // 
            // cLastname
            // 
            this.cLastname.HeaderText = "LastName";
            this.cLastname.Name = "cLastname";
            this.cLastname.ReadOnly = true;
            // 
            // cRelationship
            // 
            this.cRelationship.HeaderText = "Relationship";
            this.cRelationship.Name = "cRelationship";
            this.cRelationship.ReadOnly = true;
            // 
            // cAddress
            // 
            this.cAddress.HeaderText = "Address";
            this.cAddress.Name = "cAddress";
            this.cAddress.ReadOnly = true;
            // 
            // cBirthdate
            // 
            this.cBirthdate.HeaderText = "Birthdate";
            this.cBirthdate.Name = "cBirthdate";
            this.cBirthdate.ReadOnly = true;
            // 
            // cGender
            // 
            this.cGender.HeaderText = "Gender";
            this.cGender.Name = "cGender";
            this.cGender.ReadOnly = true;
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "Phone";
            this.cPhone.Name = "cPhone";
            this.cPhone.ReadOnly = true;
            // 
            // cMobile
            // 
            this.cMobile.HeaderText = "Mobile";
            this.cMobile.Name = "cMobile";
            this.cMobile.ReadOnly = true;
            // 
            // btnB_Add
            // 
            this.btnB_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnB_Add.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB_Add.Location = new System.Drawing.Point(83, 70);
            this.btnB_Add.Name = "btnB_Add";
            this.btnB_Add.Size = new System.Drawing.Size(107, 23);
            this.btnB_Add.TabIndex = 1;
            this.btnB_Add.Text = "Add";
            this.btnB_Add.UseVisualStyleBackColor = false;
            this.btnB_Add.Click += new System.EventHandler(this.btnB_Add_Click);
            // 
            // btnB_Edit
            // 
            this.btnB_Edit.BackColor = System.Drawing.Color.Lime;
            this.btnB_Edit.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB_Edit.Location = new System.Drawing.Point(533, 70);
            this.btnB_Edit.Name = "btnB_Edit";
            this.btnB_Edit.Size = new System.Drawing.Size(107, 23);
            this.btnB_Edit.TabIndex = 2;
            this.btnB_Edit.Text = "Edit";
            this.btnB_Edit.UseVisualStyleBackColor = false;
            this.btnB_Edit.Click += new System.EventHandler(this.btnB_Edit_Click);
            // 
            // btnB_Delete
            // 
            this.btnB_Delete.BackColor = System.Drawing.Color.DimGray;
            this.btnB_Delete.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB_Delete.Location = new System.Drawing.Point(311, 70);
            this.btnB_Delete.Name = "btnB_Delete";
            this.btnB_Delete.Size = new System.Drawing.Size(107, 23);
            this.btnB_Delete.TabIndex = 3;
            this.btnB_Delete.Text = "Delete";
            this.btnB_Delete.UseVisualStyleBackColor = false;
            this.btnB_Delete.Click += new System.EventHandler(this.btnB_Delete_Click);
            // 
            // txtC_COCNo
            // 
            this.txtC_COCNo.Enabled = false;
            this.txtC_COCNo.Location = new System.Drawing.Point(83, 30);
            this.txtC_COCNo.Name = "txtC_COCNo";
            this.txtC_COCNo.Size = new System.Drawing.Size(100, 20);
            this.txtC_COCNo.TabIndex = 4;
            // 
            // lblC_COCNo
            // 
            this.lblC_COCNo.AutoSize = true;
            this.lblC_COCNo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC_COCNo.Location = new System.Drawing.Point(26, 34);
            this.lblC_COCNo.Name = "lblC_COCNo";
            this.lblC_COCNo.Size = new System.Drawing.Size(51, 16);
            this.lblC_COCNo.TabIndex = 5;
            this.lblC_COCNo.Text = "COC No.";
            // 
            // btnB_Update
            // 
            this.btnB_Update.BackColor = System.Drawing.Color.Gray;
            this.btnB_Update.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB_Update.Location = new System.Drawing.Point(343, 318);
            this.btnB_Update.Name = "btnB_Update";
            this.btnB_Update.Size = new System.Drawing.Size(75, 23);
            this.btnB_Update.TabIndex = 6;
            this.btnB_Update.Text = "Refresh";
            this.btnB_Update.UseVisualStyleBackColor = false;
            this.btnB_Update.Click += new System.EventHandler(this.btnB_Update_Click);
            // 
            // fViewBenif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(748, 353);
            this.Controls.Add(this.btnB_Update);
            this.Controls.Add(this.lblC_COCNo);
            this.Controls.Add(this.txtC_COCNo);
            this.Controls.Add(this.btnB_Delete);
            this.Controls.Add(this.btnB_Edit);
            this.Controls.Add(this.btnB_Add);
            this.Controls.Add(this.dgv_Benificiaries);
            this.Name = "fViewBenif";
            this.Text = "Beneficiaries";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Benificiaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Benificiaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMiddlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRelationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMobile;
        private System.Windows.Forms.Button btnB_Add;
        private System.Windows.Forms.Button btnB_Edit;
        private System.Windows.Forms.Button btnB_Delete;
        private System.Windows.Forms.TextBox txtC_COCNo;
        private System.Windows.Forms.Label lblC_COCNo;
        private System.Windows.Forms.Button btnB_Update;
    }
}