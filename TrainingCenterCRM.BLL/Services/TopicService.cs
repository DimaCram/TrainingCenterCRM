using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.DAL.Enttities;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class TopicService : ITopicService
    {
        private readonly IUnitOfWork db;
        private readonly IMapper mapper;

        public TopicService(IUnitOfWork db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddTopic(TopicDTO topicDTO)
        {
            if (topicDTO == null)
                throw new ArgumentException();

            var topic = mapper.Map<Topic>(topicDTO);

            db.Topics.Create(topic);
            db.Save();
        }

        public void DeleteTopic(int id)
        {
            db.Topics.Delete(id);
            db.Save();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void EditTopic(TopicDTO topicDTO)
        {
            if (topicDTO == null)
                throw new ArgumentException();

            var topic = mapper.Map<Topic>(topicDTO);

            db.Topics.Update(topic);
            db.Save();
        }

        public TopicDTO GetTopic(int id)
        {
            var topic = db.Topics.Get(id);

            return mapper.Map<TopicDTO>(topic);
        }

        public List<Topic> GetTopics()
        {
            return db.Topics.GetAll();
        }
    }
}
