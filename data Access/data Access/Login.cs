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
    public partial class Login : Form
    {
        public string Username
        {
            get { return txtUsername.Text;}
        }
        public string Passowrd
        {
            get { return txtpassword.Text; }
        }

        public Login()
        {
            InitializeComponent();
        }
    }
}
