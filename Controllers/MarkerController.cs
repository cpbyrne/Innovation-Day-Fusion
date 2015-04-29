using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EmployeeLocationBasedServices.Controllers
{
    public class MarkerController : ApiController
    {
        [Inject]
        public IIntProvider IntProvider { get; set; }

        [HttpGet]
        public IQueryable<int> Get()
        {
            return IntProvider.Generate();
        }        
             
    }

    public class IntProvider : IIntProvider
    {
        public IQueryable<int> Generate()
        {
            return new int[] { 1, 4, 7, 9 }.AsQueryable();
        }
    }

    public interface IIntProvider
    {
        IQueryable<int> Generate();
    }
}