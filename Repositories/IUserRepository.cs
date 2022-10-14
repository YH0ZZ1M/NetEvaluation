using Net_Evaluation.Models;

namespace Net_Evaluation.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);
        void DeleteUser(int id);
    }
}