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
    public partial class fClient : Form
    {
        //string id2;
        int id;
        int option = 0;
        int zipcode;
        string cocno;
        string firstname, middlename, lastname;
        string street, barangay, city;
        string company, position, gender, civilstatus;
        string dateReceived;
        string birthdate;
        string bloodtype, group;
        string status;
        bool status2;
        string phone, mobile;
        int units;
        double amount;

        public fClient()
        {
            InitializeComponent();
            loadTable();
            defaultValue();
        }

        public void loadTable()
        {
            dgv_ClientInfo.Update();
            int row = 0;
            List<Client> ss = Client.GetUsers();
            dgv_ClientInfo.RowCount = 1;
            foreach (DataGridViewRow row1 in dgv_ClientInfo.Rows)
            {
                if (!row1.IsNewRow)
                    dgv_ClientInfo.Rows.Remove(row1);
            }

            foreach (Client s in ss)
            {

                dgv_ClientInfo.Rows.Add();
                dgv_ClientInfo[0, row].Value = s.COCNo;
                dgv_ClientInfo[1, row].Value = s.Firstname;
                dgv_ClientInfo[2, row].Value = s.Middlename;
                dgv_ClientInfo[3, row].Value = s.Lastname;
                dgv_ClientInfo[4, row].Value = s.BirthDate;
                dgv_ClientInfo[5, row].Value = s.Gender;
                dgv_ClientInfo[6, row].Value = s.CivilStatus;
                dgv_ClientInfo[7, row].Value = s.BloodType;
                dgv_ClientInfo[8, row].Value = s.Street;
                dgv_ClientInfo[9, row].Value = s.Barangay;
                dgv_ClientInfo[10, row].Value = s.City;
                dgv_ClientInfo[11, row].Value = s.Zipcode;
                dgv_ClientInfo[12, row].Value = s.Company;
                dgv_ClientInfo[13, row].Value = s.Position;
                dgv_ClientInfo[14, row].Value = s.Phone;
                dgv_ClientInfo[15, row].Value = s.Mobile;
                dgv_ClientInfo[16, row].Value = s.Units;
                dgv_ClientInfo[17, row].Value = s.Amount;
                dgv_ClientInfo[18, row].Value = s.Status;
                dgv_ClientInfo[19, row].Value = s.Group;
                dgv_ClientInfo[20, row].Value = s.DateReceived;
                dgv_ClientInfo[21, row++].Value = s.Id;
                
            }

        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            option = 1;
            fAEClient f2 = new fAEClient(option);
            f2.Show();            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            
            option = 2;
            if (status == "True")
            {
                status = "Active";
            }
            else
            {
                status = "Inactive";
            }

            fAEClient f2 = new fAEClient(id, zipcode, cocno, firstname, middlename, lastname, street, barangay, city, company, position, group, phone, mobile, units, amount, gender, status, bloodtype, civilstatus/*,dateReceived*/, birthdate);
            f2.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            
            Client cl = new Client();
            cl.Id = id;

            DialogResult rs = MessageBox.Show("Do You Want To Delete This Information?", "Confirmation", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {                
                cl.Delete();
                loadTable();
            }
        }
        private void defaultValue()
        {
            try
            {
                cocno = dgv_ClientInfo.Rows[0].Cells[0].Value.ToString();
                firstname = dgv_ClientInfo.Rows[0].Cells[1].Value.ToString();
                middlename = dgv_ClientInfo.Rows[0].Cells[2].Value.ToString();
                lastname = dgv_ClientInfo.Rows[0].Cells[3].Value.ToString();
                birthdate = dgv_ClientInfo.Rows[0].Cells[4].Value.ToString();
                gender = dgv_ClientInfo.Rows[0].Cells[5].Value.ToString();
                civilstatus = dgv_ClientInfo.Rows[0].Cells[6].Value.ToString();
                bloodtype = dgv_ClientInfo.Rows[0].Cells[7].Value.ToString();
                street = dgv_ClientInfo.Rows[0].Cells[8].Value.ToString();
                barangay = dgv_ClientInfo.Rows[0].Cells[9].Value.ToString();
                city = dgv_ClientInfo.Rows[0].Cells[10].Value.ToString();
                zipcode = int.Parse(dgv_ClientInfo.Rows[0].Cells[11].Value.ToString());
                company = dgv_ClientInfo.Rows[0].Cells[12].Value.ToString();
                position = dgv_ClientInfo.Rows[0].Cells[13].Value.ToString();
                phone = dgv_ClientInfo.Rows[0].Cells[14].Value.ToString();
                mobile = dgv_ClientInfo.Rows[0].Cells[15].Value.ToString();
                units = int.Parse(dgv_ClientInfo.Rows[0].Cells[16].Value.ToString());
                amount = double.Parse(dgv_ClientInfo.Rows[0].Cells[17].Value.ToString());
                status = dgv_ClientInfo.Rows[0].Cells[18].Value.ToString();
                group = dgv_ClientInfo.Rows[0].Cells[19].Value.ToString();
                //dateReceived= dgv_ClientInfo[0, 20].Value.ToString();
                id = int.Parse(dgv_ClientInfo.Rows[0].Cells[21].Value.ToString());
            }
            catch{ }
        }
        private void dgv_ClientInfo_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
                btn_VBenificiaries.Enabled = true;
                btn_VCoInsured.Enabled = true;

                cocno = dgv_ClientInfo.SelectedRows[0].Cells[0].Value.ToString();
                firstname = dgv_ClientInfo.SelectedRows[0].Cells[1].Value.ToString();
                middlename = dgv_ClientInfo.SelectedRows[0].Cells[2].Value.ToString();
                lastname = dgv_ClientInfo.SelectedRows[0].Cells[3].Value.ToString();
                birthdate = dgv_ClientInfo.SelectedRows[0].Cells[4].Value.ToString();
                gender = dgv_ClientInfo.SelectedRows[0].Cells[5].Value.ToString();
                civilstatus = dgv_ClientInfo.SelectedRows[0].Cells[6].Value.ToString();
                bloodtype = dgv_ClientInfo.SelectedRows[0].Cells[7].Value.ToString();
                street = dgv_ClientInfo.SelectedRows[0].Cells[8].Value.ToString();
                barangay = dgv_ClientInfo.SelectedRows[0].Cells[9].Value.ToString();
                city = dgv_ClientInfo.SelectedRows[0].Cells[10].Value.ToString();
                zipcode = int.Parse(dgv_ClientInfo.SelectedRows[0].Cells[11].Value.ToString());
                company= dgv_ClientInfo.SelectedRows[0].Cells[12].Value.ToString();
                position= dgv_ClientInfo.SelectedRows[0].Cells[13].Value.ToString();
                phone = dgv_ClientInfo.SelectedRows[0].Cells[14].Value.ToString();
                mobile = dgv_ClientInfo.SelectedRows[0].Cells[15].Value.ToString();
                units = int.Parse(dgv_ClientInfo.SelectedRows[0].Cells[16].Value.ToString());
                amount = double.Parse(dgv_ClientInfo.SelectedRows[0].Cells[17].Value.ToString());
                status = dgv_ClientInfo.SelectedRows[0].Cells[18].Value.ToString();
                group = dgv_ClientInfo.SelectedRows[0].Cells[19].Value.ToString();
                //dateReceived = dgv_ClientInfo.SelectedRows[0].Cells[20].Value.ToString();
                id = int.Parse(dgv_ClientInfo.SelectedRows[0].Cells[21].Value.ToString());
               
            }
            catch
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
                btn_VBenificiaries.Enabled = false;
                btn_VCoInsured.Enabled = false;
            }
        }

        private void btn_VBenificiaries_Click(object sender, EventArgs e)
        {
            fViewBenif b = new fViewBenif(cocno);
            b.ShowDialog();
        }
        private void btn_VCoInsured_Click(object sender, EventArgs e)
        {
            fViewCOI c = new fViewCOI(cocno);
            c.ShowDialog();
        }

        private void btnC_Update_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void fClient_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try{
            dgv_ClientInfo.Update();
            int row = 0;
            List<Client> ss = Client.GetUsers(textBox1.Text);
            dgv_ClientInfo.RowCount = 1;
            foreach (DataGridViewRow row1 in dgv_ClientInfo.Rows)
            {
                if (!row1.IsNewRow)
                    dgv_ClientInfo.Rows.Remove(row1);
            }

            if (textBox1.Text != "")
            {

                foreach (Client s in ss)
                {

                    dgv_ClientInfo.Rows.Add();
                    dgv_ClientInfo[0, row].Value = s.COCNo;
                    dgv_ClientInfo[1, row].Value = s.Firstname;
                    dgv_ClientInfo[2, row].Value = s.Middlename;
                    dgv_ClientInfo[3, row].Value = s.Lastname;
                    dgv_ClientInfo[4, row].Value = s.BirthDate;
                    dgv_ClientInfo[5, row].Value = s.Gender;
                    dgv_ClientInfo[6, row].Value = s.CivilStatus;
                    dgv_ClientInfo[7, row].Value = s.BloodType;
                    dgv_ClientInfo[8, row].Value = s.Street;
                    dgv_ClientInfo[9, row].Value = s.Barangay;
                    dgv_ClientInfo[10, row].Value = s.City;
                    dgv_ClientInfo[11, row].Value = s.Zipcode;
                    dgv_ClientInfo[12, row].Value = s.Company;
                    dgv_ClientInfo[13, row].Value = s.Position;
                    dgv_ClientInfo[14, row].Value = s.Phone;
                    dgv_ClientInfo[15, row].Value = s.Mobile;
                    dgv_ClientInfo[16, row].Value = s.Units;
                    dgv_ClientInfo[17, row].Value = s.Amount;
                    dgv_ClientInfo[18, row].Value = s.Status;
                    dgv_ClientInfo[19, row].Value = s.Group;
                    dgv_ClientInfo[20, row].Value = s.DateReceived;
                    dgv_ClientInfo[21, row++].Value = s.Id;
                }
            }
            else { loadTable(); }
            }
            catch {  }
        }
    }
}
