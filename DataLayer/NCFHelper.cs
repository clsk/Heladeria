using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class NCFHelper : AbstractEntityHelper<NCF>
    {
        public NCFHelper()
            : base("NCF")
        { }

        public override NCF Get(int venta_id)
        {
            return base.Get("venta_id", venta_id);
        }

        public NCF GetEmpty()
        {
            try
            {
                return Provider.GetProvider().Database.SqlQuery<NCF>("SELECT TOP 1 * FROM NCF WHERE venta_id is null").SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Attach(NCF _NoComFis)
        {
            Provider.GetProvider().NCFs.Attach(_NoComFis);
        }
    }
}
