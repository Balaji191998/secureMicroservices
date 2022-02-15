using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.dbentities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MoviesController : ControllerBase
    {
        private readonly db_balajiContext dbcontext;
        public MoviesController(db_balajiContext db_BalajiContext)
        {
            dbcontext = db_BalajiContext;
        }
        // GET: api/<MoviesController>
        [HttpGet]
        public async Task<List<TblCustomer>> Get()
        {
            List<TblCustomer> cusdet;
            try
            {
                cusdet = dbcontext.TblCustomer.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(cusdet);

        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public async Task<TblCustomer> Get(int? id)
        {
            TblCustomer cusdet = new TblCustomer();
            try
            {
                if(id!=null)
                {
                    cusdet = dbcontext.TblCustomer.Find(id);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(cusdet);

        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] TblCustomer value)
        {
            try
            {
                dbcontext.TblCustomer.Add(value);
                dbcontext.SaveChanges();
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(int? id, [FromBody] TblCustomer value)
        {
            try
            {
                if(id!=null)
                {
                    dbcontext.TblCustomer.Add(value);
                    dbcontext.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TblCustomer customer = new TblCustomer();
            try
            {
                customer = dbcontext.TblCustomer.Find(id);
                dbcontext.TblCustomer.Remove(customer);
                dbcontext.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
