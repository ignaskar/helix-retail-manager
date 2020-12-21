using System.Threading.Tasks;
using HRMDesktopUI.Library.Models;

namespace HRMDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
        Task GetLoggedInUserInfo(string token);
    }
}