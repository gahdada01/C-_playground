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
    public partial class fAECOInsured : Form
    {
        IEnumerable<int> day = Enumerable.Range(01, 31);
        IEnumerable<int> year = Enumerable.Range(1900, 150);
        int id, option = 0;
        string firstname, middlename, lastname, relationship, address, birthdate, gender, phone, mobile, cid;
        string _month, _day, _year;

        public fAECOInsured(string _cocno)
        {
            InitializeComponent();
            loadCBCOInsured(); ;
            txtCI_CID.Text = _cocno;
            option = 1;
            lblCI_Add.Show();
            lblCI_Edit.Hide();
        }

        public fAECOInsured(int _id, string _cid, string _firstname, string _middlename, string _lastname,string _birthdate, string _relationship)
        {
            InitializeComponent();

            id = _id;
            cid = _cid;
            firstname = _firstname;
            middlename = _middlename;
            lastname = _lastname;
            relationship = _relationship;
            birthdate = _birthdate;
            option = 2;

            string[] date = birthdate.Split('-');
            _month = date[0];
            _day = date[1];
            _year = date[2];

            loadCBCOInsured();
            loadForm();
            option = 2;

            lblCI_Add.Hide();
            lblCI_Edit.Show();
        }

        private void loadCBCOInsured()
        {
            cbCI_Month.Items.AddRange(new Level[] { new Level() { Name = "Month", Number = 00 }, new Level() { Name = "January", Number = 01 }, new Level() { Name = "February", Number = 02 }, new Level() { Name = "March", Number = 03 }, new Level() { Name = "April", Number = 04 }, new Level() { Name = "May", Number = 05 }, new Level() { Name = "June", Number = 06 }, new Level() { Name = "July", Number = 07 }, new Level() { Name = "August", Number = 08 }, new Level() { Name = "September", Number = 09 }, new Level() { Name = "October", Number = 10 }, new Level() { Name = "November", Number = 11 }, new Level() { Name = "December", Number = 12 } });
            cbCI_Month.DisplayMember = "Name";
            cbCI_Month.SelectedIndex = 0;

            cbCI_Relationship.Items.AddRange(new string[] { "", "Brother", "Sister", "Mother", "Father" });
            cbCI_Relationship.SelectedIndex = 0;

            cbCI_Day.Items.Add("Day");
            cbCI_Day.Items.AddRange(day.Cast<object>().ToArray());
            cbCI_Day.SelectedIndex = 0;

            cbCI_Year.Items.Add("Year");
            cbCI_Year.Items.AddRange(year.Cast<object>().ToArray());
            cbCI_Year.SelectedIndex = 0;
        }
        private void loadForm()
        {
            
            txtCI_CID.Text = cid;
            txtCI_Firstname.Text = firstname;
            txtCI_Middlename.Text = middlename;
            txtCI_Lastname.Text = lastname;

            cbCI_Month.SelectedIndex = int.Parse(_month);
            cbCI_Day.SelectedItem = int.Parse(_day);
            cbCI_Year.SelectedItem = int.Parse(_year);
            cbCI_Relationship.SelectedItem = relationship;
        }

        private void btnCI_Save_Click(object sender, EventArgs e)
        {
            var v = cbCI_Month.SelectedItem as Level;
            int _month = v.Number;
            string birthdate2 = _month + "/" + cbCI_Day.Text + "/" + cbCI_Year.Text;
            if (option == 1)
            {
                DialogResult rs = MessageBox.Show("Do You Want To Add This Information?", "Confirmation", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    COInsured ben = new COInsured(0, txtCI_CID.Text, txtCI_Firstname.Text, txtCI_Middlename.Text, txtCI_Lastname.Text, birthdate2, cbCI_Relationship.Text);
                    ben.AddNewCI();
                }
            }
            else
            {
                DialogResult rs = MessageBox.Show("Do You Want To Edit This Information?", "Confirmation", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    COInsured ben = new COInsured(id, txtCI_CID.Text, txtCI_Firstname.Text, txtCI_Middlename.Text, txtCI_Lastname.Text, birthdate2, cbCI_Relationship.Text);
                    ben.EditCI();
                    //MessageBox.Show(_birthdate, "df", MessageBoxButtons.YesNo);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }

}
