using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class MemoryRepository: IRepository
    {
        //private Dictionary<string, Product> products;
        private IModelStorage storage;
        public MemoryRepository(IModelStorage modelStore)
        {
            storage = modelStore;
        }
        //public MemoryRepository()
        //{
        //    products = new Dictionary<string, Product>();
        //    new List<Product>
        //    {
        //        new Product{Name = "Kayak", Price=275M},
        //        new Product{Name = "Lifejusket", Price= 48.95M},
        //        new Product{Name = "Soccer ball", Price= 19.50M}
        //    }.ForEach(p => AddProduct(p));
        //}
        public IEnumerable<Product> Products => storage.Items;
        public Product this[string name] =>storage[name];
        public void AddProduct(Product product) => storage[product.Name] = product;//как и где оно асоцеирует storage со словарем
        public void DeleteProduct(Product product) => storage.RemoveItem(product.Name);//Что такое storage
    }
}
