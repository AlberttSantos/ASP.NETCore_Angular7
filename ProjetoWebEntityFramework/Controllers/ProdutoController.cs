using Microsoft.AspNetCore.Mvc;
using ProjetoWebEntityFramework.Dados.Entities;
using ProjetoWebEntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebEntityFramework.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProdutoController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_productRepository.ListarProdutos());
            }
            catch (Exception ex)
            {
                return BadRequest("Erro" + ex.Message);
            }
        }

        //recebe um int por parametro
        [HttpGet("{id:int}")]
        public IActionResult Get(int Id)
        {
            try
            {
                return Ok(_productRepository.ListarProdutos().FirstOrDefault(x => x.Id == Id));
            }
            catch (Exception ex)
            {
                //interpolação de string
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
                _productRepository.Salvar(produto);
                return Created("/api/produto", produto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}
