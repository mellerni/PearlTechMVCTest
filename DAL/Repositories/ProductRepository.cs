using System;
using PearlTech.Framework.Models;

namespace PearlTech.DAL.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(DataContext context)
            :base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}