using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class UserPurchaseHistory : BaseDomainModel
    {
        public int PurchaseId { get; set; }
        public int CustomerId { get; set; }
        public string Car { get; set; }
    }
}