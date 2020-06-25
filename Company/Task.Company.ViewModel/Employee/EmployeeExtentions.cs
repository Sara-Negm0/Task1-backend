using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Company.Entities;

namespace Task.Company.ViewModel
{
    public static class EmployeeExtentions
    {
        public static EmployeeViewModel ToViewModel(this Employee model)
        {
            return new EmployeeViewModel
            {
                ID = model.ID,
                Name = model.Name,
                Email = model.Email,
                Gender =model.Gender,
                HiringDate =model.HiringDate,
                JobName =model.Job?.Name,
                Mobile =model.Mobile,
                NationalID = model.NationalID ,
                Status =model.Status,
                JobID = model.JobID

            };
        }
        public static Employee ToModel(this EmployeeEditViewModel editModel)
        {
            return new Employee
            {
                ID = editModel.ID,
              Name =editModel.Name,
              NationalID =editModel.NationalID,
              Mobile =editModel.Mobile,
              JobID =editModel.JobID,
              Status =editModel.Status,
              Email =editModel.Email,
              Gender=editModel.Gender,
              HiringDate = editModel.HiringDate
              
            };
        }
        public static EmployeeEditViewModel ToEditableViewModel(this Employee model)
        {
            return new EmployeeEditViewModel
            {
                ID = model.ID,
                Email =model.Email,
                JobID=model.JobID,
                HiringDate =model.HiringDate,
                Gender =model.Gender,
                Status =model.Status,
                Mobile=model.Mobile,
                Name=model.Name,
                NationalID=model.NationalID,
                
            };
        }

        public static Employee ToModel(this EmployeeViewModel model)
        {
            return new Employee
            {
                ID = model.ID,
                Email = model.Email,
                JobID = model.JobID,
                HiringDate = model.HiringDate,
                Gender = model.Gender,
                Status = model.Status,
                Mobile = model.Mobile,
                Name = model.Name,
                NationalID = model.NationalID,
                
            };
        }
    }
}
