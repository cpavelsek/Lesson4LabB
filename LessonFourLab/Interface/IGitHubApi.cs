using System.Threading.Tasks;
using Refit;
using LessonFourLab.Model;

namespace ConnecingToApiExample.Interface
{
    [Headers("User-Agent: :request:")]
    interface IGitHubApi
    {
        [Get("/search/users?q=location:lagos")]
        Task<ApiResponse> GetUser();
    }
}
