
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace PuRIM
{
    class InventoryManager
    {
        List<Product> productList = new List<Product>();
        public void AddProduct(dynamic productType, string name, double price, int ammount)
        {
            var p = new Product()
            {
                Name = name,
                Value = price,
                ProductType = productType,
                AmmountInStock = ammount
            };
            productList.Add(p);
        }

        public void RemoveProduct(string productName)
        {
           var p = GetProduct(productName);
           if (p != null)
            {
                productList.Remove(p);
            }
        }
        public Product GetProduct(string name)
        {
            foreach(Product p in productList)
            {
                if(p.Name == name)
                {
                    return p;
                }
            }
            return null;
        }
        public Product[] ListAllProducts()
        {
            return productList.ToArray();
        }
        public void Save(string dir = "products.json")
        {
            File.WriteAllText(dir, GetJson());
        }

        public void Load(string dir = "products.json") => productList = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(dir));

        public string GetJson() => JsonConvert.SerializeObject(productList, Formatting.Indented);

    }
}
