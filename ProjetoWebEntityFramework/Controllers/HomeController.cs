using Microsoft.AspNetCore.Mvc;
using ProjetoWebEntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _repository;

        public HomeController(IProductRepository productRepository)
        {
            _repository = productRepository;
        }

        //Retorna a view com o nome Index 
        public IActionResult Index()
        {
            return View(_repository.ListarProdutos());
        }

        public string Obter()
        {
            return "Teste 2";
        }
    }
}
