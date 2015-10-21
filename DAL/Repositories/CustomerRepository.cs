using System;
using PearlTech.Framework.Models;

namespace PearlTech.DAL.Repositories
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