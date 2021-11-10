using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Enums;
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

            await studentRequestRepository.Create(model);
        }

        public async Task DeleteRequestAsync(int id)
        {
            await studentRequestRepository.Delete(id);
        }

        public async Task EditRequestAsync(StudentRequest model)
        {
            if (model == null)
                throw new ArgumentException();

            await studentRequestRepository.Update(model);
        }

        public async Task EditRequestsRangeAsync(IEnumerable<StudentRequest> models)
        {
            if (models == null)
                throw new ArgumentNullException();

            await studentRequestRepository.UpdateRange(models);
        }

        public Task<StudentRequest> GetRequestAsync(int id)
        {
            return studentRequestRepository.Get(id);
        }

        public async Task<IEnumerable<StudentRequest>> GetRequestsAsync()
        {
            return await studentRequestRepository.GetAll();
        }
        public async Task<IEnumerable<StudentRequest>> GetOpenRequestsAsync()
        {
            return await studentRequestRepository.Find(r => r.RequestStatus == RequestStatus.Open);
        }
        public async Task<IEnumerable<StudentRequest>> GetOpenRequestsByCourseAsync(int courseId)
        {
            return (await studentRequestRepository.Find(sr => sr.RequestStatus == RequestStatus.Open && sr.CourseId == courseId))
                                                  .Distinct();
        }
        public async Task<IEnumerable<Student>> GetStudentsRequestedForCourseAsync(int courseId)
        {
            return (await studentRequestRepository.Find(sr => sr.CourseId == courseId && sr.RequestStatus == RequestStatus.Open))
                                                  .Select(s => s.Student)
                                                  .Distinct();
        }

        public async Task ReOpenRequestAsync(int studentId, int courseId)
        {
            var request = (await studentRequestRepository.Find(sr => sr.StudentId == studentId &&
                                                               sr.CourseId == courseId &&
                                                               sr.RequestStatus == RequestStatus.Closed)).LastOrDefault();

            if(request != null)
            {
                request.RequestStatus = RequestStatus.Open;
                await studentRequestRepository.Update(request);
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
