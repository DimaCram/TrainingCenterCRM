using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.WebAngular.Dto;

namespace TrainingCenterCRM.WebAngular.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicService topicService;

        private readonly IMapper mapper;

        public TopicsController(ITopicService topicService, IMapper mapper)
        {
            this.topicService = topicService;

            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<List<TopicDto>> GetTopicsAsync()
        {
            var topics = mapper.Map<List<TopicDto>>(await topicService.GetTopicsAsync());
            topics.ForEach(t => t.CoursesCount = t.Courses.Count);
            return topics;
        }
    }
}
