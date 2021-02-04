namespace DataBaseConnection
{
    public class Movie
    {
        public Movie(int filmid, Category category, string title, string rezyser, int rok_produkcji)
        {
            FilmID = filmid;
            Category = category;
            Tytul = title;
            Rezyser = rezyser;
            RokProdukcji = rok_produkcji;
        }

        public int FilmID { get; }
        public string Tytul { get; }
        public string Rezyser { get; }
        public int RokProdukcji { get; }
        public Category Category { get; }

        public override string ToString()
        {
            return Tytul + " " + Rezyser + " " + RokProdukcji;
        }
    }
}