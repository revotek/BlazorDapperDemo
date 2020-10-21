using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDapperCRUD.Data
{
    public interface IVideoService
    {
        Task<bool> VideoInsert(Video video);
        Task<IEnumerable<Video>> VideoList();
        Task<Video> Video_GetOne(int videoId);
        Task<bool> VideoUpdate(Video video);
        Task<bool> VideoDelete(int videoId);
    }
}