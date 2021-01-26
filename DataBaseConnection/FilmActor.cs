namespace DataBaseConnection
{
    internal class FilmActor
    {
        public FilmActor(int filmID, int actorID, string actorName)
        {
            FilmID = filmID;
            ActorID = actorID;
            ActorName = actorName;
        }

        public int FilmID { get; }
        public int ActorID { get; }
        public string ActorName { get; }

        public override string ToString()
        {
            return ActorName;
        }
    }
}