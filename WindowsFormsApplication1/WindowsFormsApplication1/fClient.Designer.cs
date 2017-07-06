namespace WindowsFormsApplication1
{
    partial class fClient
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
            this.dgv_ClientInfo = new System.Windows.Forms.DataGridView();
            this.cCOCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCivilStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBloodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBarangay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_VBenificiaries = new System.Windows.Forms.Button();
            this.btn_VCoInsured = new System.Windows.Forms.Button();
            this.btnC_Update = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ClientInfo
            // 
            this.dgv_ClientInfo.AllowUserToResizeRows = false;
            this.dgv_ClientInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ClientInfo.BackgroundColor = System.Drawing.Color.Snow;
            this.dgv_ClientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ClientInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCOCNo,
            this.cFirstName,
            this.cMiddleName,
            this.cLastName,
            this.cBirthDate,
            this.cGender,
            this.cCivilStatus,
            this.cBloodType,
            this.cStreet,
            this.cBarangay,
            this.cCity,
            this.cZipCode,
            this.cCompany,
            this.cPosition,
            this.cPhone,
            this.cMobile,
            this.cUnits,
            this.cAmount,
            this.cStatus,
            this.cGroup,
            this.cDateReceived,
            this.cID});
            this.dgv_ClientInfo.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_ClientInfo.Location = new System.Drawing.Point(6, 53);
            this.dgv_ClientInfo.MultiSelect = false;
            this.dgv_ClientInfo.Name = "dgv_ClientInfo";
            this.dgv_ClientInfo.ReadOnly = true;
            this.dgv_ClientInfo.RowHeadersVisible = false;
            this.dgv_ClientInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ClientInfo.Size = new System.Drawing.Size(1229, 269);
            this.dgv_ClientInfo.TabIndex = 0;
            this.dgv_ClientInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_ClientInfo_MouseClick);
            // 
            // cCOCNo
            // 
            this.cCOCNo.HeaderText = "COC No.";
            this.cCOCNo.Name = "cCOCNo";
            this.cCOCNo.ReadOnly = true;
            // 
            // cFirstName
            // 
            this.cFirstName.HeaderText = "FirstName";
            this.cFirstName.Name = "cFirstName";
            this.cFirstName.ReadOnly = true;
            // 
            // cMiddleName
            // 
            this.cMiddleName.HeaderText = "MiddleName";
            this.cMiddleName.Name = "cMiddleName";
            this.cMiddleName.ReadOnly = true;
            // 
            // cLastName
            // 
            this.cLastName.HeaderText = "LastName";
            this.cLastName.Name = "cLastName";
            this.cLastName.ReadOnly = true;
            // 
            // cBirthDate
            // 
            this.cBirthDate.HeaderText = "BirthDate";
            this.cBirthDate.Name = "cBirthDate";
            this.cBirthDate.ReadOnly = true;
            // 
            // cGender
            // 
            this.cGender.HeaderText = "Gender";
            this.cGender.Name = "cGender";
            this.cGender.ReadOnly = true;
            // 
            // cCivilStatus
            // 
            this.cCivilStatus.HeaderText = "CivilStatus";
            this.cCivilStatus.Name = "cCivilStatus";
            this.cCivilStatus.ReadOnly = true;
            // 
            // cBloodType
            // 
            this.cBloodType.HeaderText = "BloodType";
            this.cBloodType.Name = "cBloodType";
            this.cBloodType.ReadOnly = true;
            // 
            // cStreet
            // 
            this.cStreet.HeaderText = "Street";
            this.cStreet.Name = "cStreet";
            this.cStreet.ReadOnly = true;
            // 
            // cBarangay
            // 
            this.cBarangay.HeaderText = "Barangay";
            this.cBarangay.Name = "cBarangay";
            this.cBarangay.ReadOnly = true;
            // 
            // cCity
            // 
            this.cCity.HeaderText = "Municipality/City";
            this.cCity.Name = "cCity";
            this.cCity.ReadOnly = true;
            // 
            // cZipCode
            // 
            this.cZipCode.HeaderText = "ZipCode";
            this.cZipCode.Name = "cZipCode";
            this.cZipCode.ReadOnly = true;
            // 
            // cCompany
            // 
            this.cCompany.HeaderText = "Company";
            this.cCompany.Name = "cCompany";
            this.cCompany.ReadOnly = true;
            // 
            // cPosition
            // 
            this.cPosition.HeaderText = "Position";
            this.cPosition.Name = "cPosition";
            this.cPosition.ReadOnly = true;
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
            // cUnits
            // 
            this.cUnits.HeaderText = "Units";
            this.cUnits.Name = "cUnits";
            this.cUnits.ReadOnly = true;
            // 
            // cAmount
            // 
            this.cAmount.HeaderText = "Amount";
            this.cAmount.Name = "cAmount";
            this.cAmount.ReadOnly = true;
            // 
            // cStatus
            // 
            this.cStatus.HeaderText = "Status";
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            // 
            // cGroup
            // 
            this.cGroup.HeaderText = "Group";
            this.cGroup.Name = "cGroup";
            this.cGroup.ReadOnly = true;
            // 
            // cDateReceived
            // 
            this.cDateReceived.HeaderText = "DateReceived";
            this.cDateReceived.Name = "cDateReceived";
            this.cDateReceived.ReadOnly = true;
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Visible = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Add.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(467, 344);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Lime;
            this.btn_Edit.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(548, 344);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Delete.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(629, 344);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_VBenificiaries
            // 
            this.btn_VBenificiaries.BackColor = System.Drawing.Color.Aqua;
            this.btn_VBenificiaries.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VBenificiaries.Location = new System.Drawing.Point(454, 11);
            this.btn_VBenificiaries.Name = "btn_VBenificiaries";
            this.btn_VBenificiaries.Size = new System.Drawing.Size(106, 23);
            this.btn_VBenificiaries.TabIndex = 4;
            this.btn_VBenificiaries.Text = "Benificiaries";
            this.btn_VBenificiaries.UseVisualStyleBackColor = false;
            this.btn_VBenificiaries.Click += new System.EventHandler(this.btn_VBenificiaries_Click);
            // 
            // btn_VCoInsured
            // 
            this.btn_VCoInsured.BackColor = System.Drawing.Color.Yellow;
            this.btn_VCoInsured.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VCoInsured.Location = new System.Drawing.Point(679, 11);
            this.btn_VCoInsured.Name = "btn_VCoInsured";
            this.btn_VCoInsured.Size = new System.Drawing.Size(106, 23);
            this.btn_VCoInsured.TabIndex = 5;
            this.btn_VCoInsured.Text = "Co Insured";
            this.btn_VCoInsured.UseVisualStyleBackColor = false;
            this.btn_VCoInsured.Click += new System.EventHandler(this.btn_VCoInsured_Click);
            // 
            // btnC_Update
            // 
            this.btnC_Update.BackColor = System.Drawing.Color.Gray;
            this.btnC_Update.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC_Update.Location = new System.Drawing.Point(710, 344);
            this.btnC_Update.Name = "btnC_Update";
            this.btnC_Update.Size = new System.Drawing.Size(75, 23);
            this.btnC_Update.TabIndex = 6;
            this.btnC_Update.Text = "Refresh";
            this.btnC_Update.UseVisualStyleBackColor = false;
            this.btnC_Update.Click += new System.EventHandler(this.btnC_Update_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search";
            // 
            // fClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1247, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnC_Update);
            this.Controls.Add(this.btn_VCoInsured);
            this.Controls.Add(this.btn_VBenificiaries);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_ClientInfo);
            this.Name = "fClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.fClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ClientInfo;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_VBenificiaries;
        private System.Windows.Forms.Button btn_VCoInsured;
        private System.Windows.Forms.Button btnC_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOCNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCivilStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBloodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBarangay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}