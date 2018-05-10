using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {

        public Product Retrieve(int productId)
        {
            Product product = new Product();

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mirrow";
                product.CurrentPrice = 15.98M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                }
                else
                {

                }
            }
            return success;
        }
    }
}
