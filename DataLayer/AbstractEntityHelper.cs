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
                List<EntityType> entities = Provider.GetProvider().Database.SqlQuery<EntityType>("SELECT * FROM " + _table, new object[0]).ToList();
                return entities;
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
                List<EntityType> entities = Provider.GetProvider().Database.SqlQuery<EntityType>("SELECT * FROM " + _table + " WHERE " + conditional_str, new object[0]).ToList();
                return entities;
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
                EntityType entity = Provider.GetProvider().Database.SqlQuery<EntityType>("SELECT * FROM " + _table + " WHERE " + id_parameter + " = @id", parameters).SingleOrDefault();
                return entity;
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
                EntityType entity = Provider.GetProvider().Database.SqlQuery<EntityType>("SELECT * FROM " + _table + " WHERE " + conditional_str).SingleOrDefault();
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected string _table; 
    }
}
