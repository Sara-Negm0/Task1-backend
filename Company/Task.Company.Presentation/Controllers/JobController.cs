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
    public class JobController : ApiController
    {
        private readonly JobService jobService;
        public JobController(JobService _jobService)
        {
            jobService = _jobService;
        }


        [HttpGet]
        public ResultViewModel<IEnumerable<JobViewModel>> GetList()
        {
            ResultViewModel<IEnumerable<JobViewModel>> result
                = new ResultViewModel<IEnumerable<JobViewModel>>();
            try
            {
                var jobs = jobService.GetAll();
                result.Successed = true;
                result.Data = jobs;
            }
            catch (Exception ex)
            {
                result.Successed = false;
                result.Message = "Something Went Wrong !!";
            }
            return result;
        }


    }
}
