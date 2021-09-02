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
        public TopicsController(IMapper mapper,
                                ITopicService topicService,
                                ILogger<TopicsController> logger)
        {
            this.mapper = mapper;
            this.logger = logger;

            this.topicService = topicService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                var topics = await topicService.GetTopicsAsync();

                return View(topics);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditTopicAsync(int? id)
        {
            try
            {
                var topicModel = id.HasValue ?
                    mapper.Map<TopicModel>(await topicService.GetTopicAsync(id.Value)) :
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
        public async Task<IActionResult> EditTopicAsync(TopicModel topicModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var topic = mapper.Map<Topic>(topicModel);
                    if (topic.Id == 0)
                        await topicService.AddTopicAsync(topic);
                    else
                        await topicService.EditTopicAsync(topic);

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
        public async Task<IActionResult> DeleteTopicAsync(int id)
        {
            try
            {
                await topicService.DeleteTopicAsync(id);
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
