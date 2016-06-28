using Com.Pinz.Client.DomainModel;
using System.Threading.Tasks;

namespace Com.Pinz.Client.RemoteServiceConsumer.Service
{
    public interface IAuthorisationRemoteService
    {
        bool IsUserProjectAdmin(User user, Project project);

        bool IsUserComapnyAdmin(User user);

        User ReadUserByEmail(string email);

        Task<User> ReadUserByEmailAsync(string email);
    }
}
