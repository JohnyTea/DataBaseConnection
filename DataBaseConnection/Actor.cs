namespace DataBaseConnection
{
    internal class Actor
    {
        public Actor(int actorID, string actorName, string actorLastName)
        {
            ActorID = actorID;
            ActorName = actorName;
            ActorLastName = actorLastName;
        }

        public int ActorID { get; set; }
        public string ActorName { get; }
        public string ActorLastName { get; }

        public override string ToString()
        {
            return ActorName + " " + ActorLastName;
        }
    }
}