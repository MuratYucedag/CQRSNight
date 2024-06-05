using CQRSNight.CQRSDesignPattern.Results.CategoryResults;
using CQRSNight.DAL.Context;

namespace CQRSNight.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly CQRSContext _context;
        public GetCategoryQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetCategoryQueryResult> Handle()
        {
            var values = _context.Categories.Select(x => new GetCategoryQueryResult
            {
                CategoryName = x.CategoryName,
                CategoryId = x.CategoryId
            });
            return values.ToList();
        }
    }
}