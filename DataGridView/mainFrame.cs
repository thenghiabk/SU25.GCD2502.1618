using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L25_DataGridView
{

    public partial class mainFrame : Form
    {
        public List<Person> Persons = new List<Person>();
        public mainFrame()
        {
            Persons = new List<Person>() {
                new Person(){ PersonId = 1, Name = "John", Age = 32, Profession = "Professor"},
                new Person(){ PersonId = 2, Name = "Nancy", Age = 18, Profession = "Student"},
                new Person(){ PersonId = 3, Name = "David", Age = 20, Profession = "Staff"},
            };
            InitializeComponent();
            dgvPersons.DataSource = Persons;
            //dgvPersons.Columns["PersonId"].Visible = false;
        }
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
    }
}
