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
    public partial class fViewCOI : Form
    {
        int id;
        string cocno;
        string firstname, lastname, middlename, relationship, address, birthdate, gender, phone, mobile, cid;

        public fViewCOI()
        {
            //InitializeComponent();
        }

        public fViewCOI(string _cocno)
        {
            InitializeComponent();
            cocno = _cocno;
            txtCOI_COCNo.Text = cocno;
            loadTable();
            defaultValue();
        }

        private void loadTable()
        {
            List<COInsured> ss = COInsured.GetUsers(cocno);
            int row = 0;
            dgv_COInsured.RowCount = 1;

            try
            {
                foreach (DataGridViewRow row1 in dgv_COInsured.Rows)
                {
                    if (!row1.IsNewRow)
                        dgv_COInsured.Rows.Remove(row1);
                }


                foreach (COInsured s in ss)
                {
                    dgv_COInsured.Rows.Add();
                    dgv_COInsured[0, row].Value = s.Id;
                    dgv_COInsured[1, row].Value = s.CID;
                    dgv_COInsured[2, row].Value = s.Firstname;
                    dgv_COInsured[3, row].Value = s.Middlename;
                    dgv_COInsured[4, row].Value = s.Lastname;
                    dgv_COInsured[5, row].Value = s.BirthDate;
                    dgv_COInsured[6, row++].Value = s.Relationship;
                    //id = s.Id;
                }
            }
            catch
            {
            }

        }
        private void defaultValue()
        {
            try
            {
                id = int.Parse(dgv_COInsured.Rows[0].Cells[0].Value.ToString());
                cid = dgv_COInsured.Rows[0].Cells[1].Value.ToString();
                firstname = dgv_COInsured.Rows[0].Cells[2].Value.ToString();
                middlename = dgv_COInsured.Rows[0].Cells[3].Value.ToString();
                lastname = dgv_COInsured.Rows[0].Cells[4].Value.ToString();
                birthdate = dgv_COInsured.Rows[0].Cells[5].Value.ToString();
                relationship = dgv_COInsured.Rows[0].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnCOI_Add_Click(object sender, EventArgs e)
        {
            fAECOInsured badd = new fAECOInsured(cocno);
            badd.ShowDialog();
        }

        private void dgv_COInsured_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                btnCOI_Edit.Enabled = true;
                btnCOI_Delete.Enabled = true;

                id = int.Parse(dgv_COInsured.SelectedRows[0].Cells[0].Value.ToString());
                cid = dgv_COInsured.SelectedRows[0].Cells[1].Value.ToString();
                firstname = dgv_COInsured.SelectedRows[0].Cells[2].Value.ToString();
                middlename = dgv_COInsured.SelectedRows[0].Cells[3].Value.ToString();
                lastname = dgv_COInsured.SelectedRows[0].Cells[4].Value.ToString();
                birthdate = dgv_COInsured.SelectedRows[0].Cells[5].Value.ToString();
                relationship = dgv_COInsured.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch
            {
                btnCOI_Edit.Enabled = false;
                btnCOI_Delete.Enabled = false;

            }
        }

        private void btnCOI_Edit_Click(object sender, EventArgs e)
        {
            fAECOInsured bedit = new fAECOInsured(id, cid, firstname, middlename, lastname, birthdate, relationship);
            bedit.Show();
        }

        private void btnCOI_Delete_Click(object sender, EventArgs e)
        {
            COInsured b = new COInsured(id);

            DialogResult rs = MessageBox.Show("Do You Want To Delete This Information?", "Confirmation", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                b.DeleteCI();
                loadTable();
            }
        }

        

        private void btnCI_Update_Click(object sender, EventArgs e)
        {
            loadTable();
        }

    }
}
