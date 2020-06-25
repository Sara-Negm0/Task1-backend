using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Company.Entities;
using Task.Company.Reposatory;
using Task.Company.ViewModel;

namespace Task.Company.Service
{
    public class JobService
    {
        UnitOfWork unitOfWork;
        Generic<Job> JobRepo;

        public JobService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            JobRepo = unitOfWork.JobRepo;
        }
        public JobEditViewModel Add(JobEditViewModel P)
        {
            Job PP = JobRepo.Add(P.ToModel());
            unitOfWork.Commit();
            return PP.ToEditableViewModel();
        }
        public JobEditViewModel Update(JobEditViewModel P)
        {
            Job PP = JobRepo.Update(P.ToModel());
            unitOfWork.Commit();
            return PP.ToEditableViewModel();
        }
        public JobViewModel GetByID(int id)
        {
            return JobRepo.GetByID(id)?.ToViewModel();
        }
        public IEnumerable<JobViewModel> GetAll()
        {
            var query =
                JobRepo.GetAll();
            return query.ToList().Select(i => i.ToViewModel());
        }
        public void Remove(int id)
        {
            JobRepo.Remove(JobRepo.GetByID(id));
            unitOfWork.Commit();
        }

    }
}
