using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class TopicService : ITopicService
    {
        private readonly IRepository<Topic> repository;

        public TopicService(IRepository<Topic> repository)
        {
            this.repository = repository;
        }
        public void AddTopic(Topic topic)
        {
            if (topic == null)
                throw new ArgumentException();

            repository.Create(topic);
        }

        public void DeleteTopic(int id)
        {
            repository.Delete(id);
        }

        public void EditTopic(Topic topic)
        {
            if (topic == null)
                throw new ArgumentException();

            repository.Update(topic);
        }

        public Topic GetTopic(int id)
        {
            return repository.Get(id);
        }

        public List<Topic> GetTopics()
        {
            return repository.GetAll();
        }
    }
}
