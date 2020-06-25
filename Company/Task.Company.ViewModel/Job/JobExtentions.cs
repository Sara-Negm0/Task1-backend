using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Company.Entities;

namespace Task.Company.ViewModel
{
    public static class JobExtentions
    {
        public static JobViewModel ToViewModel(this Job model)
        {
            return new JobViewModel
            {
                ID = model.ID,
                Name = model.Name,
              
            };
        }
        public static Job ToModel(this JobEditViewModel editModel)
        {
            return new Job
            {
                ID = editModel.ID,
                Name = editModel.Name,
              
            };
        }
        public static JobEditViewModel ToEditableViewModel(this Job model)
        {
            return new JobEditViewModel
            {
                ID = model.ID,
                Name = model.Name,
               
            };
        }
    }
}
