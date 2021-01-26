namespace DataBaseConnection
{
    public class Movie
    {
        public Movie(int filmID, string kategoria, string tytul, string rezyser, int rokProdukcji)
        {
            FilmID = filmID;
            Kategoria = kategoria;
            Tytul = tytul;
            Rezyser = rezyser;
            RokProdukcji = rokProdukcji;
        }

        public int FilmID { get; }
        public string Kategoria { get; }
        public string Tytul { get; }
        public string Rezyser { get; }
        public int RokProdukcji { get; }

        public override string ToString()
        {
            return Tytul + " " + Rezyser + " " + RokProdukcji;
        }
    }
}