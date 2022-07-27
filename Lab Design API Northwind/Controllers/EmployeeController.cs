using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab_Design_API_Northwind.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab_Design_API_Northwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        public NorthWindContext northWindContext = new NorthWindContext();

        [HttpGet("GetByFirstName")]

        public Employee GetByFirstName(string firstName)
        {
            return northWindContext.Employees.FirstOrDefault(e => e.FirstName == firstName);
        }

        [HttpGet("GetByCity")]

        public Employee GetByCity(string city)
        {
            return northWindContext.Employees.FirstOrDefault(e => e.City == city);
        }

        [HttpDelete("RemoveEmployeeHomePhone")]

        public Employee RemoveEmployeeHomePhone(string phone)
        {
            Employee removedPhone = northWindContext.Employees.FirstOrDefault(p => p.HomePhone == phone);
            northWindContext.Employees.Remove(removedPhone);
            northWindContext.SaveChanges();

            return removedPhone;
        }

        [HttpPost("AddEmployee")]

        public Employee AddEmployee(int EmployeeID,string LastName,string FirstName,string Title,string TitleOfCourtesy,DateTime? BirthDate,DateTime? HireDate,string Address,string City,string Region,string PostalCode, string Country,string HomePhone,string Extension,byte[]? Photo,string Notes,int ReportsTo)

            {
            Employee newEmployee = new Employee
            {
                LastName = LastName,
                FirstName = FirstName,
                Title = Title,
                TitleOfCourtesy = TitleOfCourtesy,
                BirthDate = BirthDate,
                HireDate = HireDate,
                Address = Address,
                City = City,
                Region = Region,
                PostalCode = PostalCode,
                Country = Country,
                HomePhone = HomePhone,
                Extension = Extension,
                Photo = Photo,
                Notes = Notes,
                ReportsTo = ReportsTo,
            };
            northWindContext.Add(newEmployee);
            northWindContext.SaveChanges();
            return newEmployee;
        }

    }
}
