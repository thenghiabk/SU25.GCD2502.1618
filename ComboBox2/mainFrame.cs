using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L25_ComboBox2
{
    public partial class mainFrame : Form
    {
        public mainFrame()
        {
            InitializeComponent();

            List<Country> countries = new List<Country>()
            {
                new Country(){ZipCode = "+084", Name = "Vietnam"},
                new Country(){ZipCode = "+082", Name = "China"},
                new Country(){ZipCode = "+1", Name = "USA"}

            };

            cbbZipCodes.DataSource = countries;
            cbbZipCodes.DisplayMember = "Name";
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

        private void btnSignUp_Click( object sender, EventArgs e )
        {
            string email = txtEmail.Text + cbbEmailDomains.Text;
            string phoneNumber = $"{txtPhoneNumber.Text}";
            MessageBox.Show( $"Your email is: {email}. Your phone number is: {phoneNumber}" );
        }

        private void cbbZipCodes_SelectedValueChanged( object sender, EventArgs e )
        {
            ComboBox cbb = sender as ComboBox;
            if ( cbb.SelectedValue != null )
            {
                Country selectedCountry = cbb.SelectedItem as Country;
                txtPhoneNumber.Text = $"({selectedCountry.ZipCode}) ";
            }
        }
    }

    public class Country
    {
        public string ZipCode { get; set; }
        public string Name { get; set; }
    }
}
