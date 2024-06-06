using CQRSNight.DAL.Context;
using CQRSNight.MediatorDesignPattern.Queries;
using CQRSNight.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSNight.MediatorDesignPattern.Handlers
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, List<GetEmployeeQueryResult>>
    {
        private readonly CQRSContext _context;
        public GetEmployeeQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task<List<GetEmployeeQueryResult>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _context.Employees.Select(x => new GetEmployeeQueryResult
            {
                EmployeeId = x.EmployeeId,
                Name = x.Name,
                Salary = x.Salary,
                Surname = x.Surname
            }).ToListAsync();
        }
    }
}