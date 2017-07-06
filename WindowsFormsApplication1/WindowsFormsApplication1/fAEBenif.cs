using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class fAEBenif : Form
    {
        IEnumerable<int> day = Enumerable.Range(01, 31);
        IEnumerable<int> year = Enumerable.Range(1900, 150);
        int id,option=0;
        string firstname, middlename, lastname, relationship, address, birthdate, gender, phone, mobile, cid;
        string _month, _day, _year;
        public fAEBenif(string _cocno)
        {
            InitializeComponent();
            loadCBBeneficiary();
            txtB_CID.Text = _cocno;
            option = 1;

            lblB_Add.Show();
            lblB_Edit.Hide();
        }

        public fAEBenif(int _id, string _cid, string _firstname, string _middlename, string _lastname, string _relationship, string _address,string _birthdate, string _gender, string _phone, string _mobile)
        {
            InitializeComponent();
            try
            {
                id = _id;
                cid = _cid;
                firstname = _firstname;
                middlename = _middlename;
                lastname = _lastname;
                relationship = _relationship;
                address = _address;
                birthdate = _birthdate;
                gender = _gender;
                phone = _phone;
                mobile = _mobile;
                option = 2;

                string[] date = birthdate.Split('-');
                _month = date[0];
                _day = date[1];
                _year = date[2];

                loadCBBeneficiary();
                loadForm();
                option = 2;

                lblB_Add.Hide();
                lblB_Edit.Show();
            }
            catch { }
        }

        private void loadCBBeneficiary()
        {
            cbB_Month.Items.AddRange(new Level[] { new Level() { Name = "Month", Number = 00 }, new Level() { Name = "January", Number = 01 }, new Level() { Name = "February", Number = 02 }, new Level() { Name = "March", Number = 03 }, new Level() { Name = "April", Number = 04 }, new Level() { Name = "May", Number = 05 }, new Level() { Name = "June", Number = 06 }, new Level() { Name = "July", Number = 07 }, new Level() { Name = "August", Number = 08 }, new Level() { Name = "September", Number = 09 }, new Level() { Name = "October", Number = 10 }, new Level() { Name = "November", Number = 11 }, new Level() { Name = "December", Number = 12 } });
            cbB_Month.DisplayMember = "Name";
            cbB_Month.SelectedIndex = 0;

            cbB_Gender.Items.AddRange(new string[] { "", "Male", "Female" });
            cbB_Gender.SelectedIndex = 0;

            cbB_Relationship.Items.AddRange(new string[] { "", "Brother", "Sister","Mother","Father" });
            cbB_Relationship.SelectedIndex = 0;

            cbB_Day.Items.Add("Day");
            cbB_Day.Items.AddRange(day.Cast<object>().ToArray());
            cbB_Day.SelectedIndex = 0;

            cbB_Year.Items.Add("Year");
            cbB_Year.Items.AddRange(year.Cast<object>().ToArray());
            cbB_Year.SelectedIndex = 0;
        }
        private void loadForm()
        {
            txtB_CID.Text = cid;
            txtB_Firstname.Text = firstname;
            txtB_Middlename.Text = middlename;
            txtB_Lastname.Text = lastname;
            txtB_Address.Text = address;
            cbB_Month.SelectedIndex = int.Parse(_month);
            cbB_Day.SelectedItem = int.Parse(_day);
            cbB_Year.SelectedItem = int.Parse(_year);
            cbB_Gender.SelectedItem = gender;
            txtB_Phone.Text = phone;
            txtB_Mobile.Text = mobile;
            cbB_Relationship.SelectedItem = relationship;
        }
        private void btnB_Save_Click(object sender, EventArgs e)
        {
             var v = cbB_Month.SelectedItem as Level;
             int _month = v.Number;
             string birthdate2 = _month + "/" + cbB_Day.Text + "/" + cbB_Year.Text;
             if (option == 1)
             {
                 DialogResult rs = MessageBox.Show("Do You Want To Add This Information?", "Confirmation", MessageBoxButtons.YesNo);
                 if (rs == DialogResult.Yes)
                 {
                     Benificiaries ben = new Benificiaries(0,txtB_CID.Text, txtB_Firstname.Text, txtB_Middlename.Text,txtB_Lastname.Text, cbB_Relationship.Text, txtB_Address.Text, birthdate2, cbB_Gender.Text, txtB_Phone.Text, txtB_Mobile.Text);
                     ben.AddNewB();
                     // MessageBox.Show(_birthdate, "Confirmation", MessageBoxButtons.YesNo);
                 }
             }
             else
             {
                 DialogResult rs = MessageBox.Show("Do You Want To Edit This Information?", "Confirmation", MessageBoxButtons.YesNo);
                 if (rs == DialogResult.Yes)
                 {
                     Benificiaries ben = new Benificiaries(id,txtB_CID.Text, txtB_Firstname.Text, txtB_Middlename.Text,txtB_Lastname.Text, cbB_Relationship.Text, txtB_Address.Text, birthdate2, cbB_Gender.Text, txtB_Phone.Text, txtB_Mobile.Text);
                     ben.EditB();
                     
                     //MessageBox.Show(_birthdate, "df", MessageBoxButtons.YesNo);
                     //fClient f1 = new fClient();
                     //this.Dispose();
                     //f1.ShowDialog();
                 }
             }
         }

        private void txtB_Middlename_TextChanged(object sender, EventArgs e)
        {

        }

    }
       
}
