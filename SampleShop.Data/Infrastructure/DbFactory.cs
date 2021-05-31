using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        SampleShopDbContext dbContext;
        public SampleShopDbContext Init()
        {
            return dbContext ?? (dbContext = new SampleShopDbContext());
        }

        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
