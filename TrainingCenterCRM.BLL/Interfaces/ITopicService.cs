using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ITopicService
    {
        void AddTopic(Topic topicDTO);
        void EditTopic(Topic topicDTO);
        void DeleteTopic(int id);
        Topic GetTopic(int id);
        List<Topic> GetTopics();
    }
}
