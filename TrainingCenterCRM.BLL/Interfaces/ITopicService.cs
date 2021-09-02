using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ITopicService
    {
        Task AddTopicAsync(Topic topicDTO);
        Task EditTopicAsync(Topic topicDTO);
        Task DeleteTopicAsync(int id);
        Task<Topic> GetTopicAsync(int id);
        Task<List<Topic>> GetTopicsAsync();
    }
}
