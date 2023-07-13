using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AMS_WebAPI
{
    public class ProductController : ApiController
    {
        // GET api/<controller>
        //public IEnumerable<Product> Get()
        //{
        //    using (AMSEntities entities = new AMSEntities())
        //    {
        //        return entities.Products.ToList();
        //    }

        //}
        [HttpGet]
        public IEnumerable<Product> ProductDetails()
        {
            using (AMSEntities entities = new AMSEntities())
            {
                return entities.Products.ToList();
            }

        }


        //}
        [HttpGet]
        public IEnumerable<Employee> EmpDetails()
        {
            using (AMSEntities entities = new AMSEntities())
            {
                return entities.Employees.ToList();
            }

        }

        //}
        [HttpGet]
        public IEnumerable<Sale> SaleDetails()
        {
            using (AMSEntities entities = new AMSEntities())
            {
                return entities.Sales.ToList();
            }

        }



        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}