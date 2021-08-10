using AutoMapper;
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
        public IActionResult AddTopic()
        {
            ViewData["Action"] = "Add";

            return View("EditTopic");
        }

        [HttpPost]
        public IActionResult AddTopic(TopicModel topic)
        {
            topicService.AddTopic(mapper.Map<Topic>(topic));

            return RedirectToAction("Index", "Topics");
        }

        [HttpGet]
        public IActionResult EditTopic(int id)
        {
            var topicDto = topicService.GetTopic(id);
            ViewData["Action"] = "Edit";

            return View(mapper.Map<TopicModel>(topicDto));
        }

        [HttpPost]
        public IActionResult EditTopic(TopicModel topic)
        {
            topicService.EditTopic(mapper.Map<Topic>(topic));

            return RedirectToAction("Index", "Topics");
        }

        [HttpGet]
        public IActionResult DeleteTopic(int id)
        {
            topicService.DeleteTopic(id);
            return RedirectToAction("Index", "Topics");
        }
    }
}
