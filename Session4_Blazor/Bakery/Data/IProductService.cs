using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Data
{
    public class IProductService
    {
        public IList<Product> Products { get; }
    }
}