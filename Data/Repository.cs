using WebApp.Models;

namespace WebApp.Repository
{
    public class Repository : IRepository
    {
        private readonly List<Person> _persons = new List<Person>();

        public void Add(Person person)
        {
            _persons.Add(person);
        }

        public IEnumerable<Person> All()
        {
            return _persons;
        }
    }
}
