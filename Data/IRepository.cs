using WebApp.Models;

namespace WebApp.Repository
{
    public interface IRepository
    {
        public void Add(Person person);
        public IEnumerable<Person> All();
    }
}
