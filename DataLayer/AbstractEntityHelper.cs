using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public abstract class AbstractEntityHelper<EntityType>
    {
        public AbstractEntityHelper(string table) 
        {
            _table = table;
        }

        public virtual List<EntityType> GetAll()
        {
            try
            {
                return Provider.GetProvider().Database.SqlQuery<EntityType>("SELECT * FROM " + _table, new object[0]).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual List<EntityType> GetAll(string conditional_str)
        {
            try
            {
                return Provider.GetProvider().Database.SqlQuery<EntityType>("SELECT * FROM " + _table + " WHERE " + conditional_str, new object[0]).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual EntityType Get(string id_parameter ,int id)
        {
            try
            {
                Object[] parameters = new Object[1];
                parameters[0] = new SqlParameter("@id", id);
                return Provider.GetProvider().Database.SqlQuery<EntityType>("SELECT * FROM " + _table + " WHERE " + id_parameter + " = @id", parameters).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual EntityType Get(int id)
        {
            return Get(_table.ToLower() + "_id", id);
        }

        public virtual EntityType Get(string conditional_str)
        {
            try
            {
                return Provider.GetProvider().Database.SqlQuery<EntityType>("SELECT * FROM " + _table + " WHERE " + conditional_str).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void SaveChanges()
        {
            Provider.GetProvider().SaveChanges();
        }

        protected string _table; 
    }
}
