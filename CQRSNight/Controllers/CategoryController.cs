using CQRSNight.CQRSDesignPattern.Commands.CategoryCommands;
using CQRSNight.CQRSDesignPattern.Handlers.CategoryHandlers;
using CQRSNight.CQRSDesignPattern.Queries.CategoryQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSNight.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        public CategoryController(GetCategoryQueryHandler getCategoryQueryHandler, CreateCategoryCommandHandler createCategoryCommandHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
        }

        public IActionResult CategoryList()
        {
            var values = _getCategoryQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryCommand command)
        {
            _createCategoryCommandHandler.Handle(command);
            return RedirectToAction("CategoryList");
        }

        public IActionResult RemoveCategory(int id)
        {
            _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(UpdateCategoryCommand command)
        {
            _updateCategoryCommandHandler.Handle(command);
            return RedirectToAction("CategoryList");
        }
    }
}
