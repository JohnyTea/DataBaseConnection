using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseConnection
{
    public class DataBaseConnection
    {
        private SqlConnection cnn;
        public DataBaseConnection(string connetionString)
        {
            cnn = new SqlConnection(connetionString);
        }

        public void OpenConection()
        {
            if(connectionIsOpen() == false)
                cnn.Open();
        }

        internal void updateCategoryList(List<Category> categories)
        {

            if (connectionIsOpen())
            {
                string querry = "select kategoriaID, NazwaKategorii from Kategorie";
                SqlCommand command = new SqlCommand(querry, cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int categoryiD = int.Parse(reader[0].ToString());
                        string categoryName = reader[1].ToString();
                        categories.Add(new Category(categoryiD, categoryName));
                    }
                }
            }
        }

        internal void addActorToMovie(Movie movie, Actor actor)
        {
            string querry = string.Format("select aktorID from dbo.Aktorzy where Imie = '{0}' AND Nazwisko = '{1}'", actor.ActorName, actor.ActorLastName);
            SqlCommand command = new SqlCommand(querry, cnn);

                actor.ActorID = int.Parse(command.ExecuteScalar().ToString());

                querry = string.Format("insert into FilmyAktorzy Values ({0}, {1})", movie.FilmID, actor.ActorID);
                command = new SqlCommand(querry, cnn);
                command.ExecuteNonQuery();
        }

        internal void deleteActorFromMovie(Actor actor, Movie movie)
        {

            string querry = string.Format("delete FilmyAktorzy where filmid = {0} AND aktorID = {1}", movie.FilmID, actor.ActorID);
            SqlCommand command = new SqlCommand(querry, cnn);
            command.ExecuteNonQuery();
        }

        internal void addActor(Actor actor)
        {
            if (connectionIsOpen())
            {
                string querry = string.Format("insert into Aktorzy values({0}, {1})", actor.ActorName, actor.ActorLastName);
                SqlCommand command = new SqlCommand(querry, cnn);
                command.ExecuteNonQuery();
            }
        }

        internal void deleteAllActorsFromMovie(Movie movie)
        {
            string querry = string.Format("delete FilmyAktorzy where filmid = {0}", movie.FilmID);
            SqlCommand command = new SqlCommand(querry, cnn);
            command.ExecuteNonQuery();
        }

        public void CloseConection()
        {
            if (connectionIsOpen() == true)
                cnn.Close();
        }

        internal void updateMovieActorList(Movie movie, List<FilmActor> list)
        {
            if (connectionIsOpen())
            {
                string querry = "select filmID, FilmyAktorzy.aktorID, CONCAT(Aktorzy.Imie, ' ' ,Aktorzy.Nazwisko) from FilmyAktorzy join Aktorzy on FilmyAktorzy.aktorID = Aktorzy.aktorID where FilmyAktorzy.filmID = " + movie.FilmID;

                SqlCommand command = new SqlCommand(querry, cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int filmID = int.Parse(reader[0].ToString());
                        int actorID = int.Parse(reader[1].ToString());
                        string actorName = reader[2].ToString();
                        list.Add(new FilmActor(filmID, actorID, actorName));
                    }
                }
            }
        }

        internal void add10ActorsToMovie(Movie movie, List<Actor> actors)
        {
            string querry = string.Format("execute dodajWieluFilmAktor '{0}'", movie.Tytul);
            for (int i = 0; i < actors.Count; i++)
            {
                querry += string.Format(",{0}", actors[i].ActorID);
            }
            SqlCommand command = new SqlCommand(querry, cnn);
            command.ExecuteNonQuery();
        }

        internal void AddMovie(Movie movie)
        {
            string querry = string.Format("insert into Filmy Values({0}, '{1}', '{2}', {3})", movie.Category.CategoryiD, movie.Tytul, movie.Rezyser, movie.RokProdukcji);
            SqlCommand command = new SqlCommand(querry, cnn);
            command.ExecuteNonQuery();
        }

        internal void deleteActor(Actor actor)
        {
            string querry = string.Format("delete from Aktorzy where Imie =  '{0}' AND Nazwisko = '{1}'", actor.ActorName, actor.ActorLastName);
            SqlCommand command = new SqlCommand(querry, cnn);
            command.ExecuteNonQuery();
        }

        internal void updateActorsList(List<Actor> actors)
        {
            if (connectionIsOpen())
            {
                string querry = "select aktorID, imie, nazwisko from Aktorzy";
                SqlCommand command = new SqlCommand(querry, cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int actorID = int.Parse(reader[0].ToString());
                        string actorName = reader[1].ToString();
                        string actorLastName = reader[2].ToString();

                        actors.Add(new Actor(actorID, actorName, actorLastName));
                    }
                }
            }
        }

        bool connectionIsOpen()
        {
            if (cnn.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        internal void updateMoviesList(List<Movie> movies)
        {
            if (connectionIsOpen())
            {
                string querry = "select filmID, cat.kategoriaID, cat.NazwaKategorii, tytul, rezyser, RokProdukcji from Filmy join Kategorie cat on cat.kategoriaID = Filmy.kategoriaID";
                SqlCommand command = new SqlCommand(querry, cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int filmID = int.Parse(reader[0].ToString());
                        Category kategoria = new Category(int.Parse(reader[1].ToString()), reader[2].ToString());
                        string tytul = reader[3].ToString();
                        string rezyser = reader[4].ToString();
                        int rokProdukcji = int.Parse(reader[5].ToString());
                        movies.Add(new Movie(filmID, kategoria, tytul, rezyser, rokProdukcji));
                    }
                }
            }
        }

        internal void deleteMovie(Movie movie)
        {
            if (connectionIsOpen())
            {
                string querry = "delete FilmyAktorzy where filmID = " + movie.FilmID;
                SqlCommand command = new SqlCommand(querry, cnn);
                command.ExecuteNonQuery();

                querry = "delete Filmy where Filmy.filmID = " + movie.FilmID;
                command = new SqlCommand(querry, cnn);
                command.ExecuteNonQuery();

            }
        }
    }
}
