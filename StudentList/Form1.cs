using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentList
{
    public partial class frmStudent : Form
    {
        MyUtilities db = new MyUtilities();
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            PopulateUsers();
        }

        public void PopulateUsers()
        {
            lstUsers.Items.Clear();
            try
            {
                StringBuilder strQuery = new StringBuilder();
                strQuery.Append(" SELECT * FROM tblUsers ORDER BY LName ASC;");

                DataTable dt = db.SelectQuery(strQuery.ToString());

                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem itm = new ListViewItem(row["ID"].ToString());
                        itm.SubItems.Add(row["LName"].ToString());
                        itm.SubItems.Add(row["FName"].ToString());
                        itm.SubItems.Add(row["MName"].ToString());
                        itm.SubItems.Add(row["Address"].ToString());
                        lstUsers.Items.Add(itm);
                    }
                }
            }
            catch (Exception ex)
            {
                //lblnotification.Visible = true;
                //lblnotification.Text = "No Subjects Yet.";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                InsertUser();
            }else if(btnSave.Text == "Update")
            {
                UpdateUser();
            }
        }
        public void InsertUser()
        {
            try
            {
                if (IsValidToSave())
                {
                    string strQuery = " INSERT INTO tblUsers(LName, FName, Address, MName)" +
                   " VALUES(@LName, @FName, @Addr, @MName)";
                    var param = new Dictionary<string, string>
                        {
                            { "@LName" , txtLName.Text},
                            { "@FName" , txtFName.Text},
                            { "@Addr" , txtAddress.Text},
                            { "@MName", txtMName.Text},
                        };
                    int result = db.RunSQLCommand(strQuery.ToString(), param);
                    if (result > 0)
                    {
                        MessageBox.Show("Users successfully saved.");
                        txtLName.Text = txtFName.Text = txtAddress.Text = txtMName.Text = String.Empty;
                        btnSave.Text = "Save";
                        PopulateUsers();
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }
        public void UpdateUser()
        {
            try
            {
                if (IsValidToSave())
                {
                    string strQuery = " UPDATE tblUsers SET LName=@LName, FName=@FName, Address=@Addr, MName=@MName " +
                   " WHERE ID=@ID";
                    var param = new Dictionary<string, string>
                        {
                            { "@LName" , txtLName.Text},
                            { "@FName" , txtFName.Text},
                            { "@Addr" , txtAddress.Text},
                            { "@MName", txtMName.Text},
                            { "@ID", lstUsers.SelectedItems[0].SubItems[0].Text}
                        };
                    int result = db.RunSQLCommand(strQuery.ToString(), param);
                    if (result > 0)
                    {
                        MessageBox.Show("Users successfully updated.");
                        txtLName.Text = txtFName.Text = txtAddress.Text = txtMName.Text = String.Empty;
                        btnSave.Text = "Save";
                        PopulateUsers();
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }
        public bool IsValidToSave()
        {
            bool result = true;
            if(txtLName.Text == String.Empty && txtAddress.Text == String.Empty && txtFName.Text == String.Empty)
            {
                MessageBox.Show("Please fill up the whole form.");
                result = false;
            }
            return result;
        }

        private void lstUsers_Click(object sender, EventArgs e)
        {
            if (IsSelected(lstUsers))
            {
                btnSave.Text = "Update";
                ListViewItem item = lstUsers.SelectedItems[0];
                txtLName.Text = lstUsers.SelectedItems[0].SubItems[1].Text;
                txtFName.Text = lstUsers.SelectedItems[0].SubItems[2].Text;
                txtMName.Text = lstUsers.SelectedItems[0].SubItems[3].Text;
                txtAddress.Text = lstUsers.SelectedItems[0].SubItems[4].Text;
            }
        }
        public bool IsSelected(ListView lstView)
        {
            try
            {
                int index = lstView.SelectedIndices[0];
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lstUsers.Items.Clear();
            try
            {
                if (txtSearch.Text != "")
                {
                    StringBuilder strQuery = new StringBuilder();
                    strQuery.Append(" SELECT * FROM [dbo].[tblUsers] WHERE LName LIKE '%" + txtSearch.Text + "%'");
                    DataTable dt = db.SelectQuery(strQuery.ToString());
                    if (dt.Rows.Count != 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {

                            ListViewItem itm = new ListViewItem(row["ID"].ToString());
                            itm.SubItems.Add(row["LName"].ToString());
                            itm.SubItems.Add(row["FName"].ToString());
                            itm.SubItems.Add(row["MName"].ToString());
                            itm.SubItems.Add(row["Address"].ToString());
                            lstUsers.Items.Add(itm);
                        }
                    }
                }
                else
                {
                    PopulateUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void lstUsers_DoubleClick(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure, you want to delete this user ?. ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string strQuery = " DELETE FROM tblUsers WHERE ID=@ID";
                int result = db.RunSQLCommand(strQuery, new Dictionary<string, string> { { "@ID", lstUsers.SelectedItems[0].SubItems[0].Text } });
                if (result > 0)
                { MessageBox.Show("User successfully deleted");
                    PopulateUsers();
                }
            }
        }
    }
}
