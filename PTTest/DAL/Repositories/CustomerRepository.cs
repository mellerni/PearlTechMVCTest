using System;
using PTTest.Models;

namespace PTTest.DAL.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
            if(context == null)
                throw new ArgumentNullException();
        }
    }
}