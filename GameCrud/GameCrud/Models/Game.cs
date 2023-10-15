namespace GameCrud.Models
{
    public class GameModel
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime StartDateTime { get; }
        public DateTime EndDateTime { get; }
        public DateTime LastModifiedDateTime { get; }
        public List<string> Category { get; }
        public List<string> Platform { get; }

        public GameModel(
            Guid id,
            string name,
            string description,
            DateTime startDateTime,
            DateTime endDateTime,
            DateTime lastModifiedDateTime,
            List<string> category,
            List<string> platform)
            {
                Id = id;
                Name = name;
                Description = description;
                StartDateTime = startDateTime;
                EndDateTime = endDateTime;
                LastModifiedDateTime = lastModifiedDateTime;
                Category = category;
                Platform = platform;
            }

    }
}
