using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger logger;
        public TopicsController(IMapper mapper, ITopicService topicService, ILogger logger)
        {
            this.mapper = mapper;
            this.logger = logger;

            this.topicService = topicService;
        }

        public IActionResult Index()
        {
            try
            {
                var topics = topicService.GetTopics();
                var topicsDto = mapper.Map<IEnumerable<Topic>, List<Topic>>(topics);

                return View(topicsDto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult EditTopic(int? id)
        {
            try
            {
                var topicModel = id.HasValue ?
                    mapper.Map<TopicModel>(topicService.GetTopic(id.Value)) :
                    new TopicModel();

                return View(topicModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult EditTopic(TopicModel topicModel)
        {
            try
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
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult DeleteTopic(int id)
        {
            try
            {
                topicService.DeleteTopic(id);
                return RedirectToAction("Index", "Topics");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
    }
}
