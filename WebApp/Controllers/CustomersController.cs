using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Core.Aplication.Interfaces;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

       
        [HttpGet]
        public IActionResult Index()
        {
            return  Ok(_customerRepository.GetCustomers());
        }

        [HttpGet("{customerId}")]
        public IActionResult Index(int customerId)
        {
            return Ok(_customerRepository.GetCustomerByID(customerId));
        }
    }
}