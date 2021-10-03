using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Api.Dto;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.Api.Controllers
{
    [Authorize(Roles = "manager")]
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly ITopicService _topicService;

        public TopicsController(IMapper mapper, ITopicService topicService)
        {
            _mapper = mapper;
            _topicService = topicService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<TopicDto>> GetTopicsAsync()
        {
            return _mapper.Map<IEnumerable<TopicDto>>(await _topicService.GetTopicsAsync());
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<TopicDto> GetTopicAsync(int id)
        {
            return _mapper.Map<TopicDto>(await _topicService.GetTopicAsync(id));
        }

        [HttpPost]
        public async Task EditTopicAsync(TopicDto topicDto)
        {
            var topic = _mapper.Map<Topic>(topicDto);

            if (topic.Id == 0)
                await _topicService.AddTopicAsync(topic);
            else
                await _topicService.EditTopicAsync(topic);
        }

        [HttpDelete("{id}")]
        public async Task DeleteTopicAsync(int id)
        {
            await _topicService.DeleteTopicAsync(id);
        }
    }
}
