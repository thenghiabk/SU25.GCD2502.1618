using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L25_DataGridView2
{

    public partial class mainFrame : Form
    {
        public List<Person> Persons = new List<Person>();
        public mainFrame()
        {
            Persons = new List<Person>() {
                new Person(){ Id = 1, Name = "John", Age = 32, Profession = "Professor"},
                new Person(){ Id = 2, Name = "Nancy", Age = 18, Profession = "Student"},
                new Person(){ Id = 3, Name = "David", Age = 20, Profession = "Staff"},
            };
            InitializeComponent();
            dgvPersons.DataSource = Persons;
            //dgvPersons.Columns["Id"].Visible = false;
        }

        private void dgvPersons_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            try
            {
                Person selectedRow = dgvPersons.SelectedRows[0].DataBoundItem as Person;

                if ( selectedRow != null )
                {
                    txtId.Text = selectedRow.Id.ToString();
                    txtName.Text = selectedRow.Name;
                    txtAge.Text = selectedRow.Age.ToString();
                    txtProfession.Text = selectedRow.Profession;
                }

            }
            catch ( Exception ex )
            {
                MessageBox.Show( "Some error occurred!" + ex.Message + " - " + ex.Source );
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
    }
}
