using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Core.BaseProvider;
using VOL.Entity.DomainModels;
using VOL.Core.Extensions.AutofacManager;
namespace VOL.System.IRepositories
{
    public partial interface IWms_ProductCatalogRepository : IDependency,IRepository<Wms_ProductCatalog>
    {
    }
}

