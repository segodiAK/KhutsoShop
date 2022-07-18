using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using khutsoShop.Models;
using khutsoShop.ViewModels;
//using khutsoShop.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace khutsoShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        private object piesListViewModel;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;

            piesListViewModel.CurrentCategory = "Banana cakes";
            return View(piesListViewModel);
        }
    }
}
