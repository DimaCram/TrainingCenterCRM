using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.DAL.Enttities;

namespace TrainingCenterCRM.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Student> Students { get; }
        IRepository<Group> Groups { get; }
        void Save();
        void Dispose();
    }
}
