using MediatR;

namespace CQRSNight.MediatorDesignPattern.Commands
{
    public class CreateEmployeeCommand : IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
    }
}
