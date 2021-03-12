using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylyst
    {
        public Stylyst()
        {
            this.Clients = new HashSet<Client>();
        }

        public int StylystId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}