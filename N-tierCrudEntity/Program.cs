using N_tierCrudEntity.Data.IRepositories;
using N_tierCrudEntity.Data.Repositories;
using N_tierCrudEntity.Domain;

namespace N_tierCrudEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IUniversityRepository univerRepo = new UniversityRepository();

            University university = new University { Name = "TUIT" };

            Group group = new Group { Name = "dotNet#1" };

            Teacher teacher = new Teacher { FullName = "MuhammadKarim To'xtaboyev" };

            Subject subject = new Subject { Name = "dotNet" };

            Student student = new Student { FullName = "Javlonbek Rajabov" };

            teacher.Subject = subject;

            subject.Teachers.Add(teacher);

            group.Teachers.Add(teacher);

            group.Students.Add(student);

            university.Groups.Add(group);

            univerRepo.CreateAsync(university).Wait();
        }
    }
}
