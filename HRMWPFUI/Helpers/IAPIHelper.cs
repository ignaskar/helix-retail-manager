using System.Threading.Tasks;
using HRMWPFUI.Models;

namespace HRMWPFUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
    }
}