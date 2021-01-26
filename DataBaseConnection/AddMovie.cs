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
    public partial class AddMovie : Form
    {

        DataBaseConnection DataBase;
        public AddMovie(DataBaseConnection _dataBase)
        {
            InitializeComponent();
            DataBase = _dataBase;
            List<Category> categories = new List<Category>();
            DataBase.updateCategoryList(categories);
            cats_comboBox1.Items.AddRange(categories.Cast<object>().ToArray());
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string title = tytuł_TextBox.Text;
            string category = cats_comboBox1.SelectedItem.ToString();
            string rezyser = rezyser_TextBox.Text;
            int rok_produkcji = int.Parse(RokProdukcji_TextBox.Text);

            Movie movie = new Movie(0, category, title, rezyser, rok_produkcji);
            DataBase.AddMovie(movie);
        }

        private void cencel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
