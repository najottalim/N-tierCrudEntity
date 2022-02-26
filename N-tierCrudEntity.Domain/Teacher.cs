using System.Collections.Generic;

namespace N_tierCrudEntity.Domain
{
    public class Teacher
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public virtual ICollection<Group> Groups { get; }

        public Subject Subject { get; set; }

        public Teacher()
        {
            Groups = new List<Group>();
        }
    }
}
