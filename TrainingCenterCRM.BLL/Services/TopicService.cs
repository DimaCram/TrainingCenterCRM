using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class TopicService : ITopicService
    {
        private readonly ITopicRepository repository;

        public TopicService(ITopicRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddTopicAsync(Topic topic)
        {
            if (topic == null)
                throw new ArgumentException();

            await repository.Create(topic);
        }

        public async Task DeleteTopicAsync(int id)
        {
            await repository.Delete(id);
        }

        public async Task EditTopicAsync(Topic topic)
        {
            if (topic == null)
                throw new ArgumentException();

            await repository.Update(topic);
        }

        public Task<Topic> GetTopicAsync(int id)
        {
            return repository.Get(id);
        }

        public Task<List<Topic>> GetTopicsAsync()
        {
            return repository.GetAll();
        }

        public Task<IEnumerable<Topic>> GetTopicsByPaginationAsync(PaginationFilter pagination)
        {
            return repository.GetAllByPagination(pagination);
        }
    }
}
