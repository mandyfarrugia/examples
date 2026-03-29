using AutoMapper;
using BankManagement.Data;
using BankManagement.Dtos;

namespace BankManagement.Profile
{
    public class InvoiceProfile : AutoMapper.Profile
    {
        public InvoiceProfile()
        {
            /* An invoice loaded from a database (such as Entity Framework Core) to be mapped to a list of type InvoiceDto.
             * Since it is not recommended to pass the ID to the frontend, this has been omitted in the DTO class definition.
             * This is intrisically a process of turning Invoice instances into InvoiceDto instances automatically. */
            CreateMap<Invoice, InvoiceDto>();
        }
    }
}