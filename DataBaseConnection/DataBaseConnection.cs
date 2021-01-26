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
            throw new NotImplementedException();
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

        internal void AddMovie(Movie movie)
        {
            throw new NotImplementedException();


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
                string querry = "select filmID, cat.NazwaKategorii, tytul, rezyser, RokProdukcji from Filmy join Kategorie cat on cat.kategoriaID = Filmy.kategoriaID";
                SqlCommand command = new SqlCommand(querry, cnn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int filmID = int.Parse(reader[0].ToString());
                        string kategoria = reader[1].ToString();
                        string tytul = reader[2].ToString();
                        string rezyser = reader[3].ToString();
                        int rokProdukcji = int.Parse(reader[4].ToString());
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
