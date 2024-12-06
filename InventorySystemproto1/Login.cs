using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemproto1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if(btnShowPassword.Text == "Show")
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                
                txtPassword.UseSystemPasswordChar = false;
              
            }
        }
    }
}
