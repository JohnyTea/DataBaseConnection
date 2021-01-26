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
    public partial class FilmyAktorzyForm : Form
    {
        DataBaseConnection dataBase;
        public FilmyAktorzyForm(Movie movie, DataBaseConnection _dataBase)
        {
            InitializeComponent();
            dataBase = _dataBase;
            updateMovieActorList(movie);
            
        }

        private void updateMovieActorList(Movie movie)
        {
            List<FilmActor> list = new List<FilmActor>();
            dataBase.updateMovieActorList(movie, list);
            FilmyAktorzy_ListBox.Items.Clear();
            FilmyAktorzy_ListBox.Items.AddRange(list.Cast<object>().ToArray());


        }

        private void add_Actor_button_Click(object sender, EventArgs e)
        {

        }
    }
}
