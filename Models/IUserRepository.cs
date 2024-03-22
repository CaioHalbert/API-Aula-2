namespace API_Aula_2.Models
{
    public interface IUserRepository
    {
        User GetById(int id);
        IEnumerable<User> GetAll();
        void Add(User entity);
        void Update(User entity);
        void Delete(User id);
    }
}
