namespace WindowsFormsApplication1
{
    partial class fAECOInsured
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
            this.lblCI_ID = new System.Windows.Forms.Label();
            this.txtCI_CID = new System.Windows.Forms.TextBox();
            this.lblCI_Firstname = new System.Windows.Forms.Label();
            this.lblCI_Middlename = new System.Windows.Forms.Label();
            this.lblCI_Birthdate = new System.Windows.Forms.Label();
            this.lblCI_Relationship = new System.Windows.Forms.Label();
            this.txtCI_Firstname = new System.Windows.Forms.TextBox();
            this.lblCI_Lastname = new System.Windows.Forms.Label();
            this.txtCI_Middlename = new System.Windows.Forms.TextBox();
            this.txtCI_Lastname = new System.Windows.Forms.TextBox();
            this.cbCI_Month = new System.Windows.Forms.ComboBox();
            this.cbCI_Day = new System.Windows.Forms.ComboBox();
            this.cbCI_Year = new System.Windows.Forms.ComboBox();
            this.cbCI_Relationship = new System.Windows.Forms.ComboBox();
            this.btnCI_Save = new System.Windows.Forms.Button();
            this.lblCI_Add = new System.Windows.Forms.Label();
            this.lblCI_Edit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Co Insured";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCI_ID
            // 
            this.lblCI_ID.AutoSize = true;
            this.lblCI_ID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI_ID.Location = new System.Drawing.Point(28, 67);
            this.lblCI_ID.Name = "lblCI_ID";
            this.lblCI_ID.Size = new System.Drawing.Size(72, 22);
            this.lblCI_ID.TabIndex = 1;
            this.lblCI_ID.Text = "Client ID";
            // 
            // txtCI_CID
            // 
            this.txtCI_CID.Enabled = false;
            this.txtCI_CID.Location = new System.Drawing.Point(123, 66);
            this.txtCI_CID.Name = "txtCI_CID";
            this.txtCI_CID.Size = new System.Drawing.Size(100, 20);
            this.txtCI_CID.TabIndex = 12;
            // 
            // lblCI_Firstname
            // 
            this.lblCI_Firstname.AutoSize = true;
            this.lblCI_Firstname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI_Firstname.Location = new System.Drawing.Point(24, 108);
            this.lblCI_Firstname.Name = "lblCI_Firstname";
            this.lblCI_Firstname.Size = new System.Drawing.Size(85, 22);
            this.lblCI_Firstname.TabIndex = 13;
            this.lblCI_Firstname.Text = "Firstname";
            // 
            // lblCI_Middlename
            // 
            this.lblCI_Middlename.AutoSize = true;
            this.lblCI_Middlename.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI_Middlename.Location = new System.Drawing.Point(24, 147);
            this.lblCI_Middlename.Name = "lblCI_Middlename";
            this.lblCI_Middlename.Size = new System.Drawing.Size(99, 22);
            this.lblCI_Middlename.TabIndex = 14;
            this.lblCI_Middlename.Text = "Middlename";
            // 
            // lblCI_Birthdate
            // 
            this.lblCI_Birthdate.AutoSize = true;
            this.lblCI_Birthdate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI_Birthdate.Location = new System.Drawing.Point(304, 107);
            this.lblCI_Birthdate.Name = "lblCI_Birthdate";
            this.lblCI_Birthdate.Size = new System.Drawing.Size(80, 22);
            this.lblCI_Birthdate.TabIndex = 15;
            this.lblCI_Birthdate.Text = "Birthdate";
            // 
            // lblCI_Relationship
            // 
            this.lblCI_Relationship.AutoSize = true;
            this.lblCI_Relationship.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI_Relationship.Location = new System.Drawing.Point(304, 149);
            this.lblCI_Relationship.Name = "lblCI_Relationship";
            this.lblCI_Relationship.Size = new System.Drawing.Size(102, 22);
            this.lblCI_Relationship.TabIndex = 16;
            this.lblCI_Relationship.Text = "Relationship";
            // 
            // txtCI_Firstname
            // 
            this.txtCI_Firstname.Location = new System.Drawing.Point(123, 108);
            this.txtCI_Firstname.Name = "txtCI_Firstname";
            this.txtCI_Firstname.Size = new System.Drawing.Size(144, 20);
            this.txtCI_Firstname.TabIndex = 13;
            // 
            // lblCI_Lastname
            // 
            this.lblCI_Lastname.AutoSize = true;
            this.lblCI_Lastname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI_Lastname.Location = new System.Drawing.Point(29, 192);
            this.lblCI_Lastname.Name = "lblCI_Lastname";
            this.lblCI_Lastname.Size = new System.Drawing.Size(82, 22);
            this.lblCI_Lastname.TabIndex = 21;
            this.lblCI_Lastname.Text = "Lastname";
            // 
            // txtCI_Middlename
            // 
            this.txtCI_Middlename.Location = new System.Drawing.Point(123, 148);
            this.txtCI_Middlename.Name = "txtCI_Middlename";
            this.txtCI_Middlename.Size = new System.Drawing.Size(126, 20);
            this.txtCI_Middlename.TabIndex = 14;
            // 
            // txtCI_Lastname
            // 
            this.txtCI_Lastname.Location = new System.Drawing.Point(123, 193);
            this.txtCI_Lastname.Name = "txtCI_Lastname";
            this.txtCI_Lastname.Size = new System.Drawing.Size(135, 20);
            this.txtCI_Lastname.TabIndex = 15;
            // 
            // cbCI_Month
            // 
            this.cbCI_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCI_Month.FormattingEnabled = true;
            this.cbCI_Month.Location = new System.Drawing.Point(383, 108);
            this.cbCI_Month.Name = "cbCI_Month";
            this.cbCI_Month.Size = new System.Drawing.Size(101, 21);
            this.cbCI_Month.TabIndex = 16;
            // 
            // cbCI_Day
            // 
            this.cbCI_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCI_Day.FormattingEnabled = true;
            this.cbCI_Day.Location = new System.Drawing.Point(490, 108);
            this.cbCI_Day.Name = "cbCI_Day";
            this.cbCI_Day.Size = new System.Drawing.Size(84, 21);
            this.cbCI_Day.TabIndex = 17;
            // 
            // cbCI_Year
            // 
            this.cbCI_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCI_Year.FormattingEnabled = true;
            this.cbCI_Year.Location = new System.Drawing.Point(580, 107);
            this.cbCI_Year.Name = "cbCI_Year";
            this.cbCI_Year.Size = new System.Drawing.Size(75, 21);
            this.cbCI_Year.TabIndex = 18;
            // 
            // cbCI_Relationship
            // 
            this.cbCI_Relationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCI_Relationship.FormattingEnabled = true;
            this.cbCI_Relationship.Location = new System.Drawing.Point(412, 149);
            this.cbCI_Relationship.Name = "cbCI_Relationship";
            this.cbCI_Relationship.Size = new System.Drawing.Size(101, 21);
            this.cbCI_Relationship.TabIndex = 20;
            // 
            // btnCI_Save
            // 
            this.btnCI_Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCI_Save.Location = new System.Drawing.Point(574, 19);
            this.btnCI_Save.Name = "btnCI_Save";
            this.btnCI_Save.Size = new System.Drawing.Size(75, 38);
            this.btnCI_Save.TabIndex = 22;
            this.btnCI_Save.Text = "SAVE";
            this.btnCI_Save.UseVisualStyleBackColor = false;
            this.btnCI_Save.Click += new System.EventHandler(this.btnCI_Save_Click);
            // 
            // lblCI_Add
            // 
            this.lblCI_Add.AutoSize = true;
            this.lblCI_Add.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI_Add.Location = new System.Drawing.Point(38, 17);
            this.lblCI_Add.Name = "lblCI_Add";
            this.lblCI_Add.Size = new System.Drawing.Size(49, 27);
            this.lblCI_Add.TabIndex = 29;
            this.lblCI_Add.Text = "Add";
            // 
            // lblCI_Edit
            // 
            this.lblCI_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCI_Edit.AutoSize = true;
            this.lblCI_Edit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI_Edit.Location = new System.Drawing.Point(38, 17);
            this.lblCI_Edit.Name = "lblCI_Edit";
            this.lblCI_Edit.Size = new System.Drawing.Size(52, 27);
            this.lblCI_Edit.TabIndex = 30;
            this.lblCI_Edit.Text = "Edit";
            this.lblCI_Edit.Click += new System.EventHandler(this.label2_Click);
            // 
            // fAECOInsured
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(663, 258);
            this.Controls.Add(this.lblCI_Edit);
            this.Controls.Add(this.lblCI_Add);
            this.Controls.Add(this.btnCI_Save);
            this.Controls.Add(this.cbCI_Relationship);
            this.Controls.Add(this.cbCI_Year);
            this.Controls.Add(this.cbCI_Day);
            this.Controls.Add(this.cbCI_Month);
            this.Controls.Add(this.txtCI_Lastname);
            this.Controls.Add(this.lblCI_Lastname);
            this.Controls.Add(this.txtCI_Middlename);
            this.Controls.Add(this.txtCI_Firstname);
            this.Controls.Add(this.lblCI_Relationship);
            this.Controls.Add(this.lblCI_Birthdate);
            this.Controls.Add(this.lblCI_Middlename);
            this.Controls.Add(this.lblCI_Firstname);
            this.Controls.Add(this.txtCI_CID);
            this.Controls.Add(this.lblCI_ID);
            this.Controls.Add(this.label1);
            this.Name = "fAECOInsured";
            this.Text = "Co Insured";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCI_ID;
        private System.Windows.Forms.TextBox txtCI_CID;
        private System.Windows.Forms.Label lblCI_Firstname;
        private System.Windows.Forms.Label lblCI_Middlename;
        private System.Windows.Forms.Label lblCI_Birthdate;
        private System.Windows.Forms.Label lblCI_Relationship;
        private System.Windows.Forms.TextBox txtCI_Firstname;
        private System.Windows.Forms.Label lblCI_Lastname;
        private System.Windows.Forms.TextBox txtCI_Middlename;
        private System.Windows.Forms.TextBox txtCI_Lastname;
        private System.Windows.Forms.ComboBox cbCI_Month;
        private System.Windows.Forms.ComboBox cbCI_Day;
        private System.Windows.Forms.ComboBox cbCI_Year;
        private System.Windows.Forms.ComboBox cbCI_Relationship;
        private System.Windows.Forms.Button btnCI_Save;
        private System.Windows.Forms.Label lblCI_Add;
        private System.Windows.Forms.Label lblCI_Edit;
    }
}