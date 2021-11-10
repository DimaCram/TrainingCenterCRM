using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ITopicService
    {
        Task AddTopicAsync(Topic topicDTO);
        Task EditTopicAsync(Topic topicDTO);
        Task DeleteTopicAsync(int id);
        Task<Topic> GetTopicAsync(int id);
        Task<List<Topic>> GetTopicsAsync();
        Task<IEnumerable<Topic>> GetTopicsByPaginationAsync(PaginationFilter pagination);
    }
}
