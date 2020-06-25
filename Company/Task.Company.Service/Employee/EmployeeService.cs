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
    public class EmployeeService
    {

        UnitOfWork unitOfWork;
        Generic<Employee> EmployeeRepo;

        public EmployeeService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            EmployeeRepo = unitOfWork.EmployeeRepo;
        }
        public EmployeeEditViewModel Add(EmployeeEditViewModel P)
        {
            Employee PP = EmployeeRepo.Add(P.ToModel());
            unitOfWork.Commit();
            return PP.ToEditableViewModel();
        }
        public EmployeeEditViewModel Update(EmployeeEditViewModel P)
        {
            Employee PP = EmployeeRepo.Update(P.ToModel());
            unitOfWork.Commit();
            return PP.ToEditableViewModel();
        }
        public EmployeeViewModel GetByID(int id)
        {
            return EmployeeRepo.GetByID(id)?.ToViewModel();
        }
        public Employee GetModelByID(int id)
        {
            return EmployeeRepo.GetByID(id);
        }

        public IEnumerable<EmployeeViewModel> GetAll(int pageIndex,int pageSize)
        {
            var query =
                EmployeeRepo.GetAll();
            query = query.OrderBy(i => i.ID).Skip(pageIndex * pageSize).Take(pageSize);

            return query.ToList().Select(i => i.ToViewModel());
        }
        public void Remove(int id)
        {
            EmployeeRepo.Remove(EmployeeRepo.GetByID(id));
            unitOfWork.Commit();
        }

        public bool ChangeStatus(int id)
        {

            Employee employee = GetModelByID(id);
            if (employee != null)
            {
                employee.Status = !employee.Status;
                unitOfWork.Commit();
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
