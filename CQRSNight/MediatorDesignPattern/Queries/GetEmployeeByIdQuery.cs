using CQRSNight.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Queries
{
    public class GetEmployeeByIdQuery : IRequest<GetEmployeeByIdQueryResult>
    {
        public int Id { get; set; }
        public GetEmployeeByIdQuery(int id)
        {
            Id = id;
        }
    }
}