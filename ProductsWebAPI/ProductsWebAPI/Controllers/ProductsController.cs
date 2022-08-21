using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsWebAPI.Controllers
{
    using Core;
    using Infrastructure.DbConnectors;
    using Infrastructure.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private MongoDbConnection _db;
        public ProductsController()
        {
            _db = new MongoDbConnection(new ConfigService());
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IEnumerable<ProductModel>> Get()
        {
            return await _db.GetAllAsync();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ProductModel> Get(int id)
        {
            return await _db.GetByIdAsync(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task Post([FromBody] ProductModel product)
        {
            await _db.InsertOneAsync(product);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ProductModel product)
        {
            var oldProduct = await _db.GetByIdAsync(id);
            oldProduct.ReplaceNotNullProperties(product);
            await _db.UpdateOneAsync(oldProduct);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _db.DeleteOneAsync(id);
        }
    }
}
