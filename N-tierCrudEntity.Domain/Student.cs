namespace N_tierCrudEntity.Domain
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public Group Group { get; }
    }
}
