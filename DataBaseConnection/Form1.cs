using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseConnection
{
    public partial class Form1 : Form
    {

        static DataBaseConnection DataBase;
        public Form1()
        {
            InitializeComponent();
            OpenConnection();
        }

        private void Update_List_button_Click(object sender, EventArgs e)
        {

            UpdateMoviesListBox();

        }

        private void OpenConnection()
        {
            DataBase = new DataBaseConnection(@"Data Source=DESKTOP-5V6E2DM;Initial Catalog=IBD5;Integrated Security=True");
            DataBase.OpenConection();
            MessageBox.Show("Connection Open  !");
            UpdateMoviesListBox();
            UpdateActorListBox();
        }

        private void UpdateMoviesListBox() //
        {
            List<Movie> movies = new List<Movie>();
            DataBase.updateMoviesList(movies);
            movie_listBox.Items.Clear();
            movie_listBox.Items.AddRange(movies.Cast<object>().ToArray());
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            if(!(DataBase is null))
                DataBase.CloseConection();
            Environment.Exit(1);
        }

        private void delete_movie_button_Click(object sender, EventArgs e)
        {
            DataBase.deleteMovie((Movie)movie_listBox.SelectedItem);
            UpdateMoviesListBox();
        }

        private void show_actors_button_Click(object sender, EventArgs e)
        {
            Movie movie = (Movie)movie_listBox.SelectedItem;
            FilmyAktorzyForm form = new FilmyAktorzyForm(movie, DataBase);
            form.ShowDialog();
        }

        private void add_movie_button_Click(object sender, EventArgs e)
        {
            AddMovie form = new AddMovie(DataBase);
            form.ShowDialog();
            UpdateMoviesListBox();

        }

        private void add_actor_Click(object sender, EventArgs e)
        {
            DodajAktora dodajAktoraForm = new DodajAktora(DataBase);
            dodajAktoraForm.ShowDialog();
            UpdateActorListBox();

        }

        private void UpdateActorListBox()
        {
            List<Actor> actors = new List<Actor>();
            DataBase.updateActorsList(actors);
            listBox2.Items.Clear();
            listBox2.Items.AddRange(actors.Cast<object>().ToArray());
        }

        private void delete_actor_button_Click(object sender, EventArgs e)
        {
            Actor actor = (Actor)listBox2.SelectedItem;
            DataBase.deleteActor(actor);
            UpdateActorListBox();
        }
    }
}
