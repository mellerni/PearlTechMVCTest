using System;
using PTTest.Models;

namespace PTTest.DAL.Repositories
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