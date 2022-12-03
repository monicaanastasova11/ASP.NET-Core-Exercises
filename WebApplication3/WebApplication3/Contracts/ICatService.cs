using WebApplication3.Models;

namespace Fluffy.Contracts
{
    public interface ICatService
    {
        void Add(ICatService cat);
        List<Cat> GetAll();
        void Create(Cat cat);
        Cat GetCat(int id);
    }
}
