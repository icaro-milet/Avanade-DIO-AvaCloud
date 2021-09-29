using DIO.AvaCloud.Domain;
using DIO.AvaCloud.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DIO.AvaCloud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IRepository<Product> _repository;

        public ProductsController(IRepository<Product> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _repository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            if (product.Validate())
            {
                int result = await _repository.AddAsync(product);
                return StatusCode(201, new { id = result});
            }

            return StatusCode(403, "Invalid product");
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] Product product)
        {
            await _repository.DeleteAsync(product);

            return Ok("Delete success");
        }
    }
}
