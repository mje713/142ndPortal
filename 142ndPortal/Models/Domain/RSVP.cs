using System.Data;

namespace _142ndPortal.Models.Domain
{
    public class RSVP
    {

        public Guid Id { get; set; }
        public string Callsign{ get; set; }
        public DataSetDateTime Date { get; set; }
        public bool Confirm { get; set; }
    }
}
