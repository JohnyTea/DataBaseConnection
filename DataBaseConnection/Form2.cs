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
        Movie Movie;
        public FilmyAktorzyForm(Movie movie, DataBaseConnection _dataBase)
        {
            InitializeComponent();
            dataBase = _dataBase;
            Movie = movie;
            updateMovieActorList(movie);
            UpdateActorComboBox();
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
            Actor actor = ((Actor)actor_comboBox1.SelectedItem);
            dataBase.addActorToMovie(Movie, actor);
            updateMovieActorList(Movie);
        }

        private void delete_Actor_Button_Click(object sender, EventArgs e)
        {
            Actor actor = (Actor)FilmyAktorzy_ListBox.SelectedItem;
            dataBase.deleteActorFromMovie(actor, Movie);
            updateMovieActorList(Movie);
        }

        private void Add_Many_Actors_Button_Click(object sender, EventArgs e)
        {
            List<Actor> actors = new List<Actor>();
            if(!(actor_comboBox1.SelectedItem is null))
                actors.Add((Actor)actor_comboBox1.SelectedItem);
            if (!(actor_comboBox2.SelectedItem is null))
                actors.Add((Actor)actor_comboBox2.SelectedItem);
            if (!(actor_comboBox3.SelectedItem is null))
                actors.Add((Actor)actor_comboBox3.SelectedItem);
            if (!(actor_comboBox4.SelectedItem is null))
                actors.Add((Actor)actor_comboBox4.SelectedItem); 
            if (!(actor_comboBox5.SelectedItem is null))
                actors.Add((Actor)actor_comboBox5.SelectedItem);
            if (!(actor_comboBox6.SelectedItem is null))
                actors.Add((Actor)actor_comboBox6.SelectedItem);
            if (!(actor_comboBox7.SelectedItem is null))
                actors.Add((Actor)actor_comboBox7.SelectedItem);
            if (!(actor_comboBox8.SelectedItem is null))
                actors.Add((Actor)actor_comboBox8.SelectedItem); 
            if (!(actor_comboBox9.SelectedItem is null))
                actors.Add((Actor)actor_comboBox9.SelectedItem); 
            if (!(actor_comboBox10.SelectedItem is null))
                actors.Add((Actor)actor_comboBox10.SelectedItem);


            dataBase.add10ActorsToMovie(Movie, actors);
            updateMovieActorList(Movie);
        }

        private void deleta_all_button_Click(object sender, EventArgs e)
        {
            dataBase.deleteAllActorsFromMovie(Movie);
            updateMovieActorList(Movie);

        }

        private void UpdateActorComboBox()
        {
            List<Actor> actors = new List<Actor>();
            dataBase.updateActorsList(actors);
            actor_comboBox1.Items.AddRange(actors.Cast<object>().ToArray());
            actor_comboBox2.Items.AddRange(actors.Cast<object>().ToArray());
            actor_comboBox3.Items.AddRange(actors.Cast<object>().ToArray());
            actor_comboBox4.Items.AddRange(actors.Cast<object>().ToArray());
            actor_comboBox5.Items.AddRange(actors.Cast<object>().ToArray());
            actor_comboBox6.Items.AddRange(actors.Cast<object>().ToArray());
            actor_comboBox7.Items.AddRange(actors.Cast<object>().ToArray());
            actor_comboBox8.Items.AddRange(actors.Cast<object>().ToArray());
            actor_comboBox9.Items.AddRange(actors.Cast<object>().ToArray());
            actor_comboBox10.Items.AddRange(actors.Cast<object>().ToArray());
        }

    }
}
