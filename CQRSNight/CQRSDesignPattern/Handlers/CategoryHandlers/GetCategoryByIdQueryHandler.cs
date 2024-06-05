using CQRSNight.CQRSDesignPattern.Queries.CategoryQueries;
using CQRSNight.CQRSDesignPattern.Results.CategoryResults;
using CQRSNight.DAL.Context;

namespace CQRSNight.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly CQRSContext _context;
        public GetCategoryByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public GetCategoryByIdQueryResult Handle(GetCategoryByIdQuery query)
        {
            var value = _context.Categories.Find(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = value.CategoryId,
                CategoryName = value.CategoryName
            };
        }
    }
}
