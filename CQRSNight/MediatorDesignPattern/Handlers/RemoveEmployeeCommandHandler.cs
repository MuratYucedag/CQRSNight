using CQRSNight.DAL.Context;
using CQRSNight.MediatorDesignPattern.Commands;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Handlers
{
    public class RemoveEmployeeCommandHandler : IRequestHandler<RemoveEmployeeCommand>
    {
        private readonly CQRSContext _context;
        public RemoveEmployeeCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveEmployeeCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Employees.FindAsync(request.Id);
            _context.Employees.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
