using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class StudentRequestService : IStudentRequestService
    {
        private readonly IRequestRepository studentRequestRepository;

        public StudentRequestService(IRequestRepository studentRequestRepository)
        {
            this.studentRequestRepository = studentRequestRepository;
        }

        public async Task AddRequestAsync(StudentRequest model)
        {
            if (model == null)
                throw new ArgumentException();

            await studentRequestRepository.CreateAsync(model);
        }

        public async Task DeleteRequestAsync(int id)
        {
            await studentRequestRepository.DeleteAsync(id);
        }

        public async Task EditRequestAsync(StudentRequest model)
        {
            if (model == null)
                throw new ArgumentException();

            await studentRequestRepository.UpdateAsync(model);
        }

        public async Task EditRequestsRangeAsync(IEnumerable<StudentRequest> models)
        {
            if (models == null)
                throw new ArgumentNullException();

            await studentRequestRepository.UpdateRange(models);
        }

        public Task<StudentRequest> GetRequestAsync(int id)
        {
            return studentRequestRepository.GetAsync(id);
        }

        public Task<List<StudentRequest>> GetRequestsAsync()
        {
            return studentRequestRepository.GetAllAsync();
        }
        public async Task<List<StudentRequest>> GetOpenRequestsAsync()
        {
            var requests = await studentRequestRepository.GetAllAsync();
            return requests.Where(sr => sr.RequestStatus == RequestStatus.Open).ToList();
        }
        public async Task<List<StudentRequest>> GetOpenRequestsByCourseAsync(int courseId)
        {
            var requests = await studentRequestRepository.GetAllAsync();
            return requests.Where(sr => sr.RequestStatus == RequestStatus.Open && sr.CourseId == courseId)
                           .Distinct()
                           .ToList();
        }
        public async Task<IEnumerable<Student>> GetStudentsRequestedForCourseAsync(int courseId)
        {
            var requests = await studentRequestRepository.GetAllAsync();
            return requests.Where(sr => sr.CourseId == courseId && sr.RequestStatus == RequestStatus.Open)
                           .Select(s => s.Student)
                           .Distinct()
                           .ToList();
        }

        public async Task ReOpenRequestAsync(int studentId, int courseId)
        {
            var request = studentRequestRepository.Find(sr => sr.StudentId == studentId &&
                                                        sr.CourseId == courseId &&
                                                        sr.RequestStatus == RequestStatus.Closed).LastOrDefault();

            if(request != null)
            {
                request.RequestStatus = RequestStatus.Open;
                await studentRequestRepository.UpdateAsync(request);
            }
        }

        public async Task CloseRequestsAsync(IEnumerable<int> studentsId, int courseId)
        {
            var openRequests = await GetOpenRequestsByCourseAsync(courseId);
            var openRequestsForStudents = openRequests.Where(r => studentsId.Contains(r.StudentId));

            openRequestsForStudents.ToList().ForEach(r =>
            {
                r.RequestStatus = RequestStatus.Closed;
            });

            await EditRequestsRangeAsync(openRequestsForStudents);
        }
    }
}
