using Microsoft.AspNetCore.Mvc;
using RestaurantOnline.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;
        public HomeController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ItemsOfTheWeek = _itemRepository.ItemsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
