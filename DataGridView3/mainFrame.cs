using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L25_DataGridView3
{

    public partial class mainFrame : Form
    {
        public List<Person> Persons = new List<Person>();
        BindingSource bindingSource = new BindingSource();
        public mainFrame()
        {
            loadDatabase();

            bindingSource.DataSource = Persons;

            InitializeComponent();

            dgvPersons.DataSource = bindingSource;


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

        private void btnAdd_Click( object sender, EventArgs e )
        {
            Person newPerson = new Person()
            {
                Id = Convert.ToInt32( txtId.Text ),
                Name = txtName.Text,
                Age = Convert.ToInt32( txtAge.Text ),
                Profession = txtProfession.Text
            };


            bool idExists = Persons.Any( p => p.Id == newPerson.Id );

            if ( idExists )
            {
                MessageBox.Show( $"A person with the same Id = {newPerson.Id} already exists in the list." );
            }
            else
            {
                Persons.Add( newPerson );
                MessageBox.Show( "New person added to the list." );
                bindingSource.ResetBindings( false );
            }


        }

        private void btnUpdate_Click( object sender, EventArgs e )
        {
            foreach ( var person in Persons )
            {
                if ( person.Id == Convert.ToInt32( txtId.Text ) )
                {
                    person.Name = txtName.Text;
                    person.Age = Convert.ToInt32( txtAge.Text );
                    person.Profession = txtProfession.Text;

                    break;
                }
            }

            bindingSource.ResetBindings( false );
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            using ( StreamWriter sw = new StreamWriter( "output.txt" ) )
            {
                foreach ( Person person in Persons )
                {
                    string line = $"{person.Id}\t{person.Name}\t{person.Age}\t{person.Profession}";
                    sw.WriteLine( line );
                }
            }
        }

        private void btnLoad_Click( object sender, EventArgs e )
        {
            Persons.Clear();
            loadDatabase();

        }

        private void loadDatabase()
        {
            using ( StreamReader sr = new StreamReader( "output.txt" ) )
            {
                string line;
                while ( ( line = sr.ReadLine() ) != null )
                {
                    string[] data = line.Split( '\t' ); // Assuming the data is tab-separated

                    if ( data.Length == 4 ) // Ensure all properties are present
                    {
                        int id = int.Parse( data[0] );
                        string name = data[1];
                        int age = int.Parse( data[2] );
                        string profession = data[3];

                        Person person = new Person
                        {
                            Id = id,
                            Name = name,
                            Age = age,
                            Profession = profession
                        };

                        Persons.Add( person );
                    }
                }
            }

            bindingSource.ResetBindings( false );
        }

        private void btnDelete_Click( object sender, EventArgs e )
        {
            foreach ( var person in Persons )
            {
                if ( person.Id == Convert.ToInt32( txtId.Text ) )
                {
                    Persons.Remove( person );
                    break;
                }
            }

            bindingSource.ResetBindings( false );
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
