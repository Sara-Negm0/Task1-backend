using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Task.Company.Service;
using Task.Company.ViewModel;

namespace Task.Company.Presentation.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly EmployeeService employeeService;
        public EmployeeController(EmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }

       
        [HttpGet]
        public ResultViewModel<IEnumerable<EmployeeViewModel>> GetList(int PageIndex ,int PageSize)
        {
            ResultViewModel<IEnumerable<EmployeeViewModel>> result
                = new ResultViewModel<IEnumerable<EmployeeViewModel>>();
            try
            {
                var employees = employeeService.GetAll(PageIndex,PageSize);
                result.Successed = true;
                result.Data = employees;
            }
            catch (Exception ex)
            {
                result.Successed = false;
                result.Message = "Something Went Wrong !!";
            }
            return result;
        }

        [HttpPost]
        public ResultViewModel<EmployeeEditViewModel> Post(EmployeeEditViewModel Emp)
        {
            ResultViewModel<EmployeeEditViewModel> result
                = new ResultViewModel<EmployeeEditViewModel>();

            try
            {
                if (!ModelState.IsValid)
                {
                    result.Message = "In Valid Model State";
                }
                else
                {
                    EmployeeEditViewModel selectedUser
                        = employeeService.Add(Emp);

                    result.Successed = true;
                    result.Data = selectedUser;
                }
            }
            catch (Exception ex)
            {
                result.Successed = false;
                result.Message = "Semething Went Wrong";
            }
            return result;
        }
        [HttpPost]
        public ResultViewModel<EmployeeEditViewModel> Update(EmployeeEditViewModel Emp)
        {
            ResultViewModel<EmployeeEditViewModel> result
                = new ResultViewModel<EmployeeEditViewModel>();

            try
            {
                if (!ModelState.IsValid)
                {
                    result.Message = "In Valid Model State";
                }
                else
                {
                    EmployeeEditViewModel selectedEmp
                        = employeeService.Update(Emp);

                    result.Successed = true;
                    result.Data = selectedEmp;
                }
            }
            catch (Exception ex)
            {
                result.Successed = false;
                result.Message = "Semething Went Wrong";
            }
            return result;
        }
        [HttpGet]

        public ResultViewModel<EmployeeViewModel> GetByID(int id)
        {
            ResultViewModel<EmployeeViewModel> result
                = new ResultViewModel<EmployeeViewModel>();
            try
            {
                var employee = employeeService.GetByID(id);
                result.Successed = true;
                result.Data = employee;
            }
            catch (Exception ex)
            {
                result.Successed = false;
                result.Message = "Something Went Wrong !!";
            }
            return result;
        }
        [HttpGet]
        public string Delete(int id)
        {
            if (employeeService.GetByID(id) != null)
            {
                employeeService.Remove(id);
                return "User Deleted Sucessfully";
            }
            else
                return "User Not Found !";
        }

        [HttpGet]
        public string ChangeStatus(int id)
        {
       
            try
            {
                if (employeeService.ChangeStatus(id))
                    return "Status Updated Sucessfully";
                else
                    return "Employee Not Found";
            }
            catch (Exception ex)
            {

                return "Semething Went Wrong";
            }
        }


    }
}
