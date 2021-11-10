using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ICourseReviewService
    {
        Task AddCourseReviewAsync(CourseReview courseDTO);
        Task EditCourseReviewAsync(CourseReview courseDTO);
        Task DeleteCourseReviewAsync(int id);
        Task<CourseReview> GetCourseReviewAsync(int id);
        Task<List<CourseReview>> GetCourseReviewsAsync();
    }
}
