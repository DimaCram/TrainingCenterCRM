using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.DAL.Enttities;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ITopicService
    {
        void AddTopic(TopicDTO topicDTO);
        void EditTopic(TopicDTO topicDTO);
        void DeleteTopic(int id);
        TopicDTO GetTopic(int id);
        List<Topic> GetTopics();
        void Dispose();
    }
}
