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
        public Task<ProductModel> GetById(int id);
        public Task InsertOne(ProductModel model);
        public Task UpdateOne(ProductModel model);
        public Task DeleteOne(ProductModel model);
    }
}
