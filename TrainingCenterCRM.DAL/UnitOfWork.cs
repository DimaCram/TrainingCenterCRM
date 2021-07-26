using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.DAL.Context;
using TrainingCenterCRM.DAL.Enttities;
using TrainingCenterCRM.DAL.Interfaces;
using TrainingCenterCRM.DAL.Repositories;

namespace TrainingCenterCRM.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TrainingCenterContext db;

        private StudentRepository studentRepository;

        public UnitOfWork()
        {
            db = new TrainingCenterContext();
        }

        public IRepository<Student> Students
        {
            get
            {
                if (studentRepository == null)
                    studentRepository = new StudentRepository(db);

                return studentRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

    }
}
