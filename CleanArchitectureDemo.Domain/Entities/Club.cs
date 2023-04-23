using CleanArchitectureDemo.Domain.Common;

namespace CleanArchitectureDemo.Domain.Entities
{
    public class Club : BaseAuditableEntity
    {
        public Club()
        {
            Players = new List<Player>();
        }

        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string WebsiteUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public string InstagramUrl { get; set; }
        public int? StadiumId { get; set; }

        public Stadium Stadium { get; set; }
        public IList<Player> Players { get; set; }
    }
}

