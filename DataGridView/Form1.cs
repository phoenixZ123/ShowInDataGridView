using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public List<Person> People { get; set; }
        public Form1()
        {
            People = GetPeople();
            InitializeComponent();
        }
        private List<Person> GetPeople()
        {
            var list = new List<Person>();
            list.Add(new Person() { 
                PersonId = 1,
                Name = "waiaustin1",
                Surname = "Surname 1",
                Profession = "Profession 1" });
            list.Add(new Person()
            {
                PersonId = 2,
                Name = "waiaustin2",
                Surname = "Surname 2",
                Profession = "Profession 2"
            });
            list.Add(new Person()
            {
                PersonId = 3,
                Name = "waiaustin3",
                Surname = "Surname 3",
                Profession = "Profession 3"
            });
            return list;
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            var people = this.People;

            dataGridView1.DataSource = people;


        }
    }
}
