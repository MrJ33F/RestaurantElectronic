using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using RestaurantOnline.Models;
using RestaurantOnline.ViewModels;

namespace RestaurantOnline.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Item> Items;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                Items = _itemRepository.Items.OrderBy(p => p.ItemId);
                currentCategory = "All Items";
            }
            else
            {
                Items = _itemRepository.Items.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ItemId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }
            return View(new ItemsListViewModel
            {
                Items = Items,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
                return NotFound();

            return View(item);
        }
    }
}
