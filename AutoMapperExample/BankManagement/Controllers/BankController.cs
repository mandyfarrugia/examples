using AutoMapper;
using BankManagement.Data;
using BankManagement.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BankManagement.Controllers
{
    [Route("api/[controller]")]
    public class BankController : ControllerBase
    {
        private readonly IMapper _mapper;

        public BankController(IMapper mapper)
        {
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetInvoice()
        {
            Invoice inMemoryInvoice = new Invoice()
            {
                Id = 1,
                Description = "Grocery",
                Amount = 100
            };

            //Send the DTO to the frontend/back to the user.

            //Provide the instance of Invoice (from the database, for example) to be mapped to an instance of InvoiceDto.
            InvoiceDto invoiceDto = this._mapper.Map<InvoiceDto>(inMemoryInvoice);

            return Ok(invoiceDto);
        }
    }
}
