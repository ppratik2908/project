using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Emp1";
                DataTable dt = DataGenericFile.GetTable(sql);
                dgvtable.DataSource = dt;
                dgvtable.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login fmlogin = new Login();
            if (fmlogin.ShowDialog() == DialogResult.OK)
            {
                string sql = " select username from users " + "where username = '" + fmlogin.Username + "' and " +
                    "password = '" + fmlogin.Passowrd + "' ";
                object obj = DataGenericFile.GetSingleAnswer(sql);
                if (obj != null)
                    MessageBox.Show("Login Succesfull....");
                else
                    MessageBox.Show("Try again..."); 
            }
        }
    }
}
