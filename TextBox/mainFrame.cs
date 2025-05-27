using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L25_TextBox
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
    }
}
