using System;
using PearlTech.Framework.Models;

namespace PearlTech.DAL.Repositories
{
    public class ProductOrderRepository : RepositoryBase<ProductOrder>
    {
        public ProductOrderRepository(DataContext context) : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}