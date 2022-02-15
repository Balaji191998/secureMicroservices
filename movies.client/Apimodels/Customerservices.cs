using IdentityModel.Client;
using movies.client.dbentities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace movies.client.Apimodels
{
    public class Customerservices:Icustomerservices
    {
        private db_balajiContext context;
        public Customerservices(db_balajiContext _context)
        {
            context = _context;
        }
        public async Task<IEnumerable<TblCustomer>> GetCustomers()
        {
            // to access the movieapi through movies client the steps include:

            var apiclientcredentials = new ClientCredentialsTokenRequest
            {
                Address = "https://localhost:5003/connect/token",
                ClientId = "MoviesClient",
                ClientSecret = "Secret",
                Scope = "moviesAPI"
            };

            //Creates a new http request to talk with the identiy server

            var client = new HttpClient();

            //just we can check if we reach the discovery document.
            var disco =  await client.GetDiscoveryDocumentAsync("https://localhost:5003");
            if(disco.IsError)
            {
                return null;
            }

            var tokenresonse = await client.RequestClientCredentialsTokenAsync(apiclientcredentials);
            if(tokenresonse.IsError)
            {
                return null;
            }

            //Send request to movies api 

            //create a http request 
            var apiclient = new HttpClient();
            //set the token type to bearer token
            apiclient.SetBearerToken(tokenresonse.AccessToken);
            //send request to api
            var response = await apiclient.GetAsync("https://localhost:5002/api/Movies");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            // Deserilisation to the customer list

            IEnumerable<TblCustomer> customerlist = JsonConvert.DeserializeObject<IEnumerable<TblCustomer>>(content);
            return customerlist;













            IEnumerable<TblCustomer> customer;
            try
            {
                customer = context.TblCustomer.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return customer;
        }
        public async Task<TblCustomer> GetCustomer(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<TblCustomer> CreateCustomer(TblCustomer customer)
        {
            throw new NotImplementedException();

        }
        public async Task<TblCustomer> UpdateCustomer(TblCustomer customer)
        {
            throw new NotImplementedException();
        }
        public async Task DeleteCustomer(int id)
        {
            throw new NotImplementedException();

        }


    }
} 
