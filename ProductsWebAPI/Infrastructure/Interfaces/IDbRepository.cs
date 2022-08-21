using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    using Core;
    internal interface IDbRepository
    {
        public Task<List<ProductModel>> GetAllAsync();

        public Task<ProductModel> GetByIdAsync(int id);
        public Task InsertOneAsync(ProductModel model);
        public Task UpdateOneAsync(ProductModel model);
        public Task DeleteOneAsync(int id);
    }
}
