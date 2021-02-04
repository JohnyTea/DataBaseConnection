using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseConnection
{
    public partial class DodajAktora : Form
    {
        public DodajAktora()
        {
            InitializeComponent();
        }

        public DodajAktora(DataBaseConnection dataBase)
        {
            InitializeComponent();
            DataBase = dataBase;
        }

        public DataBaseConnection DataBase { get; }

        private void add_button_Click(object sender, EventArgs e)
        {
            string name = actor_name_textBox.Text;
            string lastName = actor_lastName_textBox.Text;
            DataBase.addActor(new Actor(0, name, lastName));
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
