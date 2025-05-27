using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L25_CheckBox
{
    public partial class mainFrame : Form
    {
        public mainFrame()
        {
            InitializeComponent();
        }

        private void btnExit_Click( object sender, EventArgs e )
        {
            DialogResult dr = MessageBox.Show( "Do you want to close it?", "Confirmation", MessageBoxButtons.YesNo );
            if ( dr == DialogResult.Yes )
            {
                MessageBox.Show( "See you again!", "Exit" );
                this.Close();
            }
        }

        private void btnLogin_Click( object sender, EventArgs e )
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            MessageBox.Show( $"You've entered username: {username}, password: {password}" );


        }

        private void cbAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgree.Checked == true)
            {
                btnSignUp.Enabled = true;
            }
            else
            {
                btnSignUp.Enabled = false;
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            String gender = "";

            if (rdMale.Checked == true)
            {
                gender = "Male";
            }
            else if (rdFemale.Checked == true)
            {
                gender = "Female";
            }

            MessageBox.Show($"You've registered with username: {username}, password: {password}, gender: {gender}");
        }
    }
}
