using System.Threading.Tasks;

namespace <%= namespaceName %>.Authorization
{
    public interface IAppAuthApiService
    {
        Task<AppAuthTokenModel> ValidateAndIssueToken(string inboundToken);
        Task<AppAuthTokenModel> GetSession(string sessionId);
    }
}