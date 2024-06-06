using MediatR;

namespace CQRSNight.MediatorDesignPattern.Commands
{
    public class RemoveEmployeeCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveEmployeeCommand(int id)
        {
            Id = id;
        }
    }
}