using movies.client.dbentities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movies.client.Apimodels
{
    public interface Icustomerservices
    {
        Task<IEnumerable<TblCustomer>> GetCustomers();
        Task<TblCustomer> GetCustomer(int id);
        Task<TblCustomer> CreateCustomer(TblCustomer customer);
        Task<TblCustomer> UpdateCustomer(TblCustomer customer);
        Task DeleteCustomer(int id);
    }
}
