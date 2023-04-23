using CleanArchitectureDemo.Domain.Common;

namespace CleanArchitectureDemo.Domain.Entities
{
    public class Stadium : BaseAuditableEntity
    {
        public Stadium()
        {
            Clubs = new List<Club>();
        }

        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public int? Capacity { get; set; }
        public int? BuiltYear { get; set; }
        public int? PitchLength { get; set; }
        public int? PitchWidth { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int? CountryId { get; set; }

        public Country Country { get; set; }
        public IList<Club> Clubs { get; set; }
         
    }
}
