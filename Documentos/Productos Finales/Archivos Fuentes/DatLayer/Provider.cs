using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{

        public class Provider
        {
            private heladeriaEntities _provider;
            private static Provider _unique = null;
            private Provider()
            {
                if (_unique == null)
                {
                    _provider = new heladeriaEntities();
                    _unique = this;
                }
            }

            public static heladeriaEntities GetProvider()
            {
                if (_unique == null)
                    _unique = new Provider();
                return _unique._provider;
            }
        }
}
