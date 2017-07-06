using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class fViewBenif : Form
    {
        int id;
        string cocno;
        string firstname, lastname, middlename, relationship, address, birthdate, gender, phone, mobile,cid;

        public fViewBenif()
        {
            //InitializeComponent();
        }

        public fViewBenif(string _cocno)
        {
            InitializeComponent();
            cocno = _cocno;
            txtC_COCNo.Text = cocno;
            loadTable();
            defaultValue();
        }

        private void loadTable()
        {
            List<Benificiaries> ss = Benificiaries.GetUsers(cocno);
            int row =0;
            dgv_Benificiaries.RowCount = 1;

            try
            {
                foreach (DataGridViewRow row1 in dgv_Benificiaries.Rows)
                {
                    if (!row1.IsNewRow)
                        dgv_Benificiaries.Rows.Remove(row1);
                }


                foreach (Benificiaries s in ss)
                {
                    dgv_Benificiaries.Rows.Add();
                    dgv_Benificiaries[0, row].Value = s.Id;
                    dgv_Benificiaries[1, row].Value = s.CID;
                    dgv_Benificiaries[2, row].Value = s.Firstname;
                    dgv_Benificiaries[3, row].Value = s.Middlename;
                    dgv_Benificiaries[4, row].Value = s.Lastname;
                    dgv_Benificiaries[5, row].Value = s.Relationship;
                    dgv_Benificiaries[6, row].Value = s.Address;
                    dgv_Benificiaries[7, row].Value = s.BirthDate;
                    dgv_Benificiaries[8, row].Value = s.Gender;
                    dgv_Benificiaries[9, row].Value = s.Phone;
                    dgv_Benificiaries[10, row++].Value = s.Mobile;
                    //id = s.Id;
                }
            }
            catch  { }
            
        }
        private void defaultValue()
        {
            try
            {
                id = int.Parse(dgv_Benificiaries.Rows[0].Cells[0].Value.ToString());
                cid = dgv_Benificiaries.Rows[0].Cells[1].Value.ToString();
                firstname = dgv_Benificiaries.Rows[0].Cells[2].Value.ToString();
                middlename = dgv_Benificiaries.Rows[0].Cells[3].Value.ToString();
                lastname = dgv_Benificiaries.Rows[0].Cells[4].Value.ToString();
                relationship = dgv_Benificiaries.Rows[0].Cells[5].Value.ToString();
                address = dgv_Benificiaries.Rows[0].Cells[6].Value.ToString();
                birthdate = dgv_Benificiaries.Rows[0].Cells[7].Value.ToString();
                gender = dgv_Benificiaries.Rows[0].Cells[8].Value.ToString();
                phone = dgv_Benificiaries.Rows[0].Cells[9].Value.ToString();
                mobile = dgv_Benificiaries.Rows[0].Cells[10].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnB_Add_Click(object sender, EventArgs e)
        {
            fAEBenif badd = new fAEBenif(cocno);
            badd.ShowDialog();
        }

        private void dgv_Benificiaries_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                btnB_Edit.Enabled = true;
                btnB_Delete.Enabled = true;

                id = int.Parse(dgv_Benificiaries.SelectedRows[0].Cells[0].Value.ToString());
                cid = dgv_Benificiaries.SelectedRows[0].Cells[1].Value.ToString();
                firstname = dgv_Benificiaries.SelectedRows[0].Cells[2].Value.ToString();
                middlename = dgv_Benificiaries.SelectedRows[0].Cells[3].Value.ToString();
                lastname = dgv_Benificiaries.SelectedRows[0].Cells[4].Value.ToString();
                relationship = dgv_Benificiaries.SelectedRows[0].Cells[5].Value.ToString();
                address = dgv_Benificiaries.SelectedRows[0].Cells[6].Value.ToString();
                birthdate = dgv_Benificiaries.SelectedRows[0].Cells[7].Value.ToString();
                gender = dgv_Benificiaries.SelectedRows[0].Cells[8].Value.ToString();
                phone = dgv_Benificiaries.SelectedRows[0].Cells[9].Value.ToString();
                mobile = dgv_Benificiaries.SelectedRows[0].Cells[10].Value.ToString();
            }
            catch
            {
                btnB_Edit.Enabled = false;
                btnB_Delete.Enabled = false;

            }
        }

        private void btnB_Edit_Click(object sender, EventArgs e)
        {
            fAEBenif bedit = new fAEBenif(id,cid,firstname,middlename,lastname,relationship,address,birthdate,gender,phone,mobile);
            bedit.Show();
        }

        private void btnB_Delete_Click(object sender, EventArgs e)
        {
            Benificiaries b = new Benificiaries(id);

            DialogResult rs = MessageBox.Show("Do You Want To Delete This Information?", "Confirmation", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                b.DeleteB();
            }

        }

        private void btnB_Update_Click(object sender, EventArgs e)
        {
            loadTable();
        }

    }
}
