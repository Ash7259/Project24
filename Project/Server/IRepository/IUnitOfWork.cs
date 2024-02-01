using Project.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Project.Server.IRepository;

namespace Project.Server.IRepository  // Adjust the namespace based on your project structure
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Cart> Carts { get; }
        IGenericRepository<UserPurchaseHistory> UserPurchaseHistories { get; }
        // Add other repositories for your entities here...

        // Example for a custom repository method
        Task<IList<Cart>> GetActiveCartsByCustomerId(int customerId);
    }
}
