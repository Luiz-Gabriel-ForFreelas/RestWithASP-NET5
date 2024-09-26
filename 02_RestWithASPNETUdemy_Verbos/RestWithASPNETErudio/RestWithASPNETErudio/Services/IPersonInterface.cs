using RestWithASPNETErudio.Model;

namespace RestWithASPNETErudio.Services
{
    public interface IPersonInterface
    {
        Person Create(Person person);

        List<Person> FindAll();

        Person FindById(long id);

        Person Update(Person person);

        void Delete(long id);
    }
}
