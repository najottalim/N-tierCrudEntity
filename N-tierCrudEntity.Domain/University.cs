using System.Collections.Generic;

namespace N_tierCrudEntity.Domain
{
    public class University
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IList<Group> Groups { get; set; }

        public University()
        {
            Groups = new List<Group>();
        }
    }
}
