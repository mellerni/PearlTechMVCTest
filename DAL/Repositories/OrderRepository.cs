using System;
using PearlTech.Framework.Models;

namespace PearlTech.DAL.Repositories
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(DataContext context): base(context)
        {
            if(context == null)
                throw new ArgumentNullException();
        }
    }
}