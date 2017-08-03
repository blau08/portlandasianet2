using System.Collections.Generic;

namespace portlandasianet.Models.People
{
    public class PersonViewModel
    {
        public int PersonId { get; set; }
        public string Name { get; set; }

        public string Key
        {
            get
            {
                return this.PersonId + ":" + this.Name.ToLower();
            }
        }
    }
}
