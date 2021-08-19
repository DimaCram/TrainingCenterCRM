using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    [Authorize]
    public class TopicsController : Controller
    {
        private readonly ITopicService topicService;

        private readonly IMapper mapper;

        public TopicsController(IMapper mapper, ITopicService topicService)
        {
            this.mapper = mapper;

            this.topicService = topicService;
        }

        public IActionResult Index()
        {
            var topics = topicService.GetTopics();
            var topicsDto = mapper.Map<IEnumerable<Topic>, List<Topic>>(topics);

            return View(topicsDto);
        }

        [HttpGet]
        public IActionResult EditTopic(int? id)
        {
            var topicModel = id.HasValue ?
                mapper.Map<TopicModel>(topicService.GetTopic(id.Value)) :
                new TopicModel();

            return View(topicModel);
        }

        [HttpPost]
        public IActionResult EditTopic(TopicModel topicModel)
        {
            if (ModelState.IsValid)
            {
                var topic = mapper.Map<Topic>(topicModel);
                if (topic.Id == 0)
                    topicService.AddTopic(topic);
                else
                    topicService.EditTopic(topic);
    
                return RedirectToAction("Index", "Topics");
            }

            return View(topicModel);
        }

        [HttpGet]
        public IActionResult DeleteTopic(int id)
        {
            topicService.DeleteTopic(id);
            return RedirectToAction("Index", "Topics");
        }
    }
}
