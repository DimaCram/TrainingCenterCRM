﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IStudentRequestService
    {
        Task AddRequestAsync(StudentRequest model);
        Task EditRequestAsync(StudentRequest model);
        Task DeleteRequestAsync(int id);
        Task<StudentRequest> GetRequestAsync(int id);
        Task<List<StudentRequest>> GetRequestsAsync();
        Task<List<StudentRequest>> GetOpenRequestsAsync();
        Task<List<StudentRequest>> GetOpenRequestsByCourseAsync(int courseId);
        Task<IEnumerable<Student>> GetStudentsRequestedForCourseAsync(int courseId);
        Task ReOpenRequestAsync(int studentId, int courseId);
        Task CloseRequestsAsync(IEnumerable<int> studentsId, int courseId);
    }
}
