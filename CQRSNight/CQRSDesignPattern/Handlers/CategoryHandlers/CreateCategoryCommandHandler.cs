using CQRSNight.CQRSDesignPattern.Commands.CategoryCommands;
using CQRSNight.DAL.Context;
using CQRSNight.DAL.Entities;

namespace CQRSNight.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly CQRSContext _context;
        public CreateCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName
            });
            _context.SaveChanges();
        }
    }
}