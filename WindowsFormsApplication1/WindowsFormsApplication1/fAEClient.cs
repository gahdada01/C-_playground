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
    public partial class fAEClient : Form
    {
        int option = 0;
        int zipcode, id;
        string cocno;
        string drMonth, drDay, drYear;
        string bdMonth, bdDay, bdYear;
        string firstname, middlename, lastname;
        string street, barangay, city;
        string company, position, gender, civilstatus;
        string dateReceived;
        string birthdate;
        string bloodtype, group;
        string status;
        string phone, mobile;
        int units;
        double amount;

        IEnumerable<int> day = Enumerable.Range(01, 31);
        IEnumerable<int> year = Enumerable.Range(1900, 150);

        //String command = "SELECT AUTO_INCREMENT FROM  INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='elect2' AND TABLE_NAME='tblusers'";   

        public fAEClient(int _option)
        {
            InitializeComponent();

            option = _option;
                
            loadComboBox();

            lblAdding.Show();
            lblEditing.Hide();

        }

        public fAEClient (int _id,int _zipcode,string _cocno,string _firstname, string _middlename, string _lastname,string _street,string _barangay,string _city,string _company,string _position,string _group, string _phone, string _mobile,int _units,double _amount,string _gender,string _status,string _bloodtype, string _civilstatus/*,string _dateReceived*/,string _birthdate)
        {
            InitializeComponent();

            try
            {
                txtCOCNo.Enabled = false;
                id = _id;
                //dateReceived = _dateReceived;
                bloodtype = _bloodtype;
                cocno = _cocno;
                firstname = _firstname;
                middlename = _middlename;
                lastname = _lastname;
                street = _street;
                barangay = _barangay;
                city = _city;
                company = _company;
                position = _position;
                gender = _gender;
                civilstatus = _civilstatus;
                bloodtype = _bloodtype;
                phone = _phone;
                mobile = _mobile;
                units = _units;
                status = _status;
                group = _group;
                zipcode = _zipcode;
                birthdate = _birthdate;

                string[] bDate = birthdate.Split('-');

                bdMonth = bDate[0];
                bdDay = bDate[1];
                bdYear = bDate[2];

                loadComboBox();
                loadForm();
                lblAdding.Hide();
                lblEditing.Show();
            }
            catch { }
        }

        private void loadComboBox()
        {
            

            cbBloodtype.Items.AddRange(new string[] { "","A", "B", "O", "AB" , "A+"});
            cbBloodtype.SelectedIndex = 0;

            cbMonth.Items.AddRange(new Level[] {new Level(){ Name = "Month", Number = 00 }, new Level() { Name = "January", Number = 01 }, new Level() { Name = "February", Number = 02 }, new Level() { Name = "March", Number = 03 }, new Level() { Name = "April", Number = 04 }, new Level() { Name = "May", Number = 05 }, new Level() { Name = "June", Number = 06 }, new Level() { Name = "July", Number = 07 }, new Level() { Name = "August", Number = 08 }, new Level() { Name = "September", Number = 09 }, new Level() { Name = "October", Number = 10 }, new Level() { Name = "November", Number = 11 }, new Level() { Name = "December", Number = 12 }});
            cbMonth.DisplayMember = "Name";
            cbMonth.SelectedIndex = 0;

            cbStatus.Items.AddRange(new string[] { "", "Active", "Inactive" });
            cbStatus.SelectedIndex = 0;

            cbGender.Items.AddRange(new string[] {"","Male","Female"});
            cbGender.SelectedIndex = 0;

            cbCivilStatus.Items.AddRange(new string[] { "", "Single", "Married","Widowed" });
            cbCivilStatus.SelectedIndex = 0;

            cbDay.Items.Add("Day");
            cbDay.Items.AddRange(day.Cast<object>().ToArray());
            cbDay.SelectedIndex= 0;
 
            cbYear.Items.Add("Year");            
            cbYear.Items.AddRange(year.Cast<object>().ToArray());
            cbYear.SelectedIndex = 0;
        }

        private void loadForm()
        {
            try
            {
                txtCOCNo.Text = cocno;
                txtFirstname.Text = firstname;
                txtMiddlename.Text = middlename;
                txtLastname.Text = lastname;
                txtStreet.Text = street;
                txtBarangay.Text = barangay;
                txtCity.Text = city;
                txtCompany.Text = company;
                txtPosition.Text = position;
                txtPhone.Text = phone;
                txtMobile.Text = mobile;
                txtUnits.Text = units.ToString();
                cbGender.SelectedItem = gender;
                cbStatus.SelectedItem = status;
                cbBloodtype.SelectedItem = bloodtype;
                cbCivilStatus.SelectedItem = civilstatus;
                cbMonth.SelectedIndex = int.Parse(bdMonth);
                cbDay.SelectedItem = int.Parse(bdDay);
                cbYear.SelectedItem = int.Parse(bdYear);
                txtGroup.Text = group;
                txtZipcode.Text = zipcode.ToString();
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var v = cbMonth.SelectedItem as Level;
            int _month = v.Number;
            string _birthdate = _month + "/" + cbDay.Text + "/" + cbYear.Text;

            bool _status = true;

            if (cbStatus.SelectedIndex == 1)
            {
                _status = true;
            }
            else
            {
                _status = false;
            }

            if (option == 1)
            {              

                DialogResult rs = MessageBox.Show("Do You Want To Add This Information?", "Confirmation", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    Client client = new Client(0, txtCOCNo.Text, txtFirstname.Text, txtMiddlename.Text, txtLastname.Text, DateTime.Today.ToString(), txtStreet.Text, txtBarangay.Text, txtCity.Text, int.Parse(txtZipcode.Text), txtCompany.Text, txtPosition.Text, cbGender.Text.ToString(), cbCivilStatus.Text.ToString(), cbBloodtype.Text, txtGroup.Text, double.Parse(txtAmount.Text), _status, _birthdate, txtMobile.Text, txtPhone.Text, int.Parse(txtUnits.Text));
                    client.AddNew();

                 
                                      
                }
                
            }
            else
            {
                
                DialogResult rs = MessageBox.Show("Do You Want To Edit This Information?", "Confirmation", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    Client client = new Client(id, txtCOCNo.Text, txtFirstname.Text, txtMiddlename.Text, txtLastname.Text, DateTime.Today.ToString(), txtStreet.Text, txtBarangay.Text, txtCity.Text, int.Parse(txtZipcode.Text), txtCompany.Text, txtPosition.Text, cbGender.Text.ToString(), cbCivilStatus.Text.ToString(), cbBloodtype.Text, txtGroup.Text, double.Parse(txtAmount.Text), _status, _birthdate, txtMobile.Text, txtPhone.Text, int.Parse(txtUnits.Text));
                    client.Edit();
                    fClient f1 = new fClient();
                    f1.loadTable();
                }
            }
            
        }
        

        private void txtUnits_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int unit1 = int.Parse(txtUnits.Text);
                double total = unit1 * 1500;
                txtAmount.Text = total.ToString();
            }
            catch
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblEditing_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }                          
    }

    public class Level
    {
        public Level(){

        }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}
