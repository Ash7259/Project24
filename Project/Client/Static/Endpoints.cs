using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string UserPurchaseHistoryEndpoint = $"{Prefix}/userpurchasehistories";
        public static readonly string CartEndpoint = $"{Prefix}/carts";
    }
}
