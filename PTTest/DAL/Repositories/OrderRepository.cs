using System;
using PTTest.Models;

namespace PTTest.DAL.Repositories
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