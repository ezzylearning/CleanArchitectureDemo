using CleanArchitectureDemo.Domain.Common;

namespace CleanArchitectureDemo.Domain.Entities
{
    public class Country : BaseAuditableEntity
    {
        public Country()
        {
            Players = new List<Player>();
            Stadiums = new List<Stadium>();
        }

        public string Name { get; set; }
        public string TwoLetterIsoCode { get; set; }
        public string ThreeLetterIsoCode { get; set; }
        public string FlagUrl { get; set; }
        public int? DisplayOrder { get; set; }

        public IList<Player> Players { get; set; }
        public IList<Stadium> Stadiums { get; set; }
    }
}
 
