using CQRSNight.CQRSDesignPattern.Commands.ProductCommands;
using CQRSNight.DAL.Context;
using CQRSNight.DAL.Entities;

namespace CQRSNight.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly CQRSContext _context;
        public CreateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                CategoryId = command.CategoryId,
                Description = command.Description,
                ImageUrl = command.ImageUrl,
                Price = command.Price,
                ProductName = command.ProductName,
                Stock = command.Stock
            });
            _context.SaveChanges();
        }
    }
}
