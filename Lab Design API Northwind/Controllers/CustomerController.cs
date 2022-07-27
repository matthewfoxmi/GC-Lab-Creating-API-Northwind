using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab_Design_API_Northwind.Models;

namespace Lab_Design_API_Northwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public NorthWindContext northWindContext = new NorthWindContext();

        [HttpGet("GetByCustomerId")]

        public Customer GetByCustomerId(string id)
        {
            return northWindContext.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        [HttpGet("GetByCity")]

        public Customer GetByCity(string city)
        {
            return northWindContext.Customers.FirstOrDefault(c => c.City == city);

        }

        [HttpPost("AddCustomerId")]

        public Customer AddCustomerId(string customerid, string CompanyName, string ContactName, string ContactTitle, string Address, string city, string region, string postalCode, string country, string phone, string fax)
        {
            Customer newCustomer = new Customer
            {
                CompanyName = CompanyName,
                ContactName = ContactName,
                ContactTitle = ContactTitle,
                Address = Address,
                City = city,
                Region = region,
                PostalCode = postalCode,
                Country = country,
                Phone = phone,
                Fax = fax
            };
            northWindContext.Customers.Add(newCustomer);
            northWindContext.SaveChanges();

            return (newCustomer);
        }








    }
}

