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
        private readonly IRepository<Topic> repository;

        public TopicService(IRepository<Topic> repository)
        {
            this.repository = repository;
        }
        public async Task AddTopicAsync(Topic topic)
        {
            if (topic == null)
                throw new ArgumentException();

            await repository.CreateAsync(topic);
        }

        public async Task DeleteTopicAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task EditTopicAsync(Topic topic)
        {
            if (topic == null)
                throw new ArgumentException();

            await repository.UpdateAsync(topic);
        }

        public Task<Topic> GetTopicAsync(int id)
        {
            return repository.GetAsync(id);
        }

        public Task<List<Topic>> GetTopicsAsync()
        {
            return repository.GetAllAsync();
        }

        public Task<IEnumerable<Topic>> GetTopicsByPaginationAsync(PaginationFilter pagination)
        {
            return repository.GetAllByPaginationAsync(pagination);
        }
    }
}
