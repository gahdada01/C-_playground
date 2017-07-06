namespace WindowsFormsApplication1
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
            this.btn_VBeneficiaries = new System.Windows.Forms.Button();
            this.btn_VCoInsured = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ClientInfo
            // 
            this.dgv_ClientInfo.AllowUserToResizeRows = false;
            this.dgv_ClientInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgv_ClientInfo.Location = new System.Drawing.Point(6, 85);
            this.dgv_ClientInfo.MultiSelect = false;
            this.dgv_ClientInfo.Name = "dgv_ClientInfo";
            this.dgv_ClientInfo.ReadOnly = true;
            this.dgv_ClientInfo.RowHeadersVisible = false;
            this.dgv_ClientInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ClientInfo.Size = new System.Drawing.Size(930, 269);
            this.dgv_ClientInfo.TabIndex = 0;
            this.dgv_ClientInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_ClientInfo_MouseClick);
            // 
            // cCOCNo
            // 
            this.cCOCNo.HeaderText = "COCNo";
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
            this.btn_Add.Location = new System.Drawing.Point(87, 25);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(202, 25);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(326, 25);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_VBeneficiaries
            // 
            this.btn_VBeneficiaries.Location = new System.Drawing.Point(528, 25);
            this.btn_VBeneficiaries.Name = "btn_VBeneficiaries";
            this.btn_VBeneficiaries.Size = new System.Drawing.Size(142, 23);
            this.btn_VBeneficiaries.TabIndex = 4;
            this.btn_VBeneficiaries.Text = "View Beneficiaries";
            this.btn_VBeneficiaries.UseVisualStyleBackColor = true;
            // 
            // btn_VCoInsured
            // 
            this.btn_VCoInsured.Location = new System.Drawing.Point(712, 25);
            this.btn_VCoInsured.Name = "btn_VCoInsured";
            this.btn_VCoInsured.Size = new System.Drawing.Size(141, 23);
            this.btn_VCoInsured.TabIndex = 5;
            this.btn_VCoInsured.Text = "View CoInsured";
            this.btn_VCoInsured.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 366);
            this.Controls.Add(this.btn_VCoInsured);
            this.Controls.Add(this.btn_VBeneficiaries);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_ClientInfo);
            this.Name = "Form1";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ClientInfo;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_VBeneficiaries;
        private System.Windows.Forms.Button btn_VCoInsured;
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
    }
}