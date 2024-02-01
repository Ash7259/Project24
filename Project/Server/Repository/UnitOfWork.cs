// UnitOfWork.cs

using Project.Server.Data;
using Project.Server.IRepository;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Project.Shared.Domain;

namespace Project.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Cart> _carts;
        private IGenericRepository<UserPurchaseHistory> _userPurchaseHistories;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Cart> Carts
            => _carts ??= new GenericRepository<Cart>(_context);

        public IGenericRepository<UserPurchaseHistory> UserPurchaseHistories
            => _userPurchaseHistories ??= new GenericRepository<UserPurchaseHistory>(_context);

        // Add other repositories for your entities here...

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task Save(HttpContext httpContext)
        {
            // Custom logic for saving changes, if needed
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Cart>> GetActiveCartsByCustomerId(int customerId)
        {
            // Custom logic for retrieving active carts by customer ID
            // This method should be implemented in your GenericRepository or elsewhere
            throw new NotImplementedException();
        }
    }
}
