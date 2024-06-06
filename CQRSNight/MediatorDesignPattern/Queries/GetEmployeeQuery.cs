using CQRSNight.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Queries
{
    public class GetEmployeeQuery : IRequest<List<GetEmployeeQueryResult>>
    {
    }
}