namespace Core
{
    using MongoDB.Bson.Serialization.Attributes;
    using MongoDB.Bson;
    public class ProductModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string _id;
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? Price { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public void ReplaceNotNullProperties(ProductModel product)
        {
            if (product.ProductId is not null)
            {
                ProductId = product.ProductId;
            }

            if (product.Name is not null)
            {
                Name = product.Name;
            }

            if (product.Url is not null)
            {
                Url = product.Url;
            }

            if (product.Price is not null)
            {
                Price = product.Price;
            }

            if (product.ShortDescription is not null)
            {
                ShortDescription = product.ShortDescription;
            }

            if (product.Description is not null)
            {
                Description = product.Description;
            }
        }
    }
}